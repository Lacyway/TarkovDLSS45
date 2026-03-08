using Mono.Cecil;
using System.Collections.Generic;
using System.Linq;

namespace TarkovDLSS45
{
    public static class TarkovDLSS45
    {
        public static IEnumerable<string> TargetDLLs { get; } = new[] { "Unity.Postprocessing.Runtime.dll" };

        public static void Patch(ref AssemblyDefinition assembly)
        {
            var module = assembly.MainModule;

            var enumType = module.Types.First(t => t.FullName == "EDLSSPreset");
            var fieldsToRemove = enumType.Fields
            .Where(f => f.Name != "value__" &&
                        f.Name != "J" &&
                        f.Name != "K")
            .ToArray();

            foreach (var field in fieldsToRemove)
            {
                enumType.Fields.Remove(field);
            }

            AddNewEnumField(enumType, "L", 12);
            AddNewEnumField(enumType, "M", 13);
        }

        private static void AddNewEnumField(TypeDefinition enumType, string name, int value)
        {
            const FieldAttributes fieldAttributes = FieldAttributes.Static | FieldAttributes.Literal
                | FieldAttributes.Public | FieldAttributes.HasDefault;

            var field = new FieldDefinition(name, fieldAttributes, enumType)
            {
                Constant = value
            };

            enumType.Fields.Add(field);
        }
    }
}
