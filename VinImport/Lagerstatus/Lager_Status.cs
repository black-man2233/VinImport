using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Console = Colorful.Console;
using System.Drawing;
using VinImport.Temperature;
using VinImport.Tider;
using VinImport.Lagerstatus;
using ConsoleTables;


namespace VinImport.Lagerstatus
{
    public class Lager_Status
    {
        public static void UnderMinimum()
        {
            DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();
            Console.WriteLine("Varer under minimum: " +
                "\n------------------------------------------------", Color.LightBlue);

            try
            {
                foreach (string line in ds.StockItemsUnderMin())
                {
                    Console.WriteLine(line,Color.Red);
                }

            }
            catch
            {
                Console.Write("N/a");
            }

        }

        public static void OverMaksimum()
        {
            DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();
            Console.WriteLine("\n Varer over maksimum: " +
                "\n------------------------------------------------",Color.LightBlue);

            try
            {
                foreach (string line in ds.StockItemsOverMax())
                {
                    Console.WriteLine(line,Color.LightGreen);

                }

            }
            catch
            {
                Console.Write("N/a");
            }
        }

        public static void MestSolgt()
        {
            DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();

            Console.WriteLine("\n Mest solgte i dag: " +
                "\n------------------------------------------------", Color.LightBlue);

            try
            {
                foreach (string line in ds.StockItemsMostSold())
                {
                    Console.WriteLine(line);


                }

            }
            catch
            {
                Console.Write("N/a");
            }
        }

        public static void AltPaaLager()
        {
            UnderMinimum();
            OverMaksimum();
            MestSolgt();
        }        

    }

}
