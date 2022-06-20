using System.Drawing;
using Console = Colorful.Console;

namespace VinImport.Temperature
{
    public class Temperature_Fugtighed
    {

        public static void LagerTemperatur()
        {
            DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();

            try
            {
                Console.Write($"{ds.StockTemp().ToString()} °C");

            }
            catch
            {
                Console.Write("N/a");
            }
        }

        public static void LagerFugt()
        {
            DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();

            try
            {

                Console.Write($"{ds.StockHumidity().ToString()} %");
            }
            catch
            {
                Console.Write("N/a");
            }

        }

        public static void UdenforTemperatur()
        {
            DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();

            try
            {
                Console.Write($"{ds.OutdoorTemp().ToString()} °C");

            }
            catch
            {
                Console.Write("N/a");
            }
        }

        public static void UdenforFugt()
        {
            DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();

            try
            {
                Console.Write($"{ds.OutdoorHumidity().ToString()} %");

            }
            catch
            {
                Console.Write("N/a");
            }

        }


        static void Space(int g)
        {
            for (int i = 0; i < g; i ++)
                {
                Console.Write(" ");
                }
            Console.WriteLine("|");
        }

        public static void TemperatureOgFugtighed()
        {
            Console.Write("Temperatur og Fugtighed", FontStyle.Bold, Color.LightBlue);Space(21);

            Console.Write("Lager:", Color.LightBlue); Space(22+16);
            Console.Write($"Temp: "); LagerTemperatur(); Space(21+12);
            Console.Write("Fugt: "); LagerFugt(); Space(21+13);
            Space(44);
            Console.Write("Udenfor:", Color.LightBlue); Space(21+15);
            Console.Write($"Temp: "); UdenforTemperatur(); Space(21+12);
            Console.Write("Fugt: "); UdenforFugt(); Space(21+13);
        }
    }
}
