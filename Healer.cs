using System;

namespace interface_generics_inheritance
{
    public class Healer : Soldier, IHealer
    {

        public Healer(string name, int serialNumber, string rank) : base(new MedKit(), name, serialNumber, rank)
        {
            Name = name;
            SerialNumber = serialNumber;
            Rank = rank;
        }
        public override void Speak()
        {
             Console.WriteLine("Help is on the way!");
        }

        public int NumberOfMedkits()
        {
            return 5;
        }

        public string FavoriteInjury()
        {
            return "Bullet wound";
        }
    }

}