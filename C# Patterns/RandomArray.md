## Tablica z randomowymi liczbami i sortowanie jej

```csharp
 static void Main(string[] args)
    {
        Random random = new Random();
        int[] randomizer = new int[100];
        int n = randomizer.Length;

        for (int i = 0; i < n; i++)
        {
            randomizer[i] = random.Next(1, 101); // Numbers between 1 and 100
        }
        Console.WriteLine("Nieposortowana tablica: ");
        Console.WriteLine(string.Join(", ", randomizer));

        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < n - 1; k++)
            {
                if (randomizer[k] > randomizer[k + 1])
                {
                    int temp = randomizer[k];
                    randomizer[k] = randomizer[k + 1];
                    randomizer[k + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nPosortowana tablica: ");
        Console.WriteLine(string.Join(", ", randomizer));

        Console.WriteLine($"\nTablice zawiera {n} elementów.");

    }
```
