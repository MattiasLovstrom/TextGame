using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Security;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var bedroom = new room();
            bedroom.name = "bedroom";
            var kitchen = new room();
            kitchen.name = "kitchen";
            var streat = new room();
            streat.name = "streat";
            var you = new Character();
            you.room = bedroom;
            you.name = "you";
            you.health = 20;
            you.hunger = 15;
            Console.WriteLine("Hello "+you.name+" ! You have been born as a ground pleb! You wake up in you`r bed from a nightmare");
            you.displaystaytus();
            Console.WriteLine("what do you want to do?");
            Console.WriteLine("1-contiune sleeping");
            Console.WriteLine("2-look around");
            var choise = Console.ReadLine();
            if (choise == "1")
            {
                Console.WriteLine("you desided to countiune sleep sudenly you wake up to a horible smell you smell SMOKE you quickly rush to the door but its to late the fire has allready blocked you from escaping you can only watch as the flames burn you alive at least you`r family has made it out alive");
                return;
            }
                Console.WriteLine("you decide to look around you cant see much in the smoke wait SMOKE");
            Console.WriteLine("1-save you`r self");
            Console.WriteLine("2-attempt to put out the fire");
            choise = Console.ReadLine();
            if (choise == "1")
            {
                Console.WriteLine("you rush out the door the fire has`ent cached up to you so you quickly escape "); 
                you.room = streat;
                you.displaystaytus();
            } else if (choise == "2")
            {
                Console.WriteLine("you quickly put out the fire but you get some burns doing so");
                Console.WriteLine("you take one point of damage");
                you.health = you.health - 1;
                you.hunger = you.hunger - 1;
                
                you.room = kitchen;
                you.displaystaytus();

             
            }





            Console.WriteLine("this is the end for now have a good day but you have not won yet");
        }
    }
}
