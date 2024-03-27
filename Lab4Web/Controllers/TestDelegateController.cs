using Lab4Web.Services.Delegate;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDelegateController : ControllerBase
    {
        private readonly IDelegateService _delegateService;

        public TestDelegateController(IDelegateService delegateService)
        {
            _delegateService = delegateService;
        }

        [HttpGet("Pct A")]
        public string PctA(string firstName, string lastName)
        {
            var callback = _delegateService.Hello;

            return _delegateService.Introduction(firstName,lastName, callback);
        }

        [HttpGet("Pct B")]
        public string PctB(string firstName, string lastName, bool check=true)
        {
            Func<string, string,string> callback;

            if(check==true)
            {
                callback= _delegateService.Hello;
            }
            else
            {
                callback = _delegateService.Goodbye;
            }
            return _delegateService.Introduction(firstName, lastName, callback);
        }

        [HttpGet("Pct C")]
        public string PctC(string firstName, string lastName)
        {
            var callback1 = _delegateService.Hello;
            var callback2 = _delegateService.Goodbye;
            Func<string, string, string> callback3 = (firstName, lastName) =>
            {
                string res = callback1(firstName, lastName);
                res += "\n";
                res += callback2(firstName, lastName);
                return res;
            };
            return _delegateService.Introduction(firstName, lastName, callback3);
        }

        /*[HttpGet("test-2")]
        public string Test2(string name, bool welcome)
        {
            var callback1 = _delegateService.Hello;
            var callback2 = (string firstname, string lastname) => $"Bye, {firstname} {lastname}";

            var callback = welcome ? callback1 : callback2;

            return _delegateService.Introduction(name, callback);
        }*/
    }
}
