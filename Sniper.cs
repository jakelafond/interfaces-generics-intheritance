using System;

namespace interface_generics_inheritance
{
    class Sniper : Soldier,ISniper
    {
        public Sniper(string name, int serialNumber, string rank) : base(new SniperRifle(), name, serialNumber, rank)
        {
            Name = name;
            SerialNumber = serialNumber;
            Rank = rank;
        }
        public override void Speak()
        {
             Console.WriteLine("One shot, one kill.");
        }

        public int NumberOfConfirmedKills()
        {
            return 150;
        }

        public string RifleName()
        {
            return "Bertha";
        }
    }

}