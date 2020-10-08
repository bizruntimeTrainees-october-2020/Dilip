using System;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace fileInputOutput
{
    class FileRader
    {
        public static void CreatingFile()
        {
            string path = @"c:\temp\MyTestFile1.txt";//assigning file path to path
            if (!File.Exists(path))//if doesnt exists return null
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("hello ");
                    sw.Write("here ");
                    sw.Write("we come");
                }
            }
            using (StreamWriter sw = File.AppendText(path))//appending to a file  which is present 
            {
                sw.WriteLine("how are you");
                sw.Write("?");
                
            }
            using (StreamReader read = File.OpenText(path))
            {
                string str;
                while ((str = read.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine(read.GetType());
                
            }


        }
        public static void writingintoFile()
        {
            FileStream f = new FileStream(@"C:\temp\output.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine("hello c#");
            Console.WriteLine("File created successfully...");

            try
            {
                using (TextReader tr = File.OpenText(@"C:\temp\output.txt"))
                {
                    Console.WriteLine(tr.ReadToEnd());
                    s.Close();
                    f.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong: ");
            }

        }
        public static void DirectoryCreation()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Dilip Kumar\Documents");
            Console.WriteLine(directory.FullName);
            Console.WriteLine(directory.Attributes);
            Console.WriteLine(directory.Name);
            Console.WriteLine(directory.Parent);
            Console.WriteLine(directory.CreationTime);


            try
            {
                if(directory.Exists)
                {
                    Console.WriteLine("directory already exists");
                        return;

                }
                directory.Create();
                Console.WriteLine("directory already created");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created: {0}", e.ToString());
            }
            try
            {
                directory.Delete();
                Console.WriteLine("The directory is deleted successfully.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong: {0}", e.ToString());
            }
            
        }
        public static  void passingValues()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C: \Users\Dilip Kumar");
            string[] customers = {
            "bob",
            "amith",
            "vinay"};
            try
            {
                string textFilePath = @"C: \Users\Dilip Kumar\textfile1.txt";
                File.WriteAllLines(textFilePath, customers);
                foreach (string cust in File.ReadAllLines(textFilePath))
                {
                    Console.WriteLine(cust);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("some error in code");
            }

        }
              public static void Main(string[] args)
              {

                CreatingFile();
                writingintoFile();
                DirectoryCreation();
                passingValues();

              }
        
    }
}
