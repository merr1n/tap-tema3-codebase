namespace Lab4Web.Services.Linq
{
    public class StudentList
    {
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student(1,"Dan",20,100,178,false),
                new Student(1,"Mihai",21,60,175,false),
                new Student(1,"Vlad",21,80,180,false),
                new Student(1,"Ion",21,75,178,true),
                new Student(1,"Stefan",20,55,170,true),
                new Student(1,"Denis",22,90,178,true),
                new Student(1,"Radu",19,95,180,true),
                new Student(1,"Andrei",21,100,178,false),
                new Student(1,"Constantin",25,53,170,false),
                new Student(1,"Darius",21,60,173,true),
            };
            return students;
        }
    }
}
