using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLog4net
{
    class Program
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger("ErrorLogger");

        static void Main(string[] args)
        {

            // 可以在AssemblyInfo.ca裡加上 
            // [assembly: log4net.Config.XmlConfigurator(Watch = true)]
            // 或是在程式初始像是  App.xaml.cs
            log4net.Config.XmlConfigurator.Configure();

            log4net.ILog log = log4net.LogManager.GetLogger("ErrorLogger");

            log.Error("This is an error test");


        }
    }
}
