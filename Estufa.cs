using System;

namespace InterfacesG3_2022_I
{
    class Estufa:IApagar
    {
        void IApagar.Apagar()
        {
            Console.WriteLine("***** Apagando Estufa ****");
        }
       

        public Estufa()
        {
            Console.WriteLine("Mabe, Bienvenido ");
        }
    }
}
