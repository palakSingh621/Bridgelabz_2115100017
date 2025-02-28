using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSONHandeling
{
    internal class Program5
    {
        static void Main()
        {
            // Define JSON schema
            string studentSchema = @"{
            'type': 'object',
            'properties': {
                'name': { 'type': 'string' },
                'age': { 'type': 'integer' }
            },
            'required': ['name', 'age']
        }";

            JSchema schema = JSchema.Parse(studentSchema);

            // Create a JSON object
            JObject student = JObject.Parse("{ 'name': 'John Doe', 'age': 21 }");

            // Validate JSON against schema
            bool isValid = student.IsValid(schema, out IList<string> errors);

            // Output result
            Console.WriteLine(isValid ? "Valid JSON" : "Invalid JSON: " + string.Join(", ", errors));
        }
    }
}
