using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.FrontEnd.Helpers;
using PointOfSalesV2.Repository;
using System;
using System.IO;
using System.Text;

namespace PointOfSalesV2.FrontEnd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var appSettings = Configuration.GetSection("AppSettings").Get<AppSettings>();
            var connections = Configuration.GetSection("ConnectionStrings").Get<ConnectionStrings>();
            services.AddRouting();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
         options.TokenValidationParameters = new TokenValidationParameters
         {
             ValidateIssuer = true,
             ValidateAudience = true,
             ValidateLifetime = true,
             ValidateIssuerSigningKey = true,
             ValidIssuer = appSettings.Domain,
             ValidAudience = appSettings.Domain,
             IssuerSigningKey = new SymmetricSecurityKey(
             Encoding.UTF8.GetBytes(appSettings.TokenKey)),
             ClockSkew = TimeSpan.Zero
         });
            services.AddCors(o => o.AddPolicy("AllowAllOrigins", builder =>
            {
                
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            services.AddControllers(mvcOptions =>
            {
                mvcOptions.EnableEndpointRouting = false;
            });
            services.AddControllersWithViews();

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
            services.AddControllers().AddOData(opt => opt.AddRouteComponents("odata", OdataHelper.GetEdmModel()).Expand().Select().Filter().Count().SetMaxTop(null).OrderBy());
            services.AddControllers().AddOData(opt => opt.AddRouteComponents("odata/exporttoexcel", OdataHelper.GetEdmModel()).Expand().Select().Filter().Count().SetMaxTop(null).OrderBy());
            services.AddMemoryCache();
            services.AddDbContext<MainDataContext>(options =>
            {
                var connection = new SqlConnection(connections.Main);
                options.UseSqlServer(connection);

            });
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            TranslateUtility.SetHttpContext(services.BuildServiceProvider().GetService<IHttpContextAccessor>());
            services.AddSingleton<IFileProvider>(
               new PhysicalFileProvider(
                   Path.Combine(Directory.GetCurrentDirectory(), "")));

            services.AddScoped<IBranchOfficeRepository, BranchOfficeRepository>();
            services.AddScoped<ICashRegisterOpeningRepository, CashRegisterOpeningRepository>();
            services.AddScoped<IRoleSectionOperationRepository, RoleSectionOperationRepository>();
            services.AddScoped<ISellerRepository, SellerRepository>();
            services.AddScoped<ISequenceManagerRepository, SequenceManagerRepository>();
            services.AddScoped<ICompanyPaymentRepository, CompanyPaymentRepository>();
            services.AddScoped<ILanguageKeyRepository, LanguageKeyRepository>();
            services.AddScoped<IBusinessStateRepository, BusinessStateRepository>();
            services.AddScoped<ICompositeProductRepository, CompositeProductRepository>();
            services.AddScoped<ICreditNoteRepository, CreditNoteRepository>();
            services.AddScoped<ICustomerBalanceRepository, CustomerBalanceRepository>();
            services.AddScoped<ICustomerReturnRepository, CustomerReturnRepository>();
            services.AddScoped<ICustomerPaymentRepository, CustomerPaymentRepository>();
            services.AddScoped<IExpenseRepository, ExpenseRepository>();
            services.AddScoped<IExpensesPaymentRepository, ExpensesPaymentRepository>();
            services.AddScoped<IInventoryEntryRepository, InventoryEntryRepository>();
            services.AddScoped<IExpenseTaxRepository, ExpenseTaxRepository>();
            services.AddScoped<IInventoryRepository, InventoryRepository>();
            services.AddScoped<IInvoiceDetailRepository, InvoiceDetailRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IInvoiceTaxRepository, InvoiceTaxRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductTaxRepository, ProductTaxRepository>();
            services.AddScoped<ISupplierReturnRepository, SupplierReturnRepository>();
            services.AddScoped<IUnitProductEquivalenceRepository, UnitProductEquivalenceRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IWarehouseMovementRepository, WarehouseMovementRepository>();
            services.AddScoped<IWarehouseRepository, WarehouseRepository>();
            services.AddScoped<IWarehouseTransferRepository, WarehouseTransferRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IInsuranceRepository, InsuranceRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDataRepositoryFactory, DataRepositoriesFactory>();
            services.AddScoped<IPatientCheckupRepository, PatientCheckupRepository>();

            //New instance for injection
            services.AddTransient(typeof(IBase<>), typeof(Repository<>));
            services.AddMvc(a => { });
            services.AddControllers().AddNewtonsoftJson(options =>
     options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
 );


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseCors("AllowAllOrigins");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
