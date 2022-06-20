using System;
using System.Drawing;
using Console = Colorful.Console;
using ConsoleTables;
using static System.Console;


namespace Wine_Import
{
    public  class AllShitsInOne
    {
        public static void Run()
        {
            
            //Tidszoner
            DateTime dkTid = DateTime.Now;
            var kobenhavnTid = dkTid.ToString("dd-MM-yyyy - HH:mm-ss");
            var singaporeTid = dkTid.AddHours(9).ToString("dd-MM-yyyy - HH:mm-ss");
            var londonTid = dkTid.AddHours(-1).ToString("dd-MM-yyyy - HH:mm-ss");

            string singapore = "Singapore";
            string koebenhavn = "København";
            string london = "London";


            //dage
            string days = DateTime.Now.DayOfWeek.ToString();
            string dayOfTheWeek = days.ToLower();


            void DatoOGTid(string a)

            { 
                

                if (a == "København")
                {
                    Console.WriteLine("København:", Color.LightBlue);
                    switch (dayOfTheWeek)
                    {
                        case "monday":
                            Console.WriteLine($"MANDAG {kobenhavnTid}");
                            break;

                        case "tuesday":
                            Console.WriteLine($"TIRSDAG {kobenhavnTid}");
                            break;

                        case "wednesday":
                            Console.WriteLine($"ONSDAG {kobenhavnTid}");
                            break;

                        case "thursday":
                            Console.WriteLine($"TORSDAG {kobenhavnTid}");
                            break;

                        case "friday":
                            Console.WriteLine($"FREDAG {kobenhavnTid}");
                            break;

                        case "saturday":
                            Console.WriteLine($"LØRDAG {kobenhavnTid}");
                            break;

                        case "sunday":
                            Console.WriteLine($"SØNDAG {kobenhavnTid}");
                            break;

                    }
                }
                if (a == "Singapore")
                {
                    Console.WriteLine("Singapore:", Color.LightBlue);
                    switch (dayOfTheWeek)
                    {
                        case "monday":
                            Console.WriteLine($"MANDAG {singaporeTid}");
                            break;

                        case "tuesday":
                            Console.WriteLine($"TIRSDAG {singaporeTid}");
                            break;

                        case "wednesday":
                            Console.WriteLine($"ONSDAG {singaporeTid}");
                            break;

                        case "thursday":
                            Console.WriteLine($"TORSDAG {singaporeTid}");
                            break;

                        case "friday":
                            Console.WriteLine($"FREDAG {singaporeTid}");
                            break;

                        case "saturday":
                            Console.WriteLine($"LØRDAG {singaporeTid}");
                            break;

                        case "sunday":
                            Console.WriteLine($"SØNDAG {singaporeTid}");
                            break;

                    }

                }
                if (a == "London")
                {
                    Console.WriteLine("London:", Color.LightBlue);
                    switch (dayOfTheWeek)
                    {
                        case "monday":
                            Console.WriteLine($"MANDAG {londonTid}");
                            break;

                        case "tuesday":
                            Console.WriteLine($"TIRSDAG {londonTid}");
                            break;

                        case "wednesday":
                            Console.WriteLine($"ONSDAG {londonTid}");
                            break;

                        case "thursday":
                            Console.WriteLine($"TORSDAG {londonTid}");
                            break;

                        case "friday":
                            Console.WriteLine($"FREDAG {londonTid}");
                            break;

                        case "saturday":
                            Console.WriteLine($"LØRDAG {londonTid}");
                            break;

                        case "sunday":
                            Console.WriteLine($"SØNDAG {londonTid}");
                            break;

                    }

                }
                    
            }

            ////
            ///Lager Temperatur
           
            DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();

            var LagerTemperature = ds.StockTemp().ToString();
            var LagerFugt  = ds.StockHumidity().ToString();
            var UdenforTemperature = ds.OutdoorTemp().ToString();
            var UdenforFugt = ds.OutdoorHumidity().ToString();

            




            //Udskrivining

            WriteLine("Temperature og Fugtighed");
            WriteLine("Lager:", Color.LightBlue);
            WriteLine($"Temp: {LagerTemperature} °C \nFugt: {LagerFugt} % \n");

            WriteLine("Udenfor:",Color.LightBlue);
            WriteLine($"Temp: {UdenforTemperature} °C \nFugt: {UdenforFugt} % \n");

            Console.WriteLine("--------------------------------------------|                                    \n");
            string by;
            by = koebenhavn;
            DatoOGTid(by);

            by = london;
            DatoOGTid(by);

            by = singapore;
            DatoOGTid(by);


            Console.ReadLine();


        }


    }
}
