## Odchylenie Standardowe

```csharp
Console.WriteLine("Podaj liczby, po przecinku");
string foo = Console.ReadLine();
string[] tokens = foo.Split(',');
List<int> nums = new List<int>();
int oneNum;
foreach (string s in tokens)
{
    oneNum = int.Parse(s);
    nums.Add(oneNum);
}

int power = 0;
double sigma = 0;
int xi = 0;
int avg = 0;
int temp = 0;
int temp2 = 0;

for (int i = 0; i < nums.Count; i++)
{
    temp += nums[i];
    avg = temp / nums.Count;
}

Console.WriteLine("Średnia liczb wynosi: " + avg);

for (int i = 0; i < nums.Count; i++)
{
    temp2 = nums[i] - avg;
    power = temp2 * temp2;
    xi += power;
}

sigma = Math.Sqrt(xi / nums.Count);

Console.WriteLine("Odchylenie standardowe wynosi:" + sigma);
```
