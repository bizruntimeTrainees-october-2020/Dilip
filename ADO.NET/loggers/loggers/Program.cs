using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basiclogger
{
    public abstract class LogBase
    {
        public abstract void log(string message);
    }
    public class Logger : LogBase
    {
        private String currentdirectory
        {
            get;
            set;
        }
        private string FileName
        {
            get;
            set;
        }
        private string Filepath
        {
            get;
            set;
        }
        public Logger()//constructor
        {
            this.currentdirectory = Directory.GetCurrentDirectory();
            this.FileName = "log.txt";
            this.Filepath = this.currentdirectory + "/" + this.FileName;
        }

        public override void log(string message)
        {
            Console.WriteLine("logged: {0}", message);
            using (System.IO.StreamWriter w = System.IO.File.AppendText(this.Filepath)) 
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine(" :{0}", message);
                w.WriteLine("-----------------------------------");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
            {

            var Logger = new Logger();
            Logger.log("dilip kumar");
        }
    }
}
