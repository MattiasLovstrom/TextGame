using System;

namespace TextGame
{
    internal class Character
    {
        internal string name;
        public double health;
        public room room;
        internal int hunger;

        public Character()
        {
        }

        internal void displaystaytus()
        {
            Console.WriteLine("you now have " + health + " health");
            Console.WriteLine("you are now in the " + room.name);
            if (hunger < 1)
            {
                Console.WriteLine("you quickly fall to the ground you have become weak from you´r lack of eating you close you´r eyes never to open them again");
                Environment.Exit(0);
            }
            else if (hunger < 6)
            {
                Console.WriteLine("you´r stomach rumbelse");
            }
            else if (hunger < 10)
            {
                Console.WriteLine("you are starting to feel hungry");
            }
            else
            {
                Console.WriteLine("you feel satesfide and full");
            }
        }
    }
}