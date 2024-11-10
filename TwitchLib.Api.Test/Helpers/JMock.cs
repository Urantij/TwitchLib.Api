using System;
using System.Linq.Expressions;
using System.Text.Json;
using Moq;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Test.Helpers
{
    public class JMock
    {
        public static string Of<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return JsonSerializer.Serialize(Mock.Of(predicate), new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles
            });
        }
    }
}