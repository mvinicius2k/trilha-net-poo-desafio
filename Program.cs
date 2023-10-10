using DesafioPOO.Models;
using System.Text;

// TODO: Realizar os testes com as classes Nokia e Iphone

var smartphones = new Smartphone[]
{
    new Nokia("55 15 91185-8885", "N15", "1954564894594", 4000),
    new Nokia("15 10 1155-6685", "N20", "1545154694696", 6000),
    new Nokia("55 88 95984-6685", "N20", "0045150605606", 6000),
    new Iphone("15 15 99188-8285", "iPhone 15", "9999999999594", 4000),
    new Iphone("55 45 4050-6645", "iPhone 16", "1545151541596", 8000),
};

//Apps para instalar
var apps = new Dictionary<Type, string[]>
{
    {typeof(Nokia), new string[] { "Whatsapp", "GCam", "Vector", "VLC", "Edge" }},
    {typeof(Iphone), new string[] { "Telegram", "PUBG", "Safari" }}
};

//Random para escolher um aleatório
var random = new Random(DateTime.Now.Millisecond);



foreach (var smartphone in smartphones)
{
    var tipo = smartphone.GetType();
    Console.WriteLine($"Tipo: {tipo.Name}");
    Console.WriteLine($"Número: {smartphone.Numero}");
    Console.Write($"Teste de ligar:");
    smartphone.Ligar();
    Console.Write($"Teste de receber ligação:");
    smartphone.ReceberLigacao();
    Console.Write("Teste de instalar app: ");

    var appsDisponiveis = apps[tipo];

    //Testa instalando um app aleatório de acordo com o tipo
    smartphone.InstalarAplicativo(appsDisponiveis[random.Next(appsDisponiveis.Length)]);

    Console.WriteLine("----------------------------");

}

