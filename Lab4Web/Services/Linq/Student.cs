namespace Lab4Web.Services.Linq
{
    public class Student
    {
        public Student(int id, string name, int age, float weight, int height, bool employed)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            Employed = employed;
            Id = id;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public int Height { get; set; }
        public bool Employed { get; set; }
        public int Id { get; set; }
    }
}
