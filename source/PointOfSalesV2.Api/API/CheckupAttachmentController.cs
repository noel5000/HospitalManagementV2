using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ControllerAuthorize(Common.Enums.AppSections.PatientCheckup)]
    [ApiController]
    public class CheckupAttachmentController : BaseController<CheckupAttachment>
    {
        public CheckupAttachmentController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null, AppSections.PatientCheckup)
        {
        }

        [HttpGet]
        [ActionAuthorize(new Operations[] { Operations.READALL, Operations.READ })]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public override IActionResult Get()
        {
            try
            {
                var data = _baseRepo.GetAll<CheckupAttachment>(x => x.Include(t => t.FileAttachment)
                .Include(t => t.PatientCheckup)
                , y => y.Active == true);
                return Ok(data);
            }

            catch (Exception ex)
            {
                SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}