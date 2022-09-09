namespace Zoologico
{
    public class Peixe:Animal
    {
        private string corEscama;

        public override void Locomover()
        {
            Console.WriteLine("Nadando");
        }
        public override void Alimentar()
        {
            Console.WriteLine("Comendo substâncias");
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Peixe não faz som");
        }
        public void SoltarBolhas()
        {
            Console.WriteLine("Soltando bolhas");
        }

        public string CorEscama { get => corEscama; set => corEscama = value; }
    }
}
