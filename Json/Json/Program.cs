using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
    [Serializable]//serializa
    class Training//class to be seialized
    {
        public int ID;
        public String Name;
        static void Main(string[] args)
        {
            Training obj = new Training();//intializing an object
            obj.ID = 1001;
            obj.Name = "Biz run time";

            IFormatter formatter = new BinaryFormatter();//creating a file stream and convert object to binary file
            Stream stream = new FileStream(@"G:\Example.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);//serialize object
            stream.Close();

            stream = new FileStream(@"G:\Example.txt", FileMode.Open, FileAccess.Read);//creating the file name 
            Training objnew = (Training)formatter.Deserialize(stream);//deserialize the object 

            Console.WriteLine(objnew.ID);//writing data to console
            Console.WriteLine(objnew.Name);

            Console.ReadKey();
        }
    }
}