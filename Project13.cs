using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace JSONHandeling
{
    internal class Project13
    {
        static void Main()
        {
            // Sample JSON string
            string json = @"{
            'name': 'Alice',
            'age': 25,
            'email': 'alice@example.com',
            'address': 
                {
                'city': 'New York',
                'zip': '10001'
                }
            }";

            // Convert JSON to XML
            JObject jsonObject = JObject.Parse(json);
            XDocument xmlDocument = JsonConvert.DeserializeXNode(jsonObject.ToString(), "Root");

            // Print XML output
            Console.WriteLine("Converted XML:\n" + xmlDocument);
        }
    }
}
