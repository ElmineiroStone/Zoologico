namespace Zoologico
{
    public class Cachorro : Lobo
    {
        public Cachorro()
        {
            Console.WriteLine("O Cachorro está: ");
        }
        public override void Locomover()
        {
            Console.WriteLine("Correndo");
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Latindo");
        }
        
        public void Reagir(string frase)
        {
            if(frase == "Toma comida" || frase == "Olá")
            {
                Console.WriteLine("Abanar o rabo e latir");
            }
            else
            {
                Console.WriteLine("Rosnando");
            }
        }
        public void Reagir(int hora, int minuto)
        {
            if(hora < 12)
            {
                Console.WriteLine("Abanando o rabo");
            }
            else if (hora >= 18)
            {
                Console.WriteLine("Ignorando");
            }
            else
            {
                Console.WriteLine("Abanando e latindo");
            }
        }
        public void Reagir(bool dono)
        {
            if(dono)
            {
                Console.WriteLine("Abanando o rabo");
            }
            else
            {
                Console.WriteLine("Rosnando e latindo");
                this.EmitirSom();
            }
        }
        public void Reagir(int idade, float peso)
        {
            switch (idade)
            {
                case < 5:
                    if (peso < 10)
                    {
                        Console.WriteLine("Abanando o rabo");
                    }
                    else
                    {
                        Console.WriteLine("Latindo");
                    }
                    break;
                default:
                    if (peso < 10)
                    {
                        Console.WriteLine("Rosnando");
                    }
                    else
                    {
                        Console.WriteLine("Ignorando");
                    }

                    break;
            }
        }
    }
}
