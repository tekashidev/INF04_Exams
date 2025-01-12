## Algorytm sortowania O(N²)

```csharp
for (int i = 0; i < array.Length - 1; i++)
{
    int minIndex = i;

    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[minIndex])
        {
            minIndex = j;
        }
    }

    if (minIndex != i)
    {
        int temp = array[i];
        array[i] = array[minIndex];
        array[minIndex] = temp;
    }
}

Console.WriteLine("\nPosortowana tablica:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Element [{i}] wynosi: {array[i]}");
}

Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
Console.ReadLine();
```
