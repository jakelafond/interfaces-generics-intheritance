using System;

namespace interface_generics_inheritance
{
    class TankDriver : Soldier,ITankDriver
    {

        public TankDriver(string name, int serialNumber, string rank) : base(new Tank(), name, serialNumber, rank)
        {
            Name = name;
            SerialNumber = serialNumber;
            Rank = rank;
        }
        public override void Speak()
        {
             Console.WriteLine("Rolling out!");
        }

        public int NumberOfCarsCrushed()
        {
            return 50;
        }

        public string TankName()
        {
            return "Louise";
        }
    }

}