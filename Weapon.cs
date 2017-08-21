using System;

namespace interface_generics_inheritance
{
    public interface IWeapon
    {
        void DoDamage();

    }

    public class AirPlane : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("DROPPING THE BOMBSHELL!");

        }
    }
        public class Tank : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Shelling!");

        }
    }
        public class SniperRifle : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Taking the shot");

        }
    }
            public class MedKit : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Healing the things!");

        }
    }
    
}