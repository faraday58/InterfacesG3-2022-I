using System;

namespace InterfacesG3_2022_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Estufa estufa = new Estufa();
            IApagar Iapagar = estufa;
            Iapagar.Apagar();



            Console.ReadLine();
        }
    }
}
