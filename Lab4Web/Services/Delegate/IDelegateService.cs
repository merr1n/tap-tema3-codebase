namespace Lab4Web.Services.Delegate
{
    public interface IDelegateService
    {
        string Introduction(string firstName, string lastName, Func<string, string, string> callback);

        string Hello(string firstname, string lastname);

        string Goodbye(string firstname, string lastname);
    }
}
