using System;
using System.Linq;
using System.Reflection;

namespace TestAutomation
{
    public static class Reflector
    {
        /// <summary> Gets the types in the assembly (properties, fields, methods) </summary>
        public static string GetTypeDetails(string assemblyPath, bool excludeBaseTypeProperties = true)
        {
            if (!System.IO.File.Exists(assemblyPath)) return string.Empty;

            var assembly = Assembly.LoadFrom(assemblyPath);
            var types = assembly.GetTypes();
            string ret = string.Empty;
            foreach (var type in types) ret += GetTypeDetails(type, excludeBaseTypeProperties);

            return ret;
        }

        private static string GetTypeDetails(Type type, bool excludeBaseTypeProperties = true)
        {
            var ret = string.Format("{0} ({1})\r\n", type.Name, type.BaseType.Name);

            var properties = GetProperties(type, excludeBaseTypeProperties);
            ret += string.Format("    {0} Properties ({1})\r\n    --------------------\r\n", type.Name, properties.Length);
            foreach (var prop in properties) ret += string.Format("    {0} ({1})\r\n", prop.Name, prop.PropertyType.Name);
            ret += Environment.NewLine;

            var fields = GetFields(type, excludeBaseTypeProperties);
            ret += string.Format("    {0} Fields ({1})\r\n    --------------------\r\n", type.Name, fields.Length);
            foreach (var field in fields) ret += string.Format("    {0} ({1})\r\n", field.Name, field.FieldType.Name);
            ret += Environment.NewLine;

            var methods = GetMethods(type, excludeBaseTypeProperties);
            ret += string.Format("    {0} Methods ({1})\r\n    --------------------\r\n", type.Name, methods.Length);
            foreach (var method in methods) ret += string.Format("    {0} ({1})\r\n", method.Name, method.ReturnType.Name);
            ret += Environment.NewLine;

            return ret;
        }

        private static PropertyInfo[] GetProperties(Type type, bool excludeBaseTypeProperties = true)
        {
            if (excludeBaseTypeProperties && type.BaseType != null)
            {
                return type.GetProperties(Flags).Where(prop => type.BaseType.GetProperties(Flags).All(x => x.Name != prop.Name)).ToArray();
            }

            return type.GetProperties(Flags);
        }

        private static FieldInfo[] GetFields(Type type, bool excludeBaseTypeProperties = true)
        {
            if (excludeBaseTypeProperties && type.BaseType != null)
            {
                return type.GetFields(Flags).Where(field => type.BaseType.GetFields(Flags).All(x => x.Name != field.Name)).ToArray();
            }

            return type.GetFields(Flags);
        }

        private static MethodInfo[] GetMethods(Type type, bool excludeBaseTypeProperties = true)
        {
            if (excludeBaseTypeProperties && type.BaseType != null)
            {
                return type.GetMethods(Flags).Where(method => type.BaseType.GetMethods(Flags).All(x => x.Name != method.Name)).ToArray();
            }

            return type.GetMethods(Flags);
        }

        public static BindingFlags Flags = BindingFlags.Public |
                                        BindingFlags.NonPublic |
                                           BindingFlags.Static |
                                        BindingFlags.Instance;
    }
}
