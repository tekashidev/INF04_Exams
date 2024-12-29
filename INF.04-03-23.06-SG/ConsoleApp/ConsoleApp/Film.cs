namespace ConsoleApp;

public class Film
{
    protected string tytul; // Zmienne chronione, by klasy potomne mogły mieć dostęp
    protected int wypozyczenia;

    // Konstruktor domyślny
    public Film()
    {
        tytul = "";
        wypozyczenia = 0;
    }

    // Setter dla tytułu
    public void SetTytul(string nowyTytul)
    {
        if (nowyTytul.Length <= 20)
        {
            tytul = nowyTytul;
        }
        else
        {
            Console.WriteLine("Tytuł nie może przekraczać 20 znaków!");
        }
    }

    // Getter dla tytułu
    public string GetTytul()
    {
        return tytul;
    }

    // Getter dla liczby wypożyczeń
    public int GetWypozyczenia()
    {
        return wypozyczenia;
    }

    // Metoda inkrementacji liczby wypożyczeń
    public void InkrementujWypozyczenia()
    {
        wypozyczenia++;
    }
}