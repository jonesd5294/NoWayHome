using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WorldEngine;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            

            StandardMessage.DisplayWelcome();

            
            //Intro and Menu Selection
           
            Console.WriteLine("Enter a selection");
            Console.WriteLine("1 - Rooms, 2 - Weapons, 3 - Potions, 4 Treasure, 5 Items, 6 Mob, 7 Exit");
            
            //Get user selection
            int menu = int.Parse(Console.ReadLine());

            //Switich statement for menu selection
            switch(menu)
            {
                case 1:
                    //Display room variables
                    Console.WriteLine("You chose to display rooms: " + room1 + ", " + room2 + ", "+ room3 + ", " + room4 + ", " + room5 + "." );

                    inputFile = File.OpenText(@"../../../ConsoleUI/Docs/Rooms.txt");                    

                    //While Loop and text document read
                    while (!inputFile.EndOfStream)
                    {
                        rooms = (inputFile.ReadLine());
                        Console.WriteLine(rooms);
                    }

                    //close file
                    inputFile.Close();

                    break;

                case 2:
                    //Display weapon variables
                    Console.WriteLine("You chose to display Weapons: " + weapon1 + ", " + weapon2 + ", " + weapon3 + ", " + weapon4 + ".");

                    inputFile = File.OpenText(@"../../../ConsoleUI/Docs/Weapons.txt");

                    //While Loop and text document read
                    while (!inputFile.EndOfStream)
                    {
                        weapons = (inputFile.ReadLine());
                        Console.WriteLine(weapons);
                    }

                    //close file
                    inputFile.Close();

                    break;

                case 3:
                    //Display potion variables
                    Console.WriteLine("You chose to display Potions: " + potion1 + ", " + potion2 + ".");
                    
                    break;

                case 4:
                    //Display treasure variables
                    Console.WriteLine("You chose to display Treasure: " + treasure1 + ", " + treasure2 + ", " + treasure3 + ".");
                    
                    break;

                case 5:
                    //Dispaly item variables
                    Console.WriteLine("You chose to dispaly Items: " + item1 + ", " + item2 + ", " + item3 + ", " + item4 + ".");
                    
                    break;

                case 6:
                    //Dispaly mob variables
                    Console.WriteLine("You chose to display Mob: " + mob1 + ", " + mob2 + ", " + mob3 + ", " + mob4 + ", " + mob5 + ".");

                    inputFile = File.OpenText(@"../../../ConsoleUI/Docs/Mobs.txt");

                    //While Loop and text document read
                    while (!inputFile.EndOfStream)
                    {
                        mobs = (inputFile.ReadLine());
                        Console.WriteLine(mobs);
                    }

                    //close file
                    inputFile.Close();

                    break;

                case 7:
                    //Exit game
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
