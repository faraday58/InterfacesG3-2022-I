using System;


namespace InterfacesG3_2022_I
{
    abstract class ElectroDomestico
    {
        private string marca;


        public ElectroDomestico()
        {
            Console.WriteLine(" Gracias por adquirir este electrodoméstico ");

        }

        public string Marca { get => marca; set
            {
                if( value == "")
                {
                    marca = "Genérica";
                }
                else
                {
                    marca = value;
                }
                
            }
        }
                
    }
}
