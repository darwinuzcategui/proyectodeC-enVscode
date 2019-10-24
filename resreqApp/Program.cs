using System;
using System.Net;
using Newtonsoft.Json;

namespace resreqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string API_URL = "https://jsonplaceholder.typicode.com/posts?_limit=6";
            var cliente = new WebClient();
            var json = cliente.DownloadString(API_URL);
            //Console.WriteLine(json);
            dynamic postUsuarios = JsonConvert.DeserializeObject(json);
            foreach (var publicacion in postUsuarios)
            {
                Console.WriteLine(publicacion.id+": "+publicacion.title);
                
            }
        }
    }
}
