using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Mono.Net;

namespace TestServer
{
    public class Program
    {
        public static void Main(string[] args)
        {

            HttpListener httpListener = new HttpListener();

            httpListener.Prefixes.Add("http://localhost:8080/");
            
            httpListener.Start();

            while (true)
            {
                var context = httpListener.GetContext();

                using (var sw = new System.IO.StreamWriter(context.Response.OutputStream))
                {
                    sw.WriteLine("Hello World");
                }

                context.Response.Close();

            }

        }
    }
}
