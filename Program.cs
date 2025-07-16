using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
string[] apps= new string []  { "WhatsApp", "Facebook", "Instagran"};
Nokia nokia = new Nokia("9890098", "D3", "9232912093012", "128GB");
desenhaTraco();
System.Console.WriteLine("Operações com o Nokia\n");
nokia.Ligar();
nokia.ReceberLigacao();
foreach (var app in apps)
{
    nokia.InstalarAplicativo(app);
}
desenhaTraco();


Iphone iphone = new Iphone("9890098", "D3", "9232912093012", "128GB");
desenhaTraco();
System.Console.WriteLine("Operações com o Iphone\n");
iphone.Ligar();
iphone.ReceberLigacao();
foreach (var app in apps)
{
    nokia.InstalarAplicativo(app);
}
desenhaTraco();


void desenhaTraco()
{
    System.Console.WriteLine("==============================================\n");
}