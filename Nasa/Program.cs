using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Nasa
{
    class Program
    {
        public static object JObject { get; private set; }

        static void Main(string[] args)
        {
            NasaImages.NasaIdentifier();
        }
    }
}
