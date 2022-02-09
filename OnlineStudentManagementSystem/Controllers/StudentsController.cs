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
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var students = await _studentService.Get();

            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var item = await _studentService.GetById(id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                student.StudentId = new();



                return CreatedAtAction("GetStudent", new { student.StudentId }, student);
            }

            return new JsonResult("Somethign Went wrong") { StatusCode = 500 };
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var item = await _studentService.GetById(id);

            if (item == null)
                return BadRequest();

            return Ok(item);
        }
    }
}

