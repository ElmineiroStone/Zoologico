namespace Zoologico
{
    public class Ave:Animal
    {
        private string corPena;

        public override void Locomover()
        {
            Console.WriteLine("Voando");
        }
        public override void Alimentar()
        {
            Console.WriteLine("Comendo frutas");
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Som da ave");
        }
        public void FazerNinho()
        {
            Console.WriteLine("Construindo ninho");
        }
        public string CorPena { get => corPena; set => corPena = value; }
    }
}
