using System.Text;

namespace JSONFormatter
{
    public static class JsonConverter
    {
        private static readonly StringBuilder builder = new();
        public static string ConvertJson(this Object obj)
        {
            builder.Append('{');

            if (obj != null)
            {
                foreach (var item in obj.GetType().GetProperties())
                {
                    builder.Append('"').Append(item.Name).Append('"').Append(": ");

                    if (item.PropertyType.IsPrimitive || item.PropertyType == typeof(string) || item.PropertyType == typeof(DateTime) || item.PropertyType == typeof(DateOnly))
                    {
                        if (item.PropertyType == typeof(string))
                        {
                            builder.Append('"').Append(item.GetValue(obj)).Append('"').Append(',');
                        }
                        else if (item.PropertyType == typeof(DateTime) || item.PropertyType == typeof(DateOnly))
                        {
                            builder.Append('"').Append(item.GetValue(obj)).Append('"').Append(',');
                        }
                        else
                        {
                            builder.Append(item.GetValue(obj)).Append(",");
                        }
                    }
                    else if (item.PropertyType.IsArray || (item.PropertyType.IsGenericType && item.PropertyType.GetGenericTypeDefinition() == typeof(List<>)))
                    {
                        builder.Append('[');

                        if (item.GetValue(obj) is IEnumerable<object> nestedItem)
                        {
                            foreach (var nested in nestedItem)
                            {
                                ConvertJson(nested);
                                builder.Append(',');
                            }
                            builder.Remove(builder.Length - 1, 1);
                        }

                        builder.Append(']');
                        builder.Append(',');
                    }
                    else
                    {
                        ConvertJson(item.GetValue(obj));
                        builder.Append(',');
                    }
                }
                builder.Remove(builder.Length - 1, 1);
            }

            builder.Append('}');

            return builder.ToString();
        }
    }
}
