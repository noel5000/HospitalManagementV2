using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Common;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSalesV2.FrontEnd.Controllers
{
    public class FilesController : Controller
    {
        IWebHostEnvironment hostingEnvironment;
        IOptions<AppSettings> _options;
        IDataRepositoryFactory dataRepository;
        IBase<FileAttachment> filesRepo;
        protected readonly IBase<ExceptionLog> exceptionsRepo;
        IBase<CheckupAttachment> checkupAttachmentRepo;

        public FilesController(IWebHostEnvironment appEnviroment, IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory)
        {
            this.hostingEnvironment = appEnviroment;
            this._options = appSettings;
            this.dataRepository = repositoryFactory;
            this.filesRepo = repositoryFactory.GetDataRepositories<FileAttachment>();
            this.checkupAttachmentRepo = repositoryFactory.GetDataRepositories<CheckupAttachment>();
            this.exceptionsRepo = repositoryFactory.GetDataRepositories<ExceptionLog>();
        }
       
        [HttpPost("Files/SaveCheckupFile/{id:long}")]
        public async  Task<IActionResult> SaveCheckupFile(IFormFile files, long id)
        {
            List<Result<CheckupAttachment>> result = new List<Result<CheckupAttachment>>();
            try
            { var fileRepo = dataRepository.GetDataRepositories<FileAttachment>();
                var files2 = Request.Form.Files;
                long size = files2.Sum(f => f.Length);
                // full path to file in temp location
                var filePath = Path.Combine(hostingEnvironment.WebRootPath, "Files");

                foreach (var formFile in files2)
                {
                    if (formFile.Length > 0)
                    {
                        string name = $"{DateTime.Now.Ticks}-{formFile.FileName}";
                        string finalFilePath = Path.Combine(filePath, name);
                        using (var stream = new FileStream(finalFilePath, FileMode.Create))
                        {
                            formFile.CopyTo(stream);
                         var savedResult=   await filesRepo.AddAsync(new FileAttachment() { 
                            Active=true,
                            FilePath=finalFilePath,
                            FileName= name
                         });

                            if (savedResult.Status >= 0) 
                            {
                                var checkupAttcahmentResult = await checkupAttachmentRepo.AddAsync(new CheckupAttachment() { 
                                Active=true,
                                FileAttachementId=savedResult.Id,
                                PatientChekupId=id,
                                
                                });
                                result.AddAsync(checkupAttcahmentResult);
                            }
                           

                        }
                       
                    }
                }


                // process uploaded files
                // Don't rely on or trust the FileName property without validation.

                return Ok(new { status = files2.Count, files = result, message = "OK" });
            }
            catch (Exception ex)
            {
                this.exceptionsRepo.AddAsync(new ExceptionLog()
                {
                    Code = ex.HResult.ToString(),
                    Active = true,
                    Message = ex.Message.Length > 500 ? ex.Message.Substring(0, 499) : ex.Message,
                    Section = (int)Enums.AppSections.PatientCheckup,
                    SectionName = Enums.AppSections.PatientCheckup.ToString()
                });
                return Ok(new { status = -1, files = new List<string>(), message = ex.Message });
            }


        }


    }
}
