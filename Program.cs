using System;

namespace InterfacesG3_2022_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Estufa estufa = new Estufa();
            estufa.Encender();
            IApagar Iapagar = estufa;
            Iapagar.Apagar();



            Refrigerador miRefrigerador = new Refrigerador();
            IEncender encender = miRefrigerador;
            encender.Encender();
            miRefrigerador.Apagar();

            Console.ReadLine();
        }
    }
}
