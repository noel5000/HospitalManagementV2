using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Api.Controllers;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;
using PointOfSalesV2.Common;
using System.Linq;
using System.Collections.Generic;
using Microsoft.OData.Edm;
using Newtonsoft.Json;
using System;

namespace PointOfSalesV2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GetLanguageKeysJsonFile();
        }

        public void GetLanguageKeysJsonFile() 
        {
            var provider = this.StartDI();
            var fileLines = System.IO.File.ReadAllLines("D:\\Code\\Code\\HospitalV2\\source\\PointOfSalesV2.Common\\languagekeys.csv").ToList();
            var langKeysRepo = provider.GetService<IDataRepositoryFactory>().GetDataRepositories<LanguageKey>();
            var currentKeys = langKeysRepo.GetAll(x => x, y => y.Active == true);
            List<LanguageKey> list = new List<LanguageKey>();
            fileLines.ForEach(l => {
                var keyValues = l.Split(",");
                if (keyValues[0] != "LanguageCode")
                {
                    LanguageKey spanishKey = new LanguageKey()
                    {
                        CreatedBy = new System.Guid(),
                        CreatedDate = DateTime.Now,
                        Active = true,
                        CreatedByName = "admin",
                        Key = keyValues[1],
                        LanguageCode = keyValues[0],
                        LanguageId = Convert.ToInt64(keyValues[9]),
                        Value = keyValues[10]
                    };

                    if (!list.Exists(y => y.Key == spanishKey.Key && y.LanguageCode==spanishKey.LanguageCode))
                        list.Add(spanishKey);
                   
                  
                }
               
            });
           
            langKeysRepo.AddRange(list);

            string result = JsonConvert.SerializeObject(langKeysRepo.GetAll().Data);
        }

        public ServiceProvider StartDI() 
        {
            string connectionString = "Server=localhost\\MSSQLSERVER01;Database=hospitalV2;Trusted_Connection=True;";
            ServiceProvider serviceProvider = new ServiceCollection()
                  .AddDbContext<MainDataContext>(options =>
                  {
                      var connection = new SqlConnection(connectionString);
                      options.UseSqlServer(connection);

                  })
           .AddLogging()
           .AddMemoryCache()
           .AddSingleton<IHttpContextAccessor, HttpContextAccessor>()
           .AddSingleton<IUnitOfWork, UnitOfWork>()
           .AddSingleton<IDataRepositoryFactory, DataRepositoriesFactory>()
           .AddTransient(typeof(IBase<>), typeof(Repository<>))
         
           .BuildServiceProvider();
            return serviceProvider;
        }


    }
}
