namespace Zoologico
{
    public class Reptil:Animal
    {
        private string corEscama;

        public override void Locomover()
        {
            Console.WriteLine("Rastejando");
        }
        public override void Alimentar()
        {
            Console.WriteLine("Comendo vegetais");
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Som de réptil");
        }

        public string CorEscama { get => corEscama; set => corEscama = value; }
    }
}
