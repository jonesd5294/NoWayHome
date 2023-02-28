using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Room Variables
            string room1 = "Prison Cell";
            string room2 = "Corridor";
            string room3 = "Interogation Room";
            string room4 = "HallWay";
            string room5 = "Exit";


            //Declare Weapon Variables
            string weapon1 = "Bow";
            string weapon2 = "Knife";
            string weapon3 = "Gun";
            string weapon4 = "RPG";

            //Declare Potion Variables
            string potion1 = "Water";
            string potion2 = "Food";

            //Declare Treasure Variables
            string treasure1 = "Gold";
            string treasure2 = "Silver";
            string treasure3 = "Copper";

            //Declare Item Variables
            string item1 = "Poncho";
            string item2 = "Compass";
            string item3 = "Torch";
            string item4 = "Bottle";

            //Declare Mob Variables
            string mob1 = "Snake";
            string mob2 = "Panther";
            string mob3 = "Enemy";
            string mob4 = "Local";
            string mob5 = "Scorpion";

            //Intro and Menu Selection
            Console.WriteLine("Welcome to NoWayHome");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter a selection");
            Console.WriteLine("1 - Rooms, 2 - Weapons, 3 - Potions, 4 Treasure, 5 Items, 6 Mob, 7 Exit");
            
            //Get user selection
            int menu = int.Parse(Console.ReadLine());
                        
            //Switich statement for menu selection
            switch(menu)
            {
                case 1:
                    Console.WriteLine("You chose to display rooms: " + room1 + ", " + room2 + ", "+ room3 + ", " + room4 + ", " + room5 + "." );
                    break;

                case 2:
                    Console.WriteLine("You chose to display Weapons: " + weapon1 + ", " + weapon2 + ", " + weapon3 + ", " + weapon4 + ".");
                    break;

                case 3:
                    Console.WriteLine("You chose to display Potions: " + potion1 + ", " + potion2 + ".");
                    break;

                case 4:
                    Console.WriteLine("You chose to display Treasure: " + treasure1 + ", " + treasure2 + ", " + treasure3 + ".");
                    break;

                case 5:
                    Console.WriteLine("You chose to dispaly Items: " + item1 + ", " + item2 + ", " + item3 + ", " + item4 + ".");
                    break;

                case 6:
                    Console.WriteLine("You chose to display Mob: " + mob1 + ", " + mob2 + ", " + mob3 + ", " + mob4 + ", " + mob5 + ".");
                    break;

                case 7:
                    Environment.Exit(0);
                    break;


                default:
                    Console.WriteLine("Error, please chose a correct option.");
                    break;
            }


            Console.ReadLine();
        }
    }
}
