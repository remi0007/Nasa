using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Nasa
{
    public class NasaImages
    {
        public static void NasaIdentifier()

        {
            var client = new HttpClient();

            var NasaURL = "https://api.nasa.gov/EPIC/api/natural?api_key=DEMO_KEY";

            var NasaResponse = client.GetStringAsync(NasaURL).Result;

            //re

            //var NasaIdentifier = JObject.Parse(NasaResponse).GetValue("identifier").ToString();

            var imageList = new List<Class1>();

            var objs = JArray.Parse(NasaResponse);

            foreach(var obj in objs)
            {
                var nasaImage = new Class1();
                nasaImage.identifier = (string) obj["identifier"];
                nasaImage.caption = (string)obj["caption"];
                nasaImage.image = (string)obj["image"];

                imageList.Add(nasaImage);
            }


            Console.WriteLine($"");

        }


    }
}
