namespace Lab4Web.Services.Lambda
{
    public interface ILambdaService
    {
        string NoParam();
        int OneParam(int value);
        float TwoParam(float value1, float value2);
        float ThreeParam(float value1, float value2, float value3);
        string NoParam(int value1, int value2);
        string DefaultParam(bool value);
        Tuple<float, float, float> TupleParam(float value);
        Task<string> Asynchronous(string value);
    }
}
