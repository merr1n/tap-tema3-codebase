namespace Lab4Web.Services.Lambda
{
    public class LambdaService : ILambdaService
    {

        public string NoParam()
        {
            var lambdaExp = new Func<string>(() => "Hello");
            return lambdaExp();
        }

        public int OneParam(int value)
        {
            var oneParam = new Func<int, int>((value) => value % 10);
            return oneParam(value);
        }

        public float TwoParam(float value1, float value2)
        {
            var twoParam = new Func<float, float, float>((value1, value2) => value1 + value2);
            return twoParam(value1, value2);
        }

        public float ThreeParam(float value1, float value2, float value3)
        {
            var threeParam = new Func<float, float, float, float>((value1,value2,value3) => value1 * value2 * value3);
            return threeParam(value1, value2, value3);
        }

        public string NoParam(int value1, int value2)
        {
            Func<int,int,string> noParam = (_,_) => { return "Sorry, no parameters ;b"; };
            return noParam(value1,value2);
        }

        public string DefaultParam(bool value)
        {
            Func<bool, string> defaultParam = (value) =>
            {
                if (value == false)
                    return $"Valoarea default: {value}";
                else
                    return $"Valoarea aleasa: {value}";
            };
            return defaultParam(value);
        }

        public Tuple<float,float,float> TupleParam(float value)
        {
            var tupleParam = (float value) => new Tuple<float, float, float>(value % 10, value / 10, value * 2);
            return tupleParam(value);
        }

        public async Task<string> Asynchronous(string value)
        {
            var asynchronous = async (string v) =>
            {
                await Delay();
                return value.ToUpper();
            };

            return await asynchronous(value);
        }

        public async Task Delay()
        {
            await Task.Delay(5000);
        }
    }
}
