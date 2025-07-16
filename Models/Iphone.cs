namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero,string modelo,string imei,string memoria) : base(numero,modelo,imei, memoria)
        {}
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            var myClass = typeof(Iphone);
            System.Console.WriteLine($"Buscando o App {nomeApp} na App Store !");
            System.Console.WriteLine($"Instalando o Aplicativo {nomeApp} no Smartphone {myClass}  \n!");
        }
    }
}