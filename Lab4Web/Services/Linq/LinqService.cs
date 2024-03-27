namespace Lab4Web.Services.Linq
{

    public class LinqService : ILinqService
    {
        public List<Student> getByEmployment(bool employment)
        {
            var students = StudentList.GetStudents();
            var result = from student in students
                         where student.Employed == employment
                         select student;
            return result.ToList();
        }

        public List<string> getStudentNames()
        {
            var students = StudentList.GetStudents();
            var result = from student in students
                         select student.Name;
            return result.ToList();
        }

        public int listCounter()
        {
            var students = StudentList.GetStudents();
            return students.Count();
        }
    }
}
