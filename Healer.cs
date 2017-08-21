using System;

namespace interface_generics_inheritance
{
    public class Healer : Soldier,IHealer
    {
        public override string Speak()
        {
            return "Hooah";
        }
    }

}