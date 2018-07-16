using System;
using System.Collections.Generic;
using System.Linq;
using Colosseum.Data;

namespace Colosseum.Start
{
    class UIcomponents
    {

        //Initializes UI
        public static void MainUI()
        {
            //Main UI
            Console.WriteLine("!!!THIS IS A VERY EARLY BUILD OF COLOSSEUM SO EXPECT BUGS!!!");
            Console.WriteLine("!!!FOR NOW I HAVE IMPLEMENTED ONLY TWO GLADIATORS MORE TO COME IN THE FUTURE!!!");
            Console.WriteLine("!!!THE OPTION THE CREATE YOUR OWN GLADIATORS AND STORE THEM FOR LATER FIGHTINGS IS STILL IN DEVELOPMENT!!!");
            Console.WriteLine("!!!IF YOU HAVE SUGESTIONS SEND ME AN EMAIL ON dimitararnaudov68@gmail.com!!!");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Welcome to Colosseum where you play as a Lanist in ancient Rome.");
            Console.WriteLine("Choose your warriors, train them and make them engage in battle to the dead");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine();

            var allGladiators = GladiatorData.SelectAllGladiators();

            //List gladiators
            foreach (var gladiator in allGladiators)
            {
                Console.WriteLine(gladiator.Name + "--> press " + gladiator.Key + " on the keyboard to pick this gladiator");
                Console.WriteLine("Description: \n" + gladiator.Description);
                Console.WriteLine();
                Console.WriteLine("Stats: \n" + "Hit points:" + gladiator.Hp + " " + "Attack Power:" + gladiator.Ap + " "
                 + "Deffence:" + gladiator.Def + " " + "Chance To Dodge:" + gladiator.Ctd);
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine();
            }

            Console.WriteLine("IF YOU WANT TO TEACH YOUR OWN GLADIATOR PRESS --> C");
            Console.WriteLine();

            //Input for First Gladiator
            var firstKeyInput = Console.ReadKey(true);

            var firstGladiator = PickOrCreateGladiatorUI(firstKeyInput.Key);

            Console.WriteLine("You have picked " + firstGladiator.Name);
            Console.WriteLine();

            Console.WriteLine("IF YOU WANT TO TEACH YOUR OWN GLADIATOR PRESS --> C");
            Console.WriteLine();

            //Input for Second Gladiator
            var secondKeyInput = Console.ReadKey(true);

            var secondGladiator = PickOrCreateGladiatorUI(secondKeyInput.Key);
            Console.WriteLine();

            Console.WriteLine("You have picked " + secondGladiator.Name);

            //Battle Start-up
            BattleEngine.FightStart(firstGladiator, secondGladiator);
            Console.WriteLine();

            //Restart
            Console.WriteLine("IF YOU WANT TO TRY AGAIN PRESS ON THE KEYBOARD --> R");

            var restartKey = Console.ReadKey(true);

            if (restartKey.Key == ConsoleKey.R)
            {
                Console.Clear();
                MainUI();
            }
        }

        //Picks preexisting gladiator or creates a new one
        public static GladiatorTemplate PickOrCreateGladiatorUI(ConsoleKey keyInput)
        {
            if (keyInput == ConsoleKey.C)
            {
                Console.Write("Type the class name of your gladiator: ");
                string name = Console.ReadLine();

                Console.Write("Determine the hp of your gladiator: ");
                int hp = Int32.Parse(Console.ReadLine());

                Console.Write("Determine the attack of your gladiator: ");
                int atk = Int32.Parse(Console.ReadLine());

                Console.Write("Determine the deffence of your gladiator: ");
                int def = Int32.Parse(Console.ReadLine());

                Console.Write("Determine the chance to dodge of your gladiator: ");
                int ctd = Int32.Parse(Console.ReadLine());

                var newGladiator = GladiatorData.CreateGladiator(name, hp, atk, def, ctd);

                Console.WriteLine("Your first gladiator has been created with");

                Console.WriteLine("Stats: \n" + "Hp:" + newGladiator.Hp + " " + "Deffence:" + newGladiator.Def + " " + "Chance To Dodge:" + newGladiator.Ctd);

                return newGladiator;
            }
            else
            {
                var gladiator = GladiatorData.SelectGladiatorByKeyInput(keyInput);

                return gladiator;
            }
        }
    }
}
