using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSONHandeling
{
    internal class Program11
    {
        static void Main()
        {
            // Define the JSON schema for validation
            string schemaJson = @"
        {
            'type': 'object',
            'properties': {
                'name': { 'type': 'string' },
                'email': { 
                    'type': 'string',
                    'format': 'email'
                }
            },
            'required': ['name', 'email']
        }";

            // Parse the schema
            JSchema schema = JSchema.Parse(schemaJson);

            // Sample JSON data
            string jsonString = @"{ 'name': 'Alice', 'email': 'alice@example.com' }";

            // Parse JSON object
            JObject jsonObject = JObject.Parse(jsonString);

            // Validate the JSON object
            if (jsonObject.IsValid(schema, out IList<string> validationErrors))
            {
                Console.WriteLine("Valid JSON");
            }
            else
            {
                Console.WriteLine("Invalid JSON");
                foreach (var error in validationErrors)
                {
                    Console.WriteLine("Error: " + error);
                }
            }
        }
    }
}
