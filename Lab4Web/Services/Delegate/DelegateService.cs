namespace Lab4Web.Services.Delegate
{
    public class DelegateService : IDelegateService
    {
        public string Introduction(string firstName, string lastName, Func<string, string, string> callback)
        {
            return callback(firstName.ToUpper(), lastName.ToUpper());
        }

        public string Hello(string firstname, string lastname)
        {
            return $"Hello, {firstname} {lastname}";
        }

        public string Goodbye(string firstname, string lastname)
        {
            return $"Goodbye, {firstname} {lastname}";
        }
    }
}
