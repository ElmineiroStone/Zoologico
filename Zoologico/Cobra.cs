namespace Zoologico
{
    public class Cobra : Reptil
    {
        public Cobra(string tipoVeneno, string venenoso)
        {
            TipoVeneno = tipoVeneno;
            Venenoso = venenoso;

        }
        public string TipoVeneno { get; set; }
        public string Venenoso { get; set; }

        public override string ToString()
        {
            return base.ToString() + "Tipo de veneno: " + TipoVeneno + " Venenoso: " + Venenoso;

        }
    }
}
