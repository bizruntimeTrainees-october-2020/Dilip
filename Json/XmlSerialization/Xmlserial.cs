using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Xml;

namespace XmlSerialization
{
    [Serializable]
     public class Person//setting properties for class
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
   
    class Xmlserial
    {
        static void Main(string[] args)
        {
            Person person = new Person() { FirstName = "jonny", LastName = "walter" };//taking value from properties of class
            string filepath = @"G:\Examplexml.txt";
            Dataserializer serializer = new Dataserializer();//instance is created for dataserialzer class
            Person p = null;
            serializer.XmlSerialize(typeof(Person), person, filepath);
            p = serializer.XmlDeserializer(typeof(Person), filepath) as Person;
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);


        }
    }
        class Dataserializer
        {
            public void XmlSerialize(Type dataType, object data, string filepath)
            {
                XmlSerializer xmlserializer = new XmlSerializer(dataType);//type of data is person
                if (File.Exists(filepath)) File.Delete(filepath);//if file  is present in the path  then file will be deleted 
                TextWriter writer = new StreamWriter(filepath);// to write into a file
                xmlserializer.Serialize(writer, data);//here filepath and data will be given 
                writer.Close();
            }

            public object XmlDeserializer(Type dataType, string filepath)
            {
                object obj = null;
                XmlSerializer xmlserializer = new XmlSerializer(dataType);
                if (File.Exists(filepath))
                {
                    TextReader reader = new StreamReader(filepath);
                    obj = xmlserializer.Deserialize(reader);
                    reader.Close();

                }
                return obj;
            }

        }
    }

