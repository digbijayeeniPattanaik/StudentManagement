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
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            this._courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var addressCodes = await _courseService.Get();

            return Ok(addressCodes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdressCode(int id)
        {
            var item = await _courseService.GetById(id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                ////course.CourseId = new();



                return CreatedAtAction("GetCourse", new { course.Id }, course);
            }

            return new JsonResult("Somethign Went wrong") { StatusCode = 500 };
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var item = await _courseService.GetById(id);

            if (item == null)
                return BadRequest();

            return Ok(item);
        }
    }
}
