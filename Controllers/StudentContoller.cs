
using EfcorePractice.Models;
using EfcorePractice.Services;
using Microsoft.AspNetCore.Mvc;

namespace EfcorePractice.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class StudentContoller : ControllerBase
    {
        private readonly StudentServices _services;
        public StudentContoller(StudentServices services)
        {
            _services = services;
        }
    
    [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_services.GetStudents());
        }
        [HttpPost]
        public IActionResult AddStudent(Students student)
        {
            _services.AddStudent(student);
            return Ok("Student Added Successfully");
        }
        [HttpPut]
        public IActionResult updt([FromBody]Students updatedstudents)
        {
            _services.updateStudent(updatedstudents);
            return Ok("updated successfully");

        }
        [HttpDelete("{id}")]
        public IActionResult deletestudents(int id)
        {
            _services.deletestud(id);
            return Ok("student deleted successfully");
        }
    }
}
