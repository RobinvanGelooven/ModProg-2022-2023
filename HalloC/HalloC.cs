using System; //algemen BS

void Verschilbepaling()
{
    Console.WriteLine("Hey hallo, we gaan vandaag bepalen wanneer je volgende Kdag is. Om te beginnen: " +
        "in welk jaar ben je geboren?");
    int jaar = int.Parse(Console.ReadLine());
    Console.WriteLine($"{jaar}, vet! En in welke maand?");
    int maand = int.Parse(Console.ReadLine());
    Console.WriteLine("Alright, en op welke dag (datum aub)?");
    int dag = int.Parse(Console.ReadLine());
    DateTime geboorte = new DateTime(jaar, maand, dag);
    //Console.WriteLine($"Dus op {geboorte}!!!");

    DateTime vandaag = DateTime.Today;
   // var vandaagkort = vandaag.ToShortDateString();
    //Console.WriteLine($"Vandaag is {vandaag}");

    TimeSpan t = vandaag - geboorte;
    double verschil = t.TotalDays;

    Console.WriteLine($"Je bent nu {verschil} dagen oud");
    Console.WriteLine("Nu bereken ik wanneer je volgende verKdag is"); 

    if (verschil % 1000 == 0)
    {
        Console.WriteLine("Gefeliciteerd, het is je verKdag!"); 
    }
    else {
        double nverschil = 1000 -(verschil % 1000);
        Console.WriteLine($"Je verKdag is al over {nverschil} dagen, joepie!");
    }
}
Verschilbepaling();

Console.WriteLine("Wil je nog een keer iets berekenen?");
string antwoord = Console.ReadLine(); 

if  (antwoord == "Ja");
{ 
    Verschilbepaling();
        }
