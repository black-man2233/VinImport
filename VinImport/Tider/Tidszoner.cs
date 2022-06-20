using System;
using System.Drawing;
using Console = Colorful.Console;


namespace VinImport.Tider
{
    public class Tidszoner
    {
        public static void Tider()
        {
            //variabler til tid
            DateTime dkTid = DateTime.Now;
            var kobenhavnTid = dkTid.ToString("HH.mm:ss");
            var singaporeTid = dkTid.AddHours(9).ToString("HH:mm:ss");
            var londonTid = dkTid.AddHours(-1).ToString("HH:mm:ss");
            var HongKongTid = dkTid.AddHours(6).ToString("HH:mm:ss");

            //variabler til dage.
            




            Console.WriteLine($"{("Dato / tid")}\n" +
               $"-----------\n" +
               $"København = {kobenhavnTid} \n" +
               $"Singapore = {singaporeTid} \n" +
               $"London = {londonTid}   \n" +
               $"HongKong = {HongKongTid} ");




        }
    }
}

