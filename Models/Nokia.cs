namespace DesafioPOO.Models
{
    // Classe Nokia herdando de Smartphone
    public class Nokia : Smartphone
    {
        // Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, int imei, int memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            throw new NotImplementedException();
        }
    }
}