using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Tartaruga : Reptil
    {
        public Tartaruga()
        {
            Console.WriteLine("A Tartaruga está: ");
        }
        public override void Locomover()
        {
            Console.WriteLine("Andando devagar");
        }
    }
}
