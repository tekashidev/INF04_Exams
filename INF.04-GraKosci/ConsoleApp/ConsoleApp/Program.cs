using System;

class GraWKosci
{
    static void Main(string[] args)
    {
        bool grajPonownie = true;

        while (grajPonownie)
        {
            // Punkt 1: Pobranie liczby kostek od użytkownika
            int liczbaKostek = 0;
            while (liczbaKostek < 3 || liczbaKostek > 10)
            {
                Console.WriteLine("Podaj liczbę kostek do rzucenia (od 3 do 10):");
                liczbaKostek = int.Parse(Console.ReadLine());
            }

            // Punkt 2: Rzuty kostkami
            int[] wyniki = new int[liczbaKostek];
            Random random = new Random();
            for (int i = 0; i < liczbaKostek; i++)
            {
                wyniki[i] = random.Next(1, 7);
            }

            // Punkt 3: Wyświetlenie wyników rzutów
            for (int i = 0; i < liczbaKostek; i++)
            {
                Console.WriteLine("Kostka " + (i + 1) + ": " + wyniki[i]);
            }

            // Punkt 4: Liczenie punktów
            int sumaPunktow = 0;
            for (int i = 1; i <= 6; i++) // Sprawdzamy każdą możliwą wartość kostki (od 1 do 6)
            {
                int licznik = 0;
                for (int j = 0; j < wyniki.Length; j++) // Liczymy, ile razy dana wartość wystąpiła
                {
                    if (wyniki[j] == i)
                    {
                        licznik++;
                    }
                }
                if (licznik >= 2) // Jeśli wartość wystąpiła co najmniej 2 razy, dodajemy jej sumę do punktów
                {
                    sumaPunktow += i * licznik;
                }
            }

            Console.WriteLine("Suma punktów: " + sumaPunktow);

            // Punkt 5: Pytanie o ponowną grę
            Console.WriteLine("Czy chcesz zagrać ponownie? (t/n):");
            string odpowiedz = Console.ReadLine().ToLower();
            if (odpowiedz != "t")
            {
                grajPonownie = false;
            }
        }

        Console.WriteLine("Dziękujemy za grę!");
    }
}
