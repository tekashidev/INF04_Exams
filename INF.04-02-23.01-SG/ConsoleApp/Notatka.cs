namespace ConsoleApp;

public class Notatka
{
    public static int LiczbaNotatek = 0;
    public int id;
    public string nazwaNotatki;
    public string trescNotatki;

    public Notatka(string nazwaNotatki, string trescNotatki)
    {
        LiczbaNotatek++;
        id = LiczbaNotatek;
        this.nazwaNotatki = nazwaNotatki;
        this.trescNotatki = trescNotatki;
    }

    public void WypiszNotatke()
    {
        Console.WriteLine("Nazwa Notatki: " + nazwaNotatki + "Treść Notatki: " + trescNotatki);
    }

    public void DiagnostykiNotatki()
    {
        Console.WriteLine(LiczbaNotatek + "; " + id + "; " + nazwaNotatki + "; " + trescNotatki);
    }
    
    
}