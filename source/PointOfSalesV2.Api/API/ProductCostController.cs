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
    [ControllerAuthorize(Common.Enums.AppSections.Products)]
    [ApiController]
    public class ProductCostController : BaseController<ProductSupplierCost>
    {
        public ProductCostController(IOptions<AppSettings> appSettings, IDataRepositoryFactory repositoryFactory, IMemoryCache cache) : base(appSettings, repositoryFactory,cache, null, AppSections.Products)
        {
        }

        [HttpGet]
        [ActionAuthorize(new Operations[] { Operations.READALL, Operations.READ })]
        [EnableQuery()]
        [EnableCors("AllowAllOrigins")]
        public override async Task<IActionResult> Get()
        {
            try
            {
                var data = await _baseRepo.GetAllAsync<ProductSupplierCost>(x => x.Include(t => t.Supplier)
                .Include(t => t.Product)
                , y => y.Active == true);
                return Ok(data);
            }

            catch (Exception ex)
            {
               await SaveException(ex);
                return Ok(new { status = -1, message = ex.Message });
            }
        }

        [HttpPost]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.ADD)]
        public override async Task<IActionResult> Post([FromBody] ProductSupplierCost model)
        {
            return BadRequest(new { Status = -1, Message = "notValid_msg" });
        }


        [HttpPut]
        [EnableCors("AllowAllOrigins")]
        [ActionAuthorize(Operations.UPDATE)]
        public override async Task<IActionResult> Put([FromBody] ProductSupplierCost model)
        {
            return BadRequest(new { Status = -1, Message = "notValid_msg" });
        }
    }
}