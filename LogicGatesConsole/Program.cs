using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LogicGatesConsole.components;

namespace LogicGatesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Build circuit
            Component[] composants = new Component[4];
            composants[0] = new Switch();
            composants[1] = new Switch();
            composants[2] = new Xor();
            composants[3] = new Sink();

            ((Xor)composants[2]).Input1 = composants[0];
            ((Xor)composants[2]).Input2 = composants[1];
            ((Sink)composants[3]).Input = composants[2];

            //Test
            ((Switch)composants[0]).off();
            ((Switch)composants[1]).off();
            foreach (Component comp in composants)
            {
                Console.WriteLine(comp.description());
            }
            Console.WriteLine("Sink is " + ((composants[3]).getState() ? "on" : "off"));

            ((Switch)composants[0]).on();
            ((Switch)composants[1]).off();
            foreach (Component comp in composants)
            {
                Console.WriteLine(comp.description());
            }
            Console.WriteLine("Sink is " + ((composants[3]).getState() ? "on" : "off"));

            ((Switch)composants[0]).off();
            ((Switch)composants[1]).on();
            foreach (Component comp in composants)
            {
                Console.WriteLine(comp.description());
            }
            Console.WriteLine("Sink is " + ((composants[3]).getState() ? "on" : "off"));

            ((Switch)composants[0]).on();
            ((Switch)composants[1]).on();
            foreach (Component comp in composants)
            {
                Console.WriteLine(comp.description());
            }
            Console.WriteLine("Sink is " + ((composants[3]).getState() ? "on" : "off"));

            //Close
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
