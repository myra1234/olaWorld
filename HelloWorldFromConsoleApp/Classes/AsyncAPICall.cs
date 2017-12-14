using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace HelloWorldFromConsoleApp.Classes
{
    public class AsyncAPICall
    {
        public void GetDisplayData()
        {
           using(var serv = new WebClient())
            {
                serv.Headers.Add("Content-Type:applicaion/json");
                serv.Headers.Add("Accept:application/json");
                var res = serv.DownloadString("http://localhost:55035/api/HelloWorld/");
                Console.WriteLine(res);
            }
        }

        public void GetDisplaySelectiveData(string val)
        {
            using (var serv = new WebClient())
            {
                serv.Headers.Add("Content-Type:applicaion/json");
                serv.Headers.Add("Accept:application/json");
                var res = serv.DownloadString("http://localhost:55035/api/HelloWorld/" + val);
                Console.WriteLine(res);
            }
        }
    }
}
