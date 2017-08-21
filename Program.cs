using System;

namespace interface_generics_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var goose = new Pilot("Goose", 12345, "Captain");
            Console.WriteLine($"I am {goose.Name}, serial number {goose.SerialNumber}, I am {goose.Rank}. I have {goose.NumberOfBombs()} {goose.BombType()} bombs.");
            goose.Speak();
            goose.Attack();

            
        }
    }
}
