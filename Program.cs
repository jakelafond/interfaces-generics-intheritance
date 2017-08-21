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

            var deadShot = new Sniper("Deadshot", 9999, "Private");
            Console.WriteLine($"I am {deadShot.Name}, serial number {deadShot.SerialNumber}, I am {deadShot.Rank}. I have {deadShot.NumberOfConfirmedKills()} confirmed kills and my rifle's name is {deadShot.RifleName()}.");
            deadShot.Speak();
            deadShot.Attack();

            var Sanders = new TankDriver("Sanders", 5525, "General");
            Console.WriteLine($"I am {Sanders.Name}, serial number {Sanders.SerialNumber}, I am {Sanders.Rank}. I have crushed over {Sanders.NumberOfCarsCrushed()} cars with old {Sanders.TankName()} here.");
            Sanders.Speak();
            Sanders.Attack();

        }
    }
}
