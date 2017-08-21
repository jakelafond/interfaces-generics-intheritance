using System;
namespace interface_generics_inheritance
{
    public abstract class Soldier
    {
        public string Name { get; set; }
        public int SerialNumber { get; set; }
        public string Rank { get; set; }
        public IWeapon Weapon { get; set; }
        

        public Soldier(IWeapon weapon, string name, int serialNumber, string rank)
        {
            Name = name;
            SerialNumber = serialNumber;
            Rank = rank;
            this.Weapon = weapon;
        }

        string March()
        {
            return "Left right left";
        }
        string Sleep()
        {
            return "ZzzZzzZzz";
        }
        string Eat()
        {
            return "NomNomNomNom";
        }
        public abstract void Speak();

        public void Attack(){
            this.Weapon.DoDamage();
        }
    }
}