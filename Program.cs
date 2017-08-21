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

            var ltMorales = new Healer("Lt. Morales", 1337, "Lieutenant");
            Console.WriteLine($"I am {ltMorales.Name}, serial number {ltMorales.SerialNumber}, I am {ltMorales.Rank}. I have {ltMorales.NumberOfMedkits()} medkits and my favorite injury to treat is a {ltMorales.FavoriteInjury()}.");
            ltMorales.Speak();
            ltMorales.Attack();
        }
    }
}
