using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectService _subjectService;

        public SubjectsController(ISubjectService subjectService)
        {
            this._subjectService = subjectService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var addressCodes = await _subjectService.Get();

            return Ok(addressCodes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdressCode(int id)
        {
            var item = await _subjectService.GetById(id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateSubject(Subject subject)
        {
            if (ModelState.IsValid)
            {
                subject.SubjectId = new();



                return CreatedAtAction("GetSubject", new { subject.SubjectId }, subject);
            }

            return new JsonResult("Somethign Went wrong") { StatusCode = 500 };
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubject(int id)
        {
            var item = await _subjectService.GetById(id);

            if (item == null)
                return BadRequest();

            return Ok(item);
        }
    }
}
