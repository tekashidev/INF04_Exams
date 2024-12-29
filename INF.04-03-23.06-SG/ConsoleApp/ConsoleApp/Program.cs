namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie obiektu
        Film film = new Film();
        
        // Test metody set
        Console.WriteLine("Podaj tytuł filmu (maks. 20 znaków):");
        string tytul = Console.ReadLine();
        film.SetTytul(tytul);

        // Test metody get
        Console.WriteLine($"Tytuł filmu: {film.GetTytul()}");

        // Test metody inkrementacji
        Console.WriteLine($"Liczba wypożyczeń przed inkrementacją: {film.GetWypozyczenia()}");
        film.InkrementujWypozyczenia();
        Console.WriteLine($"Liczba wypożyczeń po inkrementacji: {film.GetWypozyczenia()}");
    }
}