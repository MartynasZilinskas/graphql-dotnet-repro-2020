using System;
using System.IO;
using GraphQL.Utilities.Federation;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            var schemaPath = "schema.graphql";
            var schema = File.ReadAllText(schemaPath);

            var federatedSchema = FederatedSchema.For(schema, _ => { });
            var printer = new FederatedSchemaPrinter(federatedSchema);
            Console.WriteLine(printer.PrintFederatedSchema());
        }
    }
}
