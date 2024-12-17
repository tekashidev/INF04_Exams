namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Osoba osoba1 = new Osoba();
        Osoba osoba2 = new Osoba(1, "Jan");
        Osoba osoba3 = new Osoba(osoba2); // Konstruktor kopiujący

        // Wyświetlanie danych obiektów
        osoba1.Wyswietl();
        osoba2.Wyswietl();
        osoba3.Wyswietl();

    }
}