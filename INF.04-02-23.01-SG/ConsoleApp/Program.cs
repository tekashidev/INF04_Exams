namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Notatka notatka1 = new Notatka("Nazwa 1", "Nazwa 1");
        Notatka notatka2 = new Notatka("Nazwa 2", "Nazwa 2");
        
        notatka1.WypiszNotatke();
        notatka2.WypiszNotatke();
        notatka1.DiagnostykiNotatki();
        notatka2.DiagnostykiNotatki();
    }
}