using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class GoldFish : Peixe
    {
        public override void Locomover()
        {
            Console.WriteLine("Nadando");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Comendo Algas");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Peixe não faz som");
        }


    }
}

