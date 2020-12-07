using Njson;
using System;
using System.Collections.Generic;
using System.IO;

namespace NJson
{
    class Program
    {
        static void Main(string[] args)
        {
            newjson NJ = new newjson();
            NJ.simpleJson();

           
        }
        
        class newjson
        {
            public void simpleJson()
            {                                                     // Using PARSE

                JObject o = JObject.Parse(@"{                   
                'CPU': 'Intel',
                'Drives': [
                    'DVD read/writer',
                    '500 gigabyte hard drive'
                     ]
                }");
            }
            string cpu = (string)o["CPU"];
            // Intel
            string firstDrive = (string)o["Drives"][0];
            // DVD read/writer
            IList<string> allDrives = o["Drives"].Select(t => (string)t).ToList();
            
            
           
        }
    }
}


//// PARSE JSON:-----
///
//string json = @"[
//  'Small',
//  'Medium',
//  'Large'
//]";

//JArray a = JArray.Parse(json);

//Console.WriteLine(a.ToString());
//// [
////   "Small",
////   "Medium",
////   "Large"
//// ]



//// Querying JSON:----

//string json = @"{
//  'channel': {
//    'title': 'James Newton-King',
//    'link': 'http://james.newtonking.com',
//    'description': 'James Newton-King\'s blog.',
//    'item': [
//      {
//        'title': 'Json.NET 1.3 + New license + Now on CodePlex',
//        'description': 'Announcing the release of Json.NET 1.3, the MIT license and the source on CodePlex',
//        'link': 'http://james.newtonking.com/projects/json-net.aspx',
//        'category': [
//          'Json.NET',
//          'CodePlex'
//        ]
//      },
//      {
//        'title': 'LINQ to JSON beta',
//        'description': 'Announcing LINQ to JSON',
//        'link': 'http://james.newtonking.com/projects/json-net.aspx',
//        'category': [
//          'Json.NET',
//          'LINQ'
//        ]
//      }
//    ]
//  }
//}";

//JObject rss = JObject.Parse(json);

//string rssTitle = (string)rss["channel"]["title"];

//Console.WriteLine(rssTitle);
//// James Newton-King

//string itemTitle = (string)rss["channel"]["item"][0]["title"];

//Console.WriteLine(itemTitle);
//// Json.NET 1.3 + New license + Now on CodePlex

//JArray categories = (JArray)rss["channel"]["item"][0]["category"];

//Console.WriteLine(categories);
//// [
////   "Json.NET",
////   "CodePlex"
//// ]

//string[] categoriesText = categories.Select(c => (string)c).ToArray();

//Console.WriteLine(string.Join(", ", categoriesText));
//// Json.NET, CodePlex




//// convert XML to JSON with serializeXmlNode.

//string xml = @"<?xml version='1.0' standalone='no'?>
//<root>
//  <person id='1'>                                  //XML format
//    <name>Alan</name>
//    <url>http://www.google.com</url>
//  </person>
//  <person id='2'>
//    <name>Louis</name>
//    <url>http://www.yahoo.com</url>
//  </person>
//</root>";

//XmlDocument doc = new XmlDocument();                      // to calling the xml document.
//doc.LoadXml(xml);

//string jsonText = JsonConvert.SerializeXmlNode(doc);
////{
////  "?xml": {                                             //JSON format
////    "@version": "1.0",
////    "@standalone": "no"
////  },
////  "root": {
////    "person": [
////      {
////        "@id": "1",
////        "name": "Alan",
////        "url": "http://www.google.com"
////      },
////      {
////        "@id": "2",
////        "name": "Louis",
////        "url": "http://www.yahoo.com"
////      }
////    ]
////  }
////}
///




//// To convert JSON to XML format using -DeserializerXmlNode-
//string json = @"{                                             //json
//  '?xml': {
//    '@version': '1.0',
//    '@standalone': 'no'
//  },
//  'root': {
//    'person': [
//      {
//        '@id': '1',
//        'name': 'Alan',
//        'url': 'http://www.google.com'
//      },
//      {
//        '@id': '2',
//        'name': 'Louis',
//        'url': 'http://www.yahoo.com'
//      }
//    ]
//  }
//}";

//XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(json);
//// <?xml version="1.0" standalone="no"?>                              //xml   
//// <root>
////   <person id="1">
////     <name>Alan</name>
////     <url>http://www.google.com</url>
////   </person>
////   <person id="2">
////     <name>Louis</name>
////     <url>http://www.yahoo.com</url>
////   </person>
//// </root>





//            string jsonText = @"{
//            'short': {
//                'original': 'http://www.foo.com/',
//                'short': 'krehqk',
//                'error': {
//                'code': 0,
//                'msg': 'No action taken'
//                }
//                }
//            }";


//            JObject json = JObject.Parse(jsonText);

//            Shortie shortie = new Shortie
//            {
//                Original = (string)json["short"]["original"],
//                Short = (string)json["short"]["short"],
//                Error = new ShortieException
//                {
//                    Code = (int)json["short"]["error"]["code"],
//                    ErrorMessage = (string)json["short"]["error"]["msg"]
//                }
//            };

//            Console.WriteLine(shortie.Original);
//            // http://www.foo.com/

//            Console.WriteLine(shortie.Error.ErrorMessage);
//            // No action taken
//        }
//    }
//}




//namespace NJson
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            SerializationEventTestObject SD = new SerializationEventTestObject();
//            SD.SerializationEventTestObject(Member1);



//        }
//        public class SerializationEventTestObject
//        {
//            public int Member1 { get; set; }

//            public string Member2 { get; set; }

//            public string Member3 { get; set; }

//            public string Member4 { get; set; }


//            public SerializationEventTestObject()
//            {
//                Member1 = 11;
//                Member2 = "Hello World!";
//                Member3 = "This is a nonserialized value";
//                Member4 = null;

//            }
//            [OnSerializing]
//            internal void OnSerializingMethod(StreamingContext context)
//            {
//                Member2 = "This value went into the data file during serialization.";
//            }
//            [OnSerialized]
//            internal void OnSerializedMethod(StreamingContext context)
//            {
//                Member2 = "This value was reset after serialization.";
//            }

//            [OnDeserializing]
//            internal void OnDeserializingMethod(StreamingContext context)
//            {
//                Member3 = "This value was set during deserialization";
//            }

//            [OnDeserialized]
//            internal void OnDeserializedMethod(StreamingContext context)
//            {
//                Member4 = "This value was set after deserialization.";
//            }


//        }
//    }
//}

// serialization callback methods. 
//    A callback can be used to manipulate an object before and after its serialization and deserialization 
//    by the JsonSerializer.

//      -OnSerializing
//      -OnSerialized
//      -OnDeserializing
//      -OnDeserialized        


