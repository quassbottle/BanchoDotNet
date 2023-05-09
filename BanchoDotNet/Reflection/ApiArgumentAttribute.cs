using System;

namespace BanchoDotNet.Reflection
{
    public class ApiArgumentAttribute : Attribute
    {
        public string Arg { get; }

        public ApiArgumentAttribute(string arg)
        {
            Arg = arg;
        }
    }
}