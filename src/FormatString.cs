using System;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace CleanLambda
{
    public class FormatString
    {
        public string ToUpper(string input)
        {
            return input?.ToUpper();
        }
    }
}
