using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Colosseum.Runtime;

namespace Colosseum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main UI
            Console.WriteLine("!!!THIS IS A VERY EARLY BUILD OF COLOSSEUM SO EXPECT BUGS!!!");
            Console.WriteLine("!!!FOR NOW I HAVE IMPLEMENTED ONLY TWO GLADIATORS MORE TO COME IN THE FUTURE!!!");
            Console.WriteLine("!!!THE OPTION THE CREATE YOUR OWN GLADIATORS IS STILL IN WORK SO PLEASE BE PATIENT!!!");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Welcome to Colosseum where you play as a Lanist in ancient Rome.");
            Console.WriteLine("Choose your warriors, train them and make them engage in battle to the dead");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Retarius --> press R on the keyboard to pick this gladiator");
            Console.WriteLine("Myrmillonis --> press M on the keyboard to pick this gladiator");

            //UI for First Gladiator
            var firstKeyInput = Console.ReadKey(true);

            var firstGladiator = BattleRuntime.SelectGladiatorByKeyInput(firstKeyInput.Key);
            
            Console.WriteLine("You have picked" + firstGladiator.Name);
            
            //UI for Second Gladiator
            var secondKeyInput = Console.ReadKey(true);

            var secondGladiator = BattleRuntime.SelectGladiatorByKeyInput(secondKeyInput.Key);

            Console.WriteLine("You have picked" + secondGladiator.Name);
            
            //Battle Start-up
            BattleRuntime.BeginFight(firstGladiator, secondGladiator);

            Console.ReadKey();
        }
    }
}