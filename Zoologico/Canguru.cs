using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Canguru : Mamifero
    {
        public Canguru()
        {
            Console.WriteLine("O Canguru está: ");
        }

        public override void Locomover()
        {
            Console.WriteLine("Saltando");
        }
        public void UsarBolsa()
        {
            Console.WriteLine("Usando Bolsa");
        }
        public void Mover()
        {
            Console.WriteLine("Saltando");
        }
        
        
            
    }
}
