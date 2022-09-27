namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        
        public Iphone(string numero, string modelo, int imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }

        // Sobscrevendo do método"InstalarAplicativo"

        public override void InstalarAplicativo(string iosApp)
        {
            Console.WriteLine("Instalando aplicativo" + iosApp + " em dispositivo Iphone");
        }
    }
}