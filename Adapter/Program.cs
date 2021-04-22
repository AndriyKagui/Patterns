using System;
using System.Net.Http;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Adapter();
            r.Send("Hello");
        }
    }

    class Requester
    {
        public void SendRequest(string message)
        {
            var client = new HttpClient();
            var result = client.GetAsync("https://www.google.com/search?q=" + message).Result;
            Console.WriteLine(result);
        }
    }

    interface ISender
    {
        public void Send(string message);
    }

    class Adapter : Requester, ISender
    {
        public void Send(string message)
        {
            this.SendRequest(message);
        }
    }
}
