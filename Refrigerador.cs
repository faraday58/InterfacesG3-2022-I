using System;


namespace InterfacesG3_2022_I
{
    class Refrigerador :ElectroDomestico, IApagar,IEncender
    {
        public void Apagar()
        {
            Console.WriteLine("Apagando Refrigerador \n Bye");
        }
       
        void IEncender.Encender()
        {
            Console.WriteLine("+++ Encendiendo iluminación interna  +++");
        }
      
        public Refrigerador()
        {
            Marca = "LG";
            Console.WriteLine("***  {0} te da la Bienvenida *** ",Marca);
        }
    }
}
