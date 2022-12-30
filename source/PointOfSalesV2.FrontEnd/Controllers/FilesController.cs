using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public FilesController(IWebHostEnvironment appEnviroment)
        {
            this.hostingEnvironment = appEnviroment;
        }
        [HttpPost]
        public IActionResult Post(IFormFile files)
        {
            List<string> result = new List<string>();
            try
            {
                var files2 = Request.Form.Files;
                long size = files2.Sum(f => f.Length);
                // full path to file in temp location
                var filePath = Path.Combine(hostingEnvironment.WebRootPath, "Files");

                foreach (var formFile in files2)
                {
                    if (formFile.Length > 0)
                    {
                        string finalFilePath = Path.Combine(filePath, $"{DateTime.Now.Ticks}-{formFile.FileName}");
                        using (var stream = new FileStream(finalFilePath, FileMode.Create))
                        {
                            formFile.CopyTo(stream);

                            result.Add($"/{finalFilePath.Split('\\').Last()}");

                        }
                       
                    }
                }


                // process uploaded files
                // Don't rely on or trust the FileName property without validation.

                return Ok(new { status = files2.Count, files = result, message = "OK" });
            }
            catch (Exception ex)
            {
                return Ok(new { status = -1, files = new List<string>(), message = ex.Message });
            }


        }
    }
}
