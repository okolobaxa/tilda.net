using Newtonsoft.Json.Converters;
using System;
using Newtonsoft.Json;

namespace tilda.net.Converters
{
    public class UnixDateTimeConverter : DateTimeConverterBase
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.String)
            { 
                throw new Exception(
                    string.Format("Unexpected token parsing date. Expected Integer or String, got {0}.",
                    reader.TokenType));
            }

            var input = reader.Value.ToString();
            if (string.IsNullOrEmpty(input))
                return null;

            var ticks = long.Parse(input);

            var date = new DateTime(1970, 1, 1);
            date = date.AddSeconds(ticks);

            return date;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
