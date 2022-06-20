using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;


namespace VinImport.Temperature
{
    public class Udenfor_Temperature
    {
        public static double RealTimeTemp()
        {
            //variabler
            var client = new HttpClient();
            var api_key = "6e818e76332207b1216990927bad79d2";
            var city_name = "aalborg";

            // disse variabler bruges til at oprette forbindelse til openweather, og den bruges til at sende byens oplysninger til serveren
            var userURL = $"https://api.openweathermap.org/data/2.5/weather?q={city_name}&appid={api_key}&units=imperial";
            var weatherResponse = client.GetStringAsync(userURL).Result;
            var formattedResponseMain = JObject.Parse(weatherResponse).GetValue("main").ToString();
            string formattedResponseTemp = JObject.Parse(formattedResponseMain).GetValue("temp").ToString();

            //konvertering til både celcius of Fahrenheit.
            //Console.WriteLine($"\n{formattedResponseTemp} degrees Fahrenheit.");
            var fahrenheit = formattedResponseTemp;

            ///Jeg fik fejl ved behandling de modtagende dataer.
            ///Så jeg sletede al tal der kom efter ',' , og konvertere det til integeres.
            string propf = string.Empty;
            int index = fahrenheit.IndexOf(",");
            if (index >= 0)
            {
                propf = fahrenheit.Substring(0, index);
            }

            double iNewFf = Convert.ToInt32(propf);
            double celsius = (iNewFf - 32) * 5 / 9;

            return celsius;
        }

       


    }
}
