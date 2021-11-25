﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.OData.Query;
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
    [ControllerAuthorize(Common.Enums.AppSections.Warehouses)]
    public class WarehouseController : BaseController<Warehouse>
    {
        public WarehouseController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache,null,AppSections.Warehouses)
        {
        }


        [HttpGet]
        [ActionAuthorize(Operations.READALL)]
        [EnableQuery]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting]
        [EnableCors("AllowAllOrigins")]
        public override async Task<IActionResult> Get()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<Warehouse>(x => x.AsNoTracking().Include(y=>y.BranchOffice),y=>y.Active==true);
                return Ok(data);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }
    }
}