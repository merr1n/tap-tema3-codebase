using Lab4Web.Services.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLinqController : ControllerBase
    {
        private readonly ILinqService _linqService;

        public TestLinqController(ILinqService linqService)
        {
            _linqService = linqService;
        }

        [HttpGet("Where")]
        public List<Student> Get(bool age)
        {
            return _linqService.getByEmployment(age);
        }

        [HttpGet("Names")]
        public List<string> Get()
        {
            return _linqService.getStudentNames();
        }

        [HttpGet("Counter")]
        public int GetCounter()
        {
            return _linqService.listCounter();
        }

        [HttpGet("Pct B")]
        public IEnumerable<object> GroupOldestStudentsByWeight()
        {
            var students = StudentList.GetStudents();
            var result = students.Where(s => s.Age > 21).Join(students.Where(c => c.Weight < 60 && c.Age == 20),
                student1 => student1.Id,
                student2 => student2.Id, (student1, student2) => new { Student1 = student1, Student2 = student2 });
            return result;
        }
    }
}
