using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTime.Classes
{
    public class StartingTown
    {
        public string answer;

        public StartingTown()
        {
        }


        public void GetOutOfBed()
        {
            Console.WriteLine("Do you want to go to the park? Yes or no.");
            answer = Console.ReadLine().ToLower();

            if(answer == "yes")
            {
                Console.WriteLine("You decided to go to the park.");
                this.GoToPark();
            }
            else if(answer == "no")
            {
                Console.WriteLine("You choose to go back to sleep");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You didn't say yes or no.");
                this.GetOutOfBed();
            }
        }

        public void GoToPark()
        {
            Console.WriteLine("When you get to the park you see a monster spawing, what do you do?");
            Console.WriteLine("1: Run for you life \n 2: Fight them to the death \n 3: Help the elderly, young, and disable get away \n 4: Stand there in shock");
            answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    Console.WriteLine("You choose to run like a coward!");
                    this.GetToRunning();
                    break;
                case "2":
                    Console.WriteLine("You choose to fight to the death!");
                    this.GetFightingSkills();
                    break;
                case "3":
                    Console.WriteLine("You choose to help the people and as you were helping them, the police came and you hear a flurry of bullets rain on the monster.  It dies instantly. \n You decided that you've had enough adventure today and go back home to sleep.  Thanks for playing!");
                    break;
                case "4":
                    Console.WriteLine("You stand there in shock, nothing you can do but get torn to pieces.  Sorry buddy the least you could do was run.  Thanks for playing!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("You didn't choose one of the 4 options.");
                    this.GoToPark();
                    break;
            }

        }

        public void GetToRunning()
        {
            Console.WriteLine("You got away from the park with the monster but they chased after you.");
            Console.WriteLine("Do you wish to continue to run or fight?");
            answer = Console.ReadLine().ToLower();

            if(answer == "run")
            {
                Console.WriteLine("You ran faster and faster towards your house.  BUT! You weren't fast enough.  You died, running...like a coward. :(.  Thanks for playing!");
                Console.ReadLine();
            }
            else if(answer == "fight")
            {
                Console.WriteLine("You decided to fight!  Picking up a random stick on the ground, you swing at the monster knocking it out.");
                this.GoInForTheKill();
            }
            else
            {
                Console.WriteLine("You didn't choose to fight or run.");
                this.GetToRunning();
            }
        }

        public void GoInForTheKill()
        {
            Console.WriteLine("You have the choice to deal the final blow, do you wish to kill the monster? Yes or No.");
            answer = Console.ReadLine().ToLower();

            if(answer == "yes")
            {
                Console.WriteLine("You smash it's head in and kill it.  Exhasted, you decide to walk home and go to sleep. \n Thanks for playing!");
                Console.ReadLine();
            }
            else if(answer == "no")
            {
                Console.WriteLine("You decided to be nice and not kill it.  It loves you for it and becomes your pet.  Now you have a pet monster!  You decide to bring it home and get some sleep. \n Thanks for playing!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You didn't choose yes or no.");
                this.GoInForTheKill();
            }
        }

        public void GetFightingSkills()
        {
            Console.WriteLine("You pick up a stick and decided to swing.  Where do you swing?");
            Console.WriteLine("1: Head \n 2: Body \n 3: Legs/Arms \n 4: In The Air \n 5: Don't swing");
            answer = Console.ReadLine();

            switch(answer)
            {
                case "1":
                    Console.WriteLine("You swung at the head and hit it square between the eyes. It falls down.");
                    this.GoInForTheKill();
                    break;
                case "2":
                    Console.WriteLine("You swing at it's body and hit it, but it takes no damage.  It gets angry and attacks you and kills you.  You are dead now. :(");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("You hit its legs and break it.  It screams in pain and whimpers.");
                    this.GoInForTheKill();
                    break;
                case "4":
                    Console.WriteLine("To your surprise it was frighten by your random flailing and ran off.  Like seriously, what the heck?  \n You decided life outside was to crazy and you decided to go home and sleep.  Thanks for playing!");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("SERIOUSLY?!?! The monster decides your easy prey and rips you a new one.  You died, doing nothing, nothing at all!  Thanks for playing!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("You didn't choose a number from 1 to 5.");
                    this.GetFightingSkills();
                    break;
            }
        }
    }
}
