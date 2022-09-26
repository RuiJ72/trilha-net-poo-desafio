namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; }
        private int Imei { get; }
        private int Memoria { get; }

        public Smartphone(string numero, string modelo, int imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;  
        }

        public void Ligar()
        {
            Console.WriteLine("Estabelecendo a ligação...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo uma ligação...");
        }

        // Método para exibir número
        public void MostrarNumero()
        {
            Console.WriteLine(this.Numero);
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}