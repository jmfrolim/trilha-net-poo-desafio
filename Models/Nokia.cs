namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero,string modelo,string imei,string memoria) : base(numero,modelo,imei, memoria)
        {            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            var myClass = typeof(Nokia);
            System.Console.WriteLine($"Buscando o App {nomeApp} na PlayStore !");
            System.Console.WriteLine($"Instalando o Aplicativo {nomeApp} no Smartphone {myClass.Name}  \n!");
        }
    }
}