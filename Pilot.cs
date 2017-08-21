using System;

namespace interface_generics_inheritance
{
    public class Pilot : Soldier,IPilot
    {
        public Pilot(string name, int serialNumber, string rank) : base(new AirPlane(), name, serialNumber, rank)
        {
            Name = name;
            SerialNumber = serialNumber;
            Rank = rank;
        }
        public override void Speak() 
        {
            Console.WriteLine("Hooah!");
        }

        public int NumberOfBombs()
        {
            return 10;
        }

        public string BombType()
        {
            return "Napalm";
        }
    }

}