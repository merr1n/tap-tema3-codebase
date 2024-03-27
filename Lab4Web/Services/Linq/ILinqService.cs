namespace Lab4Web.Services.Linq
{
    public interface ILinqService
    {
        //int Test1(int value);
        List<Student> getByEmployment(bool employment);
        List<string> getStudentNames();
        int listCounter();
    }
}
