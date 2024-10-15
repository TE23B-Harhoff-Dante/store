
using System.Data.SqlTypes;
using System.Xml.Serialization;

bool success = false;
int ageNum = 0;
int cash = 100;
bool bad = false;
int timesTimes = 0;

while (success != true)
{
    Console.WriteLine("ålder");
    string age = Console.ReadLine();

    success = int.TryParse(age, out ageNum);

    if (success == false)
    {
        Console.WriteLine("Skriv en siffra, EFTERBLIVEN");
    }
}


if (ageNum >= 18)
{
    Console.WriteLine("välkommen");

}
else if (ageNum <= 17)
{
    bad = true;
    while (bad == true)
    {
        Console.WriteLine("UT UR MIN AFFÄR");
        Console.ReadLine();
    }
}


while (cash > 0)
{
    Console.WriteLine("Vad  vill du köpa?");
    Console.WriteLine($"Du har {cash}pengar");
    Console.WriteLine("hus(30) bord(20) låda(10)");


    string choice = Console.ReadLine();

    if (choice.ToLower() == "hus")
    {
        Console.WriteLine("Hur många vill du köpa?");
        string times = Console.ReadLine();
        int.TryParse(times, out timesTimes);
        if (30 * timesTimes <= cash)
        {
            cash -= 30 * timesTimes;
        }
        else if (30 * timesTimes > cash)
        {
            Console.WriteLine("DU ÄR FÖR FATTIG DIN JÄVLA BONDE");
        }
        

    }
    else if (choice.ToLower() == "bord")
    {
         Console.WriteLine("Hur många vill du köpa?");
        string times = Console.ReadLine();
        int.TryParse(times, out timesTimes);
        if (20 * timesTimes <= cash)
        {
            cash -= 20 * timesTimes;
        }
        else if (20 * timesTimes > cash)
        {
            Console.WriteLine("DU ÄR FÖR FATTIG DIN JÄVLA BONDE");
        }
    }
    else if (choice.ToLower() == "låda")
    {
         Console.WriteLine("Hur många vill du köpa?");
        string times = Console.ReadLine();
        int.TryParse(times, out timesTimes);
        if (10 * timesTimes <= cash)
        {
            cash -= 10 * timesTimes;
        }
        else if (10 * timesTimes > cash)
        {
            Console.WriteLine("DU ÄR FÖR FATTIG DIN JÄVLA BONDE");
        }
    }
}
Console.WriteLine("Tack för att du handlade");
Console.ReadLine();