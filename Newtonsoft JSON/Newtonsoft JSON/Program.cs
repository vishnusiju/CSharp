using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;



namespace Serializer
{
    public class DataStructure
    {
        public string Name { get; set; }
        public List<int> Identifiers { get; set; }

        public void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Identifiers: " + string.Join<int>(",", Identifiers));
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class Program
    {
        const string filePath = @"E:\BIZRUNTIME\json\json.txt";

        public static void Serialize(object obj)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(filePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public static object Deserialize(string path)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamReader(path))
            using (var reader = new JsonTextReader(sw))
            {
                return serializer.Deserialize(reader);
            }
        }
        
        static void Main(string[] args)
        {
            var data = new DataStructure
            {
                Name = "Vishnu",
                Identifiers = new List<int> { 1, 2, 3, 4 }

            };

            Console.WriteLine("Object before serialization:");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            data.Print();

            Serialize(data);

            var deserialized = Deserialize(filePath);

            Console.WriteLine("Deserialized (json) string:");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine(deserialized);
            Console.WriteLine();

        }

    }
}


//JsonObjectAttribute
//JsonArrayAttribute / JsonDictionaryAttribute
//JsonPropertyAttribute
//JsonIgnoreAttribute
//JsonConverterAttribute
//JsonExtensionDataAttribute
//JsonConstructorAttribute

//JavaScript Object Notation (JSON):- is a standard text - based format for representing structured data based on 
//    JavaScript object syntax.It is commonly used for transmitting data in web applications(e.g., sending some
//        data from the server to the client, so it can be displayed on a web page, or vice versa).

//JSON.parse()
//   A common use of JSON is to exchange data to/from a web server. When receiving data from a web server,
//    the data is always a string. Parse the data with JSON.parse() , and the data becomes a JavaScript object.

//the main use of JSON schema is to describe the structure and validation constraints of your JSON documents. ... 
//    JSON is meant to describe hierarchical data structures in a concise way, a task in which XML is generally 
//     considered to be less appropriate than JSON due to the verbose syntax.




















