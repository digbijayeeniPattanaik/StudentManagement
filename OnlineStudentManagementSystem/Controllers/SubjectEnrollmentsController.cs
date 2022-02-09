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
    public class SubjectEnrollmentsController : ControllerBase
    {
        [Route("api/[controller]")]
        [ApiController]
        public class AdressCodesController : ControllerBase

        {
            private readonly ISubjectEnrollmentService _subjectEnrollmentService;

            public AdressCodesController(ISubjectEnrollmentService subjectEnrollmentService)
            {
                this._subjectEnrollmentService = subjectEnrollmentService;
            }

            [HttpGet]
            public async Task<IActionResult> Get()
            {
                var subjectEnrollments = await _subjectEnrollmentService.Get();

                return Ok(subjectEnrollments);
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetSubjectEnrollment(int id)
            {
                var item = await _subjectEnrollmentService.GetById(id);

                if (item == null)
                    return NotFound();

                return Ok(item);
            }

            [HttpPost]
            public IActionResult CreateSujectEnrollment(SubjectEnrollment subjectEnrollment)
            {
                if (ModelState.IsValid)
                {
                    subjectEnrollment.EnrollId = new();



                    return CreatedAtAction("GetSubjectEnrollment", new { subjectEnrollment.EnrollId }, subjectEnrollment);
                }

                return new JsonResult("Somethign Went wrong") { StatusCode = 500 };
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteSubjectEnrollment(int id)
            {
                var item = await _subjectEnrollmentService.GetById(id);

                if (item == null)
                    return BadRequest();

                return Ok(item);
            }
        }
    }
}
