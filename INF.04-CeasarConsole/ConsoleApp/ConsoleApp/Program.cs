// See https://aka.ms/new-console-template for more information
List<char> alfabet = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
string danetxt = "dane.txt";

var dane = File.ReadAllLines(danetxt);
int key = 3;
List<string> Odszyfrowane = new List<string>();


for(int i = 0; i < dane.Length; i++)
{
    
    string OdkodowaneZnaki = string.Empty;
    var slowo = dane[i].ToUpper();
    for (int j = 0; j < slowo.Length; j++)
    {
        int iAlfabet = alfabet.FindIndex(x => x == slowo[j]);
        if(iAlfabet >= 0)
        {
            if (iAlfabet - 3 < 0)
            {
                iAlfabet = (alfabet.Count() - 1) + iAlfabet - 3;

            } else
            {
                iAlfabet = iAlfabet-3;
            }
            var odkodowanyZnak = alfabet[iAlfabet];
            OdkodowaneZnaki += odkodowanyZnak;
        } else
        {
            OdkodowaneZnaki += slowo[j];
        }
    }
    Odszyfrowane.Add(OdkodowaneZnaki);
}

foreach(string s in Odszyfrowane)
{
    Console.WriteLine(s);
}
