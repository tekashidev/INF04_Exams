// See https://aka.ms/new-console-template for more information
int Year = 2025;
int Month = 01;
int Day = 06;
int CalcBirth = 0;
bool loop = true;

string TypeYear;
string TypeMonth;
string TypeDay;

Console.WriteLine("Podaj Rok");
TypeYear = Console.ReadLine();
Console.WriteLine("Podaj Miesiąc");
TypeMonth = Console.ReadLine();
Console.WriteLine("Podaj Dzień");
TypeDay = Console.ReadLine();

int ConvertYear = Convert.ToInt32(TypeYear);
int ConvertMonth = Convert.ToInt32(TypeMonth);
int ConvertDay = Convert.ToInt32(TypeDay);

while (loop)
{
    CalcBirth = Year - ConvertYear;
    if (Month < ConvertMonth)
    {
        CalcBirth--;
    }
    if (Day < ConvertDay)
    {
        Console.WriteLine(CalcBirth);
        loop = false;
    }
    else
    {
        Console.WriteLine(CalcBirth);
        loop = false;
        
    }
}