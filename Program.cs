using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            BOB bob = new BOB(new IGLOO());
            bob.constract();
            House myhouse = bob.GetHouse();
        }
    }
}
