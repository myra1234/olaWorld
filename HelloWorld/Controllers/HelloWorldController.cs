using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class HelloWorldController : ApiController
    {

        List<MyClass> MyClassObj = new List<MyClass>()
        {
            new MyClass(){DisplayString = "HelloWorld 1"},
            new MyClass(){DisplayString = "HelloWorld 2"},
            new MyClass(){DisplayString = "HelloWorld 3"},
            new MyClass(){DisplayString = "HelloWorld 4"}
        };

        public string Get()
        {
            return "Hello World";
        }
        public string Get(string id)
        {
            int idx;
            bool res = int.TryParse(id, out idx);

            if (res)
            {
                if (idx < MyClassObj.Count)
                    return MyClassObj[idx].DisplayString;
            }

            return "Sorry, no hello for you!";
        }
    }
}
