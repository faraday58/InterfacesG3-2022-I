using System;

namespace InterfacesG3_2022_I
{
    class Estufa:IApagar,IEncender
    {
        private byte perilla;

        public byte Perilla { get => perilla;
            set => perilla = value; }

        void IApagar.Apagar()
        {
            Console.WriteLine("***** Apagando Estufa ****");
        }

        public void Encender()
        {
            Console.WriteLine("+++  Encendiendo quemador 1  +++");
        }

        public Estufa()
        {
            Console.WriteLine("Mabe, Bienvenido ");
        }
    }
}
