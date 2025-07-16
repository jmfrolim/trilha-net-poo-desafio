using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private string Memoria;
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            IMEI = imei;
            Modelo = modelo;
            Memoria = memoria; 
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...\n");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...\n");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}