using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStudentManagementSystem.Configuration;
using OnlineStudentManagementSystem.DTO;
using OnlineStudentManagementSystem.Models;
using OnlineStudentManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStudentManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressCodesController : ControllerBase

    {
        private readonly IAddressCodeService _addressCodeService;

        public AdressCodesController(IAddressCodeService addressCodeService)
        {
            this._addressCodeService = addressCodeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string city, string state)
        {
            if (string.IsNullOrEmpty(city) && string.IsNullOrEmpty(state))
            {
                var addressCodes = await _addressCodeService.Get();
                return Ok(addressCodes);
            }
            else
            {
                var item = await _addressCodeService.GetAddressCodeByFilter(city, state);

                if (item == null)
                    return NotFound();

                return Ok(item);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdressCode(int id)
        {
            var item = await _addressCodeService.GetById(id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }


        [HttpPost]
        public async Task<IActionResult> CreateAddressCode(AddressCode addressCode)
        {
            if (ModelState.IsValid)
            {
                await _addressCodeService.CreateAddressCode(addressCode);
                return Ok(addressCode);
            }

            return new JsonResult("Somethign Went wrong") { StatusCode = 500 };
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddressCode(int id)
        {
            var item = await _addressCodeService.GetById(id);

            if (item == null)
                return BadRequest();

            await _addressCodeService.DeleteAddressCode(id);

            return Ok(item);
        }
    }
}
