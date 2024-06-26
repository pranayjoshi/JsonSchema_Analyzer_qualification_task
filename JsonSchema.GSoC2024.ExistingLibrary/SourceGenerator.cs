using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Corvus.Json.SchemaGenerator
{
    [Generator]
    public class JsonSchemaGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            // Set up code generation pipeline
            var syntaxProvider = context.SyntaxProvider;

            context.RegisterSourceOutput(
    context.SyntaxProvider.CreateSyntaxProvider(
        static (syntaxNode, _) => syntaxNode is ClassDeclarationSyntax,
        static (context, cancellationToken) => (ISymbol)context.SemanticModel.GetDeclaredSymbol(context.Node, cancellationToken)
    ),
    (spc, source) =>
    {
        string sourceCode = GenerateSourceCode();
        spc.AddSource("GeneratedSource.cs", SourceText.From(sourceCode, Encoding.UTF8));
    }
);
        }

        private static string GenerateSourceCode()
        {
            return @"
                   using System;

                   namespace GeneratedNamespace
                   {
                       sealed class GeneratedAttribute : Attribute
                       {
                           public string JsonPath { get; }
                           public string Qualification { get; }

                           public GeneratedAttribute(string jsonPath, string qualification)
                           {
                               JsonPath = jsonPath;
                               Qualification = qualification;
                           }

                           public void PrintDetails()
                           {
                               Console.WriteLine($""JSON Path: {JsonPath}"");
                               Console.WriteLine($""Qualification: {Qualification}"");
                           }
                       }
                       public class GeneratedClass
                       {
                           public void PrintMessage()
                           {
                               Console.WriteLine(""This is a generated class!"");
                           }
                       }
                   }";
        }
    }
}