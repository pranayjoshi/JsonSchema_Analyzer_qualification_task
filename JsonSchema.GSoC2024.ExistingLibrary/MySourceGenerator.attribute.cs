using System.Reflection;

namespace JsonSchema.GSoC2024.ExistingLibrary;

internal sealed partial class MySourceGenerator
{
    private static readonly AssemblyName _assemblyName = typeof(MySourceGenerator).Assembly.GetName();
    private static readonly string _generatedCodeAttribute = $"""global::System.CodeDom.Compiler.GeneratedCodeAttribute("{_assemblyName.Name}", "{_assemblyName.Version}")""";


    private static readonly string _attributeSource = $$"""
        // <auto-generated/>
        #nullable enable

        namespace JsonSchema.GSoC2024.ExistingLibrary;

        [{{_generatedCodeAttribute}}]
        
        [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
        sealed class GeneratedAttribute : System.Attribute
        {
            public GeneratedAttribute(string jsonPath, string qualification)
            {
            }
        }

        """;
        
}