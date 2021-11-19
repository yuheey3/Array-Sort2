/*
 Date:Nov.18.2021
 Name: Yuki Waka
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace sortArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrlist = new List<string>();
            arrlist.Add("Selfie Stick,98,29");
            arrlist.Add("iPhone Case,90,15");
            arrlist.Add("Fire TV Stick,48,49");
            arrlist.Add("Wyze Cam,48,25");
            arrlist.Add("Water Filter,56,49");
            arrlist.Add("Blue Light Blocking Glasses,90,16");
            arrlist.Add("Ice Maker,47,119");
            arrlist.Add("Video Doorbell,47,199");
            arrlist.Add("AA Batteries,64,12");
            arrlist.Add("Disinfecting Wipes,37,12");
            arrlist.Add("Baseball Cards,73,16");
            arrlist.Add("Winter Gloves,32,112");
            arrlist.Add("Microphone,44,22");
            arrlist.Add("Pet Kennel,5,24");
            arrlist.Add("Jenga Classic Game,100,7");
            arrlist.Add("Ink Cartridges,88,45");
            arrlist.Add("Instant Pot,98,59");
            arrlist.Add("Hoze Nozzle,74,26");
            arrlist.Add("Gift Card,45,25");
            arrlist.Add("Keyboard,82,19");

            Console.WriteLine("***************************** Original Array*****************************\n");

            foreach (var item in arrlist)
            {
                Console.WriteLine(item);
            }

            var orderedList = arrlist.OrderByDescending(x => int.Parse(x.Split(',')[1])) // order by popularity(After the first comma)
                               .ThenBy(x => x.Split(',')[2])  // then order by price (After the second comma)
                               .ToList();

            Console.WriteLine("\n\n****************After Sorted by Popularity and then price****************\n");

            foreach (var item in orderedList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
