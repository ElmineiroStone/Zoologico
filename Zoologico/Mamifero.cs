namespace Zoologico
{
    public class Mamifero : Animal // Herança
    {
        private float peso; // Encapsulamento
        private string corPelo; // Encapsulamento

        public override void Locomover() //Polimorfismo de sobreposição
        {
            Console.WriteLine("Correndo");
        }
        public override void Alimentar() //Polimorfismo de sobreposição
        {
            Console.WriteLine("Mamando");
        }
        public override void EmitirSom() //Polimorfismo de sobreposição
        {
            Console.WriteLine("Som de mamifero");
        }
        

        public string CorPelo { get => corPelo; set => corPelo = value; }
        public float Peso { get => peso; set => peso = value; }
    }
}
