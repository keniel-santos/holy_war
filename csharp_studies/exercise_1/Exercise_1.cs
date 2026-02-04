using System;

namespace MyApplication
{
    enum GateState
    {
        Vigilant,
        Weak,
        Corrupted
    }
    class Program
    {
        static GateState CalculateState(int integrity)
        {
            return integrity switch
            {
                >= 70 => GateState.Vigilant,
                >= 30 => GateState.Weak,
                _ => GateState.Corrupted
            };
        }

        static void Main()
        {
            Console.WriteLine("What's the integrity level of the gate?");
            
            while (true)
            {
                Console.Write("Integrity (0-100): ");

                if (!int.TryParse(Console.ReadLine(), out int integrity))
                {
                    Console.WriteLine("Invalid value! Try again:");
                    continue;
                }

                if (integrity < 0 || integrity > 100)
                {
                    Console.WriteLine("The integrity level must be between 0 and 100. Try again:");
                    continue;
                }

                Console.WriteLine($"\nThe state of the gate is: {CalculateState(integrity)}");
                break;
            }
        }
    }
}