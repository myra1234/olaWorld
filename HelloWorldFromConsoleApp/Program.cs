using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldFromConsoleApp.Classes;

namespace HelloWorldFromConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncAPICall asyncAPICall = new AsyncAPICall();

            Console.WriteLine("Calling basic Hello World API...");
            asyncAPICall.GetDisplayData();
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Calling Hello World API which picks string based on the Id (param) provided...");
            Console.WriteLine("Please provide a number between 0 and 3 and hit ENTER");
            var val = Console.ReadLine();
            asyncAPICall.GetDisplaySelectiveData(val);
            Console.WriteLine("");

            Console.WriteLine("Press ESC to stop");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
            }
        }
    }
}
