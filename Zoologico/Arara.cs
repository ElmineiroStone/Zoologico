using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Arara : Ave
    {
        public Arara()
        {
            Console.WriteLine("A Arara está: ");
        }
        public void FazerNinho()
        {
            Console.WriteLine("Fazendo Ninho");
        }
        public void Mover()
        {
            Console.WriteLine("Voando");
        }
        
    }
}
