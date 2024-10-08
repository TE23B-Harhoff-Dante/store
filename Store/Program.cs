
using System.Data.SqlTypes;

bool success = false;
int ageNum = 0;
int cash = 100;
bool bad = false;

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

Console.WriteLine("Vad  vill du köpa?");
while (cash >= 0)
Console.WriteLine($"Du har {cash}pengar");
Console.WriteLine("1. hus(30) 2. bord(25) 3. låda(15)");


Console.ReadLine();