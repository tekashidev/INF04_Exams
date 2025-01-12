## Konstruktory itd.

```csharp
public class Osoba
{
    public int liczbaInstacji = 0;

    public int id = 0;
    public string imie = "";

    //Konstruktor bezparametrowy
    public Osoba()
    {
        liczbaInstacji = 0;
        id = 0;
        imie = "";
    }

    //Konstruktor z dwoma parametrami
    public Osoba(int id, string imie)
    {
        this.id = id;
        this.imie = imie;
        liczbaInstacji++;
    }

    //Konstruktor kopiujący
    public Osoba(Osoba copy_osoba)
    {
        if (copy_osoba == null)
        {
            id = copy_osoba.id;
            imie = copy_osoba.imie;
            liczbaInstacji++;
        }
    }

    public void Wyswietl()
    {
        Osoba osoba = new Osoba(id, imie);
        if (osoba.id == 0)
        {
            Console.WriteLine("Brak danych");
        }
        else
        {
            Console.WriteLine($"Id: {id}, Imie: {imie}");
        }
    }
}
```
