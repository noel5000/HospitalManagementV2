using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.EntityFramework;
using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

public class MainDataContext : DbContext
{
    private readonly IHttpContextAccessor _HttpContextAccessor;
    readonly IMemoryCache _cache;
    private readonly ITenantService _TenantService;

    //private bool CanUseSessionContext { get; set; }
    //public ComplaintDataContext()
    //{
    //    CanUseSessionContext = true;
    //}


    public MainDataContext(DbContextOptions<MainDataContext> options,
        IHttpContextAccessor httpContextAccessor,
        IMemoryCache cache,
        ITenantService service)
        : base(options)
    {
        _HttpContextAccessor = httpContextAccessor;
        this._cache = cache;
        _TenantService = service;
        //CanUseSessionContext = true;
    }
    #region Tables

    public virtual DbSet<Insurance> Insurances { get; set; }
    public virtual DbSet<InsurancePlan> InsurancePlans { get; set; }
    public virtual DbSet<CashRegister> CashRegisters { get; set; }
    public virtual DbSet<LanguageKey> LanguageKeys { get; set; }
    public virtual DbSet<CashRegisterOpening> CashRegisterOpenings { get; set; }
    public virtual DbSet<CashRegisterOpeningDetail> CashRegisterOpeningDetails { get; set; }
    public virtual DbSet<CashRegisterFlowDetail> CashRegisterFlowDetails { get; set; }
    public virtual DbSet<CustomerPayment> CustomersPayments { get; set; }
    public virtual DbSet<CompositeProduct> CompositeProducts { get; set; }
    public virtual DbSet<CreditNote> CreditNotes { get; set; }
    public virtual DbSet<Currency> Currencies { get; set; }
    public virtual DbSet<CompanyPayments> CompanyPayments { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<School> Schools { get; set; }
    public virtual DbSet<SchoolContact> SchoolContacts { get; set; }
    public virtual DbSet<CustomerBalance> CustomersBalance { get; set; }
    public virtual DbSet<CustomerReturn> CustomersReturns { get; set; }
    public virtual DbSet<CustomerReturnDetail> CustomersReturnDetails { get; set; }
    public virtual DbSet<Expense> Expenses { get; set; }
    public virtual DbSet<ExpenseTax> ExpenseTaxes { get; set; }
    public virtual DbSet<ExpensesPayment> ExpensesPayments { get; set; }
    public virtual DbSet<InventoryEntry> InventoryEntries { get; set; }
    public virtual DbSet<Invoice> Invoices { get; set; }
    public virtual DbSet<InvoiceLead> InvoicesLeads { get; set; }


    public virtual DbSet<Menu> Menus { get; set; }
    public virtual DbSet<MenuDetail> MenuDetails { get; set; }
    public virtual DbSet<LeadDetail> LeadsDetails { get; set; }
    public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
    public virtual DbSet<InvoiceTax> InvoicesTaxes { get; set; }
    public virtual DbSet<BranchOffice> BranchOffices { get; set; }
    public virtual DbSet<MovementType> MovementTypes { get; set; }
    public virtual DbSet<OpeningAmount> OpeningsAmounts { get; set; }
    public virtual DbSet<PaymentType> PaymentTypes { get; set; }
    public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<ProductTax> ProductTaxes { get; set; }
    public virtual DbSet<ReturnDetail> ReturnDetails { get; set; }
    public virtual DbSet<Seller> Sellers { get; set; }
    public virtual DbSet<SequenceControl> SequencesControl { get; set; }
    public virtual DbSet<SupplierReturn> SuppliersReturns { get; set; }
    public virtual DbSet<Supplier> Suppliers { get; set; }
    public virtual DbSet<Language> Languages { get; set; }
    public virtual DbSet<SupplierBalance> SuppliersBalances { get; set; }
    public virtual DbSet<Tax> Taxes { get; set; }
    public virtual DbSet<TRNControl> TRNsControl { get; set; }
    public virtual DbSet<Unit> Units { get; set; }
    public virtual DbSet<MedicalSpeciality> MedicalSpecialities { get; set; }
    public virtual DbSet<UnitProductEquivalence> UnitProductsEquivalences { get; set; }
    public virtual DbSet<ProductSupplierCost> ProductSupplierCosts { get; set; }
    public virtual DbSet<Warehouse> Warehouses { get; set; }
    public virtual DbSet<WarehouseMovement> WarehousesMovements { get; set; }
    public virtual DbSet<Inventory> Inventory { get; set; }
    public virtual DbSet<WarehouseTransfer> WarehousesTransfers { get; set; }
    public virtual DbSet<Zone> Zones { get; set; }

    public virtual DbSet<Section> Sections { get; set; }
    public virtual DbSet<SectionOperation> SectionOperations { get; set; }
    public virtual DbSet<Operation> Operations { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<RoleSectionOperation> RoleSectionOperations { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<UserClaims> UsersClaims { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }
    public virtual DbSet<InsuranceServiceCoverage> InsuranceServiceCoverages { get; set; }
    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<AppointmentDetail> AppointmentDetails { get; set; }
    public virtual DbSet<PatientCheckup> PatientCheckups { get; set; }
    public virtual DbSet<CheckupPrescription> CheckupPrescriptions { get; set; }

    public virtual DbSet<FileAttachment> FileAttachments { get; set; }
    public virtual DbSet<CheckupAttachment> CheckupAttachments { get; set; }

    public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; }





    #endregion



    #region Connection String 

    protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
    {

    }

    #endregion

    #region Fluent API

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        this.SetTenantQuery(modelBuilder);
        modelBuilder.Entity<Insurance>()
         .HasMany(p => p.InsurancePlans)
         .WithOne(d => d.Insurance).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PatientCheckup>()
        .HasMany(p => p.CheckupPrescriptions)
        .WithOne(d => d.PatientCheckup).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CheckupPrescription>()
        .HasOne(p => p.PatientCheckup)
        .WithMany(d => d.CheckupPrescriptions).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Insurance>()
        .HasMany(p => p.Affiliates)
        .WithOne(d => d.Insurance).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<InsurancePlan>()
      .HasMany(p => p.SubscribedPatients)
      .WithOne(d => d.InsurancePlan).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Invoice>()
          .HasMany(p => p.InvoiceDetails)
          .WithOne(d => d.Invoice).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Invoice>()
          .HasMany(p => p.Taxes)
          .WithOne(d => d.Invoice).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Invoice>()
         .HasMany(p => p.Payments)
         .WithOne(d => d.Invoice).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Customer>()
         .HasMany(p => p.CustomerBalances)
         .WithOne(d => d.Customer).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<InvoiceLead>()
          .HasMany(p => p.LeadDetails)
          .WithOne(d => d.Lead).OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Menu>()
         .HasMany(p => p.MenuDetails)
         .WithOne(d => d.Menu).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<MenuDetail>()
          .HasOne(p => p.Menu)
          .WithMany(d => d.MenuDetails).OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Section>()
         .HasMany(p => p.Operations)
         .WithOne(d => d.Section).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Role>()
       .HasMany(p => p.SectionOperations)
       .WithOne(d => d.Role).OnDelete(DeleteBehavior.Restrict);


        modelBuilder.Entity<Language>().HasIndex(x => x.Code).IsUnique();
        modelBuilder.Entity<Language>().HasKey(x => x.Code).HasName("Code");
        modelBuilder.Entity<Product>()
         .HasMany(p => p.Taxes)
         .WithOne(d => d.Product).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<BranchOffice>()
        .HasMany(x => x.Warehouses)
        .WithOne(x => x.BranchOffice)
        .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CustomerPayment>()
      .HasOne(x => x.Invoice)
      .WithMany(x => x.Payments);

        modelBuilder.Entity<CashRegisterOpening>()
       .HasMany(x => x.Details)
       .WithOne(x => x.CashRegisterOpening)
       .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CashRegisterOpening>()
      .HasMany(x => x.CashFlow)
      .WithOne(x => x.CashRegisterOpening)
      .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CashRegisterOpeningDetail>()
      .HasOne(x => x.CashRegisterOpening)
      .WithMany(x => x.Details)
      .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CashRegisterFlowDetail>()
  .HasOne(x => x.CashRegisterOpening)
  .WithMany(x => x.CashFlow)
  .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<BranchOffice>()
       .HasMany(x => x.CashRegisters)
       .WithOne(x => x.BranchOffice)
       .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<BranchOffice>()
 .HasMany(x => x.Users)
 .WithOne(x => x.BranchOffice)
 .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PaymentType>()
.HasMany(x => x.ExpensesPayments)
.WithOne(x => x.PaymentType)
.OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PaymentType>()
.HasMany(x => x.Expenses)
.WithOne(x => x.PaymentType)
.OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PaymentType>()
.HasMany(x => x.InvoicesPayments)
.WithOne(x => x.PaymentType)
.OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<User>()
     .HasMany(x => x.CashRegisterOpeningClosings)
     .WithOne(x => x.User)
     .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<MedicalSpeciality>()
 .HasMany(x => x.Doctors)
 .WithOne(x => x.MedicalSpeciality)
 .OnDelete(DeleteBehavior.SetNull);


        modelBuilder.Entity<CompositeProduct>()
      .HasOne(x => x.UnitProductEquivalence)
      .WithMany(y => y.CompositeProducts)
      .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Expense>()
   .HasOne(x => x.PaymentType)
   .WithMany(y => y.Expenses)
   .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Expense>()
.HasMany(x => x.Taxes)
.WithOne(y => y.Expense)
.OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ExpensesPayment>()
   .HasOne(x => x.PaymentType)
   .WithMany(y => y.ExpensesPayments)
   .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Payment>()
   .HasOne(x => x.PaymentType)
   .WithMany(y => y.InvoicesPayments)
   .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Warehouse>()
        .HasOne(x => x.BranchOffice)
        .WithMany(x => x.Warehouses);

        modelBuilder.Entity<SectionOperation>()
        .HasOne(x => x.Section)
        .WithMany(x => x.Operations)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<SectionOperation>()
        .HasOne(x => x.Operation)
        .WithMany(x => x.Sections)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Product>()
        .HasMany(p => p.ProductUnits)
        .WithOne(d => d.Product).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Product>()
        .HasMany(p => p.BaseCompositeProducts)
        .WithOne(d => d.Product).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Product>()
       .HasMany(p => p.Taxes)
       .WithOne(d => d.Product).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Product>()
       .HasMany(p => p.SuppliersCosts)
       .WithOne(d => d.Product).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Supplier>()
      .HasMany(p => p.ProductsCosts)
      .WithOne(d => d.Supplier).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<User>().Property(x => x.UserId).HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<LanguageKey>().HasKey(o => new { o.LanguageCode, o.Key });
        modelBuilder.Entity<Section>().HasMany(x => x.Operations).WithOne(x => x.Section).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Operation>().HasMany(x => x.Sections).WithOne(x => x.Operation).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<SectionOperation>().HasOne(y => y.Operation).WithMany(y => y.Sections).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<SectionOperation>().HasOne(y => y.Section).WithMany(x => x.Operations).OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<PatientCheckup>()
       .HasMany(x => x.Attachments)
       .WithOne(x => x.PatientCheckup)
       .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CheckupAttachment>().HasOne(x => x.PatientCheckup).WithMany(d => d.Attachments).OnDelete(DeleteBehavior.NoAction);



        foreach (var property in modelBuilder.Model.GetEntityTypes()
          .SelectMany(t => t.GetProperties())
          .Where(p => p.ClrType == typeof(decimal)))
        {
            property.SetColumnType("decimal(18, 2)");
        }

        var cascadeFKs = modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetForeignKeys())
                        .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

        foreach (var fk in cascadeFKs)
            fk.DeleteBehavior = DeleteBehavior.Restrict;

        ModelBuilderExtensions.Seed(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }

    private void SetTenantQuery(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<AppointmentDetail>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<BranchOffice>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CashRegisterFlowDetail>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CashRegisterOpeningDetail>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CashRegisterOpening>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CashRegister>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CheckupAttachment>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CheckupPrescription>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CompanyPayments>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CompositeProduct>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CreditNote>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Currency>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Customer>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CustomerBalance>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CustomerPayment>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CustomerReturn>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<CustomerReturnDetail>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<ExceptionLog>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Expense>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<ExpensesPayment>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<ExpenseTax>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<FileAttachment>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Insurance>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<InsurancePlan>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<InsuranceServiceCoverage>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Inventory>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<InventoryEntry>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Invoice>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<InvoiceDetail>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<InvoiceLead>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<InvoiceTax>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<LeadDetail>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<MedicalSpeciality>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Menu>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<MenuDetail>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<PatientCheckup>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Payment>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<PaymentDetail>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Product>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<ProductSupplierCost>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<ProductTax>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<School>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<SchoolContact>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Seller>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<SequenceControl>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Supplier>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<SupplierBalance>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<SupplierReturn>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Tax>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<TRNControl>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Unit>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<UnitProductEquivalence>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        //modelBuilder.Entity<User>()
        //         .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        //modelBuilder.Entity<UserClaims>()
        //         .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        //modelBuilder.Entity<UserRole>()
        //         .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Warehouse>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<WarehouseMovement>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<WarehouseTransfer>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
        modelBuilder.Entity<Zone>()
                 .HasQueryFilter(mt => !string.IsNullOrEmpty(_TenantService.Tenant) && mt.TenantId == _TenantService.Tenant);
    }

    #endregion

    #region Save Changes
    public override int SaveChanges()
    {

        // Get the entries that are auditable
        var auditableEntitySet = ChangeTracker.Entries<ICommonData>();

        if (auditableEntitySet != null)
        {
            DateTime currentDate = DateTime.Now;

            // Audit set the audit information foreach record
            foreach (var auditableEntity in auditableEntitySet.Where(c => c.State == EntityState.Added || c.State == EntityState.Modified || c.State == EntityState.Deleted))
            {
                if (auditableEntity.State == EntityState.Added)
                {
                    auditableEntity.Entity.Active = true;
                    auditableEntity.Entity.TenantId = _TenantService.Tenant;
                    auditableEntity.Entity.CreatedDate = currentDate;
                }

                auditableEntity.Entity.ModifiedDate = currentDate;
                if (_HttpContextAccessor != null && _HttpContextAccessor.HttpContext != null && _HttpContextAccessor.HttpContext.Request != null && _HttpContextAccessor.HttpContext.Request.Headers != null)
                {
                    if (_HttpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
                    {
                        if (auditableEntity.State == EntityState.Added)
                        {
                            auditableEntity.Entity.CreatedBy = new Guid(_HttpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Id")?.Value);
                            auditableEntity.Entity.CreatedByName = _HttpContextAccessor.HttpContext.User.Identity.Name;
                        }
                        auditableEntity.Entity.ModifiedBy = new Guid(_HttpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Id")?.Value);
                        auditableEntity.Entity.ModifiedByName = _HttpContextAccessor.HttpContext.User.Identity.Name;
                        auditableEntity.Entity.TenantId = _TenantService.Tenant;
                    }
                }
                if (auditableEntity.State == EntityState.Deleted)
                {
                    auditableEntity.Entity.Active = false;
                    auditableEntity.State = EntityState.Modified;
                }

                if (auditableEntity.State == EntityState.Modified)
                {
                    auditableEntity.Property(nameof(ICommonData.CreatedDate)).IsModified = false;
                    auditableEntity.Property(nameof(ICommonData.CreatedBy)).IsModified = false;
                    auditableEntity.Property(nameof(ICommonData.CreatedByName)).IsModified = false;
                }
            }
        }

        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        // Get the entries that are auditable
        var auditableEntitySet = ChangeTracker.Entries<ICommonData>();

        if (auditableEntitySet != null)
        {
            DateTime currentDate = DateTime.Now;

            // Audit set the audit information foreach record
            foreach (var auditableEntity in auditableEntitySet.Where(c => c.State == EntityState.Added || c.State == EntityState.Modified || c.State == EntityState.Deleted))
            {
                if (auditableEntity.State == EntityState.Added)
                {
                    auditableEntity.Entity.Active = true;
                    auditableEntity.Entity.CreatedDate = currentDate;
                }

                auditableEntity.Entity.ModifiedDate = currentDate;
                if (_HttpContextAccessor != null && _HttpContextAccessor.HttpContext != null && _HttpContextAccessor.HttpContext.Request != null && _HttpContextAccessor.HttpContext.Request.Headers != null)
                {
                    if (_HttpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
                    {
                        if (auditableEntity.State == EntityState.Added)
                        {
                            auditableEntity.Entity.CreatedBy = new Guid(_HttpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Id")?.Value);
                            auditableEntity.Entity.CreatedByName = _HttpContextAccessor.HttpContext.User.Identity.Name;
                        }
                        auditableEntity.Entity.TenantId = _TenantService.Tenant;
                        auditableEntity.Entity.ModifiedBy = new Guid(_HttpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Id")?.Value);
                        auditableEntity.Entity.ModifiedByName = _HttpContextAccessor.HttpContext.User.Identity.Name;
                    }
                }
                if (auditableEntity.State == EntityState.Deleted)
                {
                    auditableEntity.Entity.Active = false;
                    auditableEntity.State = EntityState.Modified;
                }

                if (auditableEntity.State == EntityState.Modified)
                {
                    auditableEntity.Property(nameof(ICommonData.CreatedDate)).IsModified = false;
                    auditableEntity.Property(nameof(ICommonData.CreatedBy)).IsModified = false;
                    auditableEntity.Property(nameof(ICommonData.CreatedByName)).IsModified = false;
                }
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {

        // Get the entries that are auditable
        var auditableEntitySet = ChangeTracker.Entries<ICommonData>();

        if (auditableEntitySet != null)
        {
            DateTime currentDate = DateTime.Now;

            // Audit set the audit information foreach record
            foreach (var auditableEntity in auditableEntitySet.Where(c => c.State == EntityState.Added || c.State == EntityState.Modified || c.State == EntityState.Deleted))
            {
                if (auditableEntity.State == EntityState.Added)
                {
                    auditableEntity.Entity.Active = true;
                    auditableEntity.Entity.CreatedDate = currentDate;
                }

                auditableEntity.Entity.ModifiedDate = currentDate;
                if (_HttpContextAccessor != null && _HttpContextAccessor.HttpContext != null && _HttpContextAccessor.HttpContext.Request != null && _HttpContextAccessor.HttpContext.Request.Headers != null)
                {
                    if (_HttpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
                    {
                        if (auditableEntity.State == EntityState.Added)
                        {
                            auditableEntity.Entity.CreatedBy = new Guid(_HttpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Id")?.Value);
                            auditableEntity.Entity.CreatedByName = _HttpContextAccessor.HttpContext.User.Identity.Name;
                        }
                        auditableEntity.Entity.TenantId = _TenantService.Tenant;
                        auditableEntity.Entity.ModifiedBy = new Guid(_HttpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Id")?.Value);
                        auditableEntity.Entity.ModifiedByName = _HttpContextAccessor.HttpContext.User.Identity.Name;
                    }
                }
                if (auditableEntity.State == EntityState.Deleted)
                {
                    auditableEntity.Entity.Active = false;
                    auditableEntity.State = EntityState.Modified;
                }

                if (auditableEntity.State == EntityState.Modified)
                {
                    auditableEntity.Property(nameof(ICommonData.CreatedDate)).IsModified = false;
                    auditableEntity.Property(nameof(ICommonData.CreatedBy)).IsModified = false;
                    auditableEntity.Property(nameof(ICommonData.CreatedByName)).IsModified = false;
                }
            }
        }

        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    #endregion

    #region Session Context



    #endregion
}
