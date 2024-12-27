namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        int n = 100;
        bool[] czyPierwsza = new bool[n + 1];
        
        inicjalizacjaLiczbPierwszych(czyPierwsza);
        Console.WriteLine("Przedział liczb pierwszych między 2 i n: ");
        wyswietlLiczbyPierwsze(czyPierwsza);
    }

    static void inicjalizacjaLiczbPierwszych(bool[] czyPierwsza)
    {
        for (int i = 0; i < czyPierwsza.Length; i++)
        {
            czyPierwsza[i] = true;
        }

        for (int p = 2; p * p <= czyPierwsza.Length; p++)
        {
            if (czyPierwsza[p])
            {
                for (int i = p * p; i <= czyPierwsza.Length - p; i++)
                {
                    czyPierwsza[i] = false;
                }
            }
        }
    }

    static void wyswietlLiczbyPierwsze(bool[] czyPierwsza)
    {
        for (int i = 2; i < czyPierwsza.Length; i++)
        {
            Console.Write(i + (i < czyPierwsza.Length - 1 ? ", " : ""));
        }
        Console.WriteLine();
    }
}