namespace Zoologico
{
    public abstract class Animal  // Classe abstrata
    {
        // Atributos de animal
        protected float peso; // Encapsulamento
        protected int idade; // Encapsulamento
        protected int membros; // Encapsulamento

        // Métodos de animal
        public abstract void Locomover(); // Polimorfismo de sobreposição
        public abstract void Alimentar(); // Polimorfismo de sobreposição
        public abstract void EmitirSom(); // Polimorfismo de sobreposição

        public int Idade { get => idade; set => idade = value; }
        public int Membros { get => membros; set => membros = value; }
        public float Peso { get => peso; set => peso = value; }
    }
}
