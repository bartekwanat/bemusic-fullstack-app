using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bemusic.Models;
using bemusic.Services;
using Microsoft.AspNetCore.Mvc;

namespace bemusic.Controllers
{
    [Route("api/supplier")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpPost]
        public ActionResult AddSupplier([FromBody] CreateSupplierDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var supplier = _supplierService.AddSupplier(dto);
            return Ok(supplier);
        }
    }
}
