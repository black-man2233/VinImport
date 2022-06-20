using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinImport.Temperature;
using VinImport.Tider;

namespace VinImport
{
    public  class Tabel
    {

        public static void Finale()
        {


          Console.WriteLine("                                            |                                    \n" +
                            "                                            |                                    ");
            Temperature_Fugtighed.TemperatureOgFugtighed(); VinImport.Lagerstatus.Lager_Status.AltPaaLager();


            Console.WriteLine("--------------------------------------------|                                    \n" +
                            "                                            |                                    ");
                    DatoOgTid.Fulldato();

          Console.WriteLine("--------------------------------------------|                                    \n" +
                            "                                            |                                    ");




            System.Console.ReadLine();

            
        }


    }
}
