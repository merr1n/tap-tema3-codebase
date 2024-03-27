using Lab4Web.Services.Lambda;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLambdaController : ControllerBase
    {
        private readonly ILambdaService _lambdaService;

        public TestLambdaController(ILambdaService lambdaService)
        {
            _lambdaService = lambdaService;
        }

        [HttpGet("Pct A - i")]
        public string Get()
        {
            return _lambdaService.NoParam();
        }

        [HttpGet("Pct A - ii")]
        public int Get(int value)
        {
            return _lambdaService.OneParam(value);
        }

        [HttpGet("Pct A - iii")]
        public float Get(float value1, float value2)
        {
            return _lambdaService.TwoParam(value1,value2);
        }

        [HttpGet("Pct A - iv")]
        public string Get(int value1, int value2)
        {
            return _lambdaService.NoParam(value1, value2);
        }

        [HttpGet("Pct A - v")]
        public string Get(bool value=false)
        {
            return _lambdaService.DefaultParam(value);
        }

        [HttpGet("Pct A - vi")]
        public string Get(float value)
        {
            var tupleVal = _lambdaService.TupleParam(value);
            return $"{tupleVal.Item1} / {tupleVal.Item2} / {tupleVal.Item3}";
        }

        [HttpGet("Pct B")]
        public string Achronimous(string value)
        {
            var result = _lambdaService.Asynchronous(value).Result;
            return result;
        }
        /*[HttpGet("test-1")]
        public string Get(int value)
        {
            var tupleValue = _lambdaService.Test1(value);
            return $"{tupleValue.Item1} / {tupleValue.Item2} / {tupleValue.Item3}";
        }

        [HttpGet("test-2")]
        public string Test2(string value)
        {
            return _lambdaService.Test2(value) ? "Number" : "Not number";
        }

        [HttpGet("test-3")]
        public string Test3(string value)
        {
            var result = _lambdaService.Test3Async(value).Result;
            return result;
        }*/
    }
}
