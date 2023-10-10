namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo '{nomeApp}' foi instalado com sucesso no Nokia");
        }
    }
}