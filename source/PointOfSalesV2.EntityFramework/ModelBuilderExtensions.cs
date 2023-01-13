using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.EntityFramework
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Operation> operations = new List<Operation>();
            foreach (var operation in Enum.GetValues(typeof(Operations)).Cast<Operations>().ToList())
            {
                operations.Add(new Operation()
                {
                    Id = (long)operation,
                    Name = operation.ToString(),
                    Active = true,
                    CreatedBy = new Guid("8A2FDD4A-E702-482C-F181-08D7015E3521"),
                    CreatedDate = new DateTime(2000, 1, 1),
                    CreatedByName = "admin",
                    TenantId = "BaseTenant",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{operation.ToString()}{(char)34}{(char)125}]," +
                    $"{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{operation.ToString()}{(char)34}{(char)125}]{(char)125}"
                });
            }
            var sections = new List<Section>();
            foreach (var section in Enum.GetValues(typeof(Controllers)).Cast<Controllers>().ToList())
            {
                if (section != Controllers.NotSpecified)
                    sections.Add(new Section()
                    {
                        Id = (long)section,
                        Name = section.ToString(),
                        Controllers=section.ToString(),
                        Active = true,
                        CreatedBy = new Guid("8A2FDD4A-E702-482C-F181-08D7015E3521"),
                        CreatedDate = new DateTime(2000, 1, 1),
                        CreatedByName = "admin",
                        TenantId = "BaseTenant",
                        TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{section.ToString()}{(char)34}{(char)125}]," +
                        $"{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{section.ToString()}{(char)34}{(char)125}]{(char)125}"
                    });
            }
            var roles = JsonConvert.DeserializeObject<List<Role>>("");
           var roleSectionOperations = JsonConvert.DeserializeObject<List<RoleSectionOperation>>("[]");

            var paymentTypes = new List<PaymentType>();

            foreach (var paymentType in Enum.GetValues(typeof(PaymentTypes)).Cast<PaymentTypes>().ToList())
            {
                paymentTypes.Add(new PaymentType()
                {
                    Id = (long)paymentType,
                    Name = paymentType.ToString(),
                    Active = true,
                    Code = (short)paymentType,
                    CreatedBy = new Guid("8A2FDD4A-E702-482C-F181-08D7015E3521"),
                    CreatedDate = new DateTime(2000, 1, 1),
                    CreatedByName = "admin",
                    TenantId = "BaseTenant",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{Enums.GetPaymentTypeSpanishName.FirstOrDefault(x => x.Key == paymentType).Value}{(char)34}{(char)125}]," +
                    $"{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{Enums.GetPaymentTypeEnglishName.FirstOrDefault(x => x.Key == paymentType).Value}{(char)34}{(char)125}]{(char)125}"
                });
            }

            var sequenceControls = new List<SequenceControl>();
            foreach (var sequence in Enum.GetValues(typeof(SequenceTypes)).Cast<SequenceTypes>().ToList())
            {
                sequenceControls.Add(new SequenceControl()
                {
                    Id = (long)sequence,
                    Name = sequence.ToString(),
                    Active = true,
                    NumericControl = 0,
                    Code = (short)sequence,
                    TenantId = "BaseTenant",
                    CodeName = ((SequenceTypeCode)(short)sequence).ToString(),
                    CreatedBy = new Guid("8A2FDD4A-E702-482C-F181-08D7015E3521"),
                    CreatedDate = new DateTime(2000, 1, 1),
                    CreatedByName = "admin",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{sequence.ToString()}{(char)34}{(char)125}]," +
                    $"{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{sequence.ToString()}{(char)34}{(char)125}]{(char)125}"
                });
            }
            var movementTypes = new List<MovementType>();
            foreach (var movement in Enum.GetValues(typeof(MovementTypes)).Cast<MovementTypes>().ToList())
            {
                movementTypes.Add(new MovementType()
                {
                    Id = (long)movement,
                    Name = movement.ToString(),
                    Active = true,
                    TenantId = "BaseTenant",
                    Code = (short)movement,
                    CreatedBy = new Guid("8A2FDD4A-E702-482C-F181-08D7015E3521"),
                    CreatedDate = new DateTime(2000, 1, 1),
                    CreatedByName = "admin",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{movement.ToString()}{(char)34}{(char)125}]," +
                    $"{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}{movement.ToString()}{(char)34}{(char)125}]{(char)125}"
                });
            }



            modelBuilder.Entity<User>().HasData(new User()
            {
                UserId = new Guid("8A2FDD4A-E702-482C-F181-08D7015E3521"),
                Active = true,
                TenantId = "BaseTenant",
                Address = "",
                BirthDay = new DateTime(1900, 01, 01),
                CreatedBy = new Guid(),
                CreatedDate = new DateTime(2000, 1, 1),
                ContentType = "",
                CreatedByName = "admin",
                Email = "admin@admin.com",
                Gender = 'M',
                UserName = "admin",
                Password = MD5.Encrypt("Admin@123", "uJ0TLb5KVx5C2qzcCdKwsynac18KBQ06"),
                LastName = "admin",
                Phone = "8095555555",
                Name = "admin",
                LanguageCode = "ES",

                Mobile = "8095555555",


            });
            var languages = new Language[]{
                new Language()
            {
                Active = true,
                Id = 1,
                    TenantId="BaseTenant",
                Code = "EN",
                CreatedBy = new Guid(),
                CreatedByName = "admin",
                CreatedDate = new DateTime(2000,1,1),
                Name = "English",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}INGLES{(char)34}{(char)125}]," +
                    $"{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}ENGLISH{(char)34}{(char)125}]{(char)125}"
            } ,
             new Language()
            {
                Active = true,
                Id = 2,
                    TenantId="BaseTenant",
                Code = "ES",
                CreatedBy = new Guid(),
                CreatedByName = "admin",
                CreatedDate = new DateTime(2000,1,1),
                Name = "Spanish",
                    TranslationData = $"{(char)123}{(char)34}ES{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}ESPANOL{(char)34}{(char)125}]," +
                    $"{(char)34}EN{(char)34}:[{(char)123}{(char)34}PropertyName{(char)34}:{(char)34}Name{(char)34},{(char)34}Value{(char)34}:{(char)34}SPANISH{(char)34}{(char)125}]{(char)125}"
            }

            };
            modelBuilder.Entity<Language>().HasData(languages);
            modelBuilder.Entity<PaymentType>().HasData(paymentTypes);
            modelBuilder.Entity<SequenceControl>().HasData(sequenceControls);
            modelBuilder.Entity<MovementType>().HasData(movementTypes);
            modelBuilder.Entity<Section>().HasData(sections);
            modelBuilder.Entity<Operation>().HasData(operations);
            modelBuilder.Entity<Role>().HasData(roles);
            modelBuilder.Entity<RoleSectionOperation>().HasData(roleSectionOperations);

        }


    }
}
