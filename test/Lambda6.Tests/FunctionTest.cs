using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

namespace Lambda6.Tests;
public class FunctionTest
{
    [Fact]
    public void TestHelloLambdaFunction()
    {

        // Invoke the lambda function and confirm the string was Hello from Labda
        var function = new Function();
        var context = new TestLambdaContext();
        var actual = function.FunctionHandler("hello world", context);

        Assert.Equal("Hello from Lambda", actual);
    }
}
