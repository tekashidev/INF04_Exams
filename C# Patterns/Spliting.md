## Odzielanie i przypisywanie do tablicy

```csharp
Console.WriteLine("Podaj numery, po przecinku");
string foo = Console.ReadLine();
string[] tokens = foo.Split(',');
List<int> nums = new List<int>();
int oneNum;
foreach (string s in tokens)
{
    if (int.TryParse(s, out oneNum)) 
        nums.Add(oneNum);
}
```