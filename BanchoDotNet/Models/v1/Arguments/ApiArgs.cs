using System.Linq;
using BanchoDotNet.Reflection;

namespace BanchoDotNet.Models.v1.Arguments
{
    public abstract class ApiArgs
    {
        public string ParseProperties()
        {
            string result = "";
            foreach (var property in this.GetType().GetProperties())
            {
                var attribute = property.GetCustomAttributes(typeof(ApiArgumentAttribute), false).First();
                if (attribute != null)
                {
                    var value = property.GetValue(this);
                    if (value != null)
                    {
                        result += ((ApiArgumentAttribute) attribute).Arg + "=" + (value is Enum.GameMode ? (int) value : value) + "&";
                    }
                }
            }
            return result.Remove(result.Length - 1, 1);
        }
    }
}