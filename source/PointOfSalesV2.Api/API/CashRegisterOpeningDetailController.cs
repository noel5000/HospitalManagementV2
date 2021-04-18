﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PointOfSalesV2.Api.Security;
using PointOfSalesV2.Entities; using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities.Model;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;
using Microsoft.AspNetCore.Cors;

namespace PointOfSalesV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorize(Common.Enums.AppSections.CashRegisterOpenings)]
    public class CashRegisterOpeningDetailController : BaseController<CashRegisterOpeningDetail>
    {
        public CashRegisterOpeningDetailController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache, null, AppSections.CashRegisterOpenings)
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
                var data = _baseRepo.GetAll<CashRegisterOpeningDetail>(x => x.Include(x => x.CashRegisterOpening)
                .Where(y => y.Active == true));
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