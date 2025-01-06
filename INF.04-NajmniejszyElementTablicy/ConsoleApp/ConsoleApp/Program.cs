// See https://aka.ms/new-console-template for more information
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

int x = nums[0];
int xIndex = 0;
for (int i = 1; i < nums.Count; i++)
{
    if (x > nums[i])
    {
        x = nums[i];
        xIndex = i;
    }
}


Console.WriteLine(x + "Indeks to: " + xIndex);