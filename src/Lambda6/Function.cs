using Amazon.Lambda.Core;

namespace Lambda6;
public class Function
{

    // Attribute to enable the Lambda function's JSON input to be converted into a .NET class.
    [LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(object input, ILambdaContext context)
    {
        context.Logger.LogLine(input.GetType().ToString());
        return "Hello from Lambda";
    }
}
