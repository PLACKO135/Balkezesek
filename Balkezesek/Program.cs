using Balkezesek;
using System.Numerics;
using System.Text;


List<Jatekosok> lista = new List<Jatekosok>();


StreamReader sr = new StreamReader("balkezesek.csv");
sr.ReadLine();
while (!sr.EndOfStream)
{
    lista.Add(new Jatekosok(sr.ReadLine()));
}
sr.Close();

//3.
Console.WriteLine($"3. feladat: {lista.Count}");

//4. 
Console.WriteLine($"4. feladat:");

lista.Where(x => x.Utolso.ToString("yyyy-MM").Contains("1999-10")).ToList().ForEach(x => Console.WriteLine($"\t{x.Nev} {Math.Round(x.Magassag * 2.54, 1)} cm"));
//5.
Console.WriteLine($"5. feladat:");

bool bennevan = false;
int kapottszam = 0;

while (bennevan == false)
{
    kapottszam = Convert.ToInt32(Console.ReadLine());
    if (kapottszam >= 1990 && kapottszam <= 1999)
    {
        bennevan = true;
        Console.WriteLine("Ügyes vagy:)");
    }
    else
    {
        Console.Write("Hibás adat kérek egy 1990 és 1999 közötti évszámot!:");
    }
}
//6. 
double OsszSuly = 0;
double Darab = 0;
for (int i = 0; i < lista.Count; i++)
{
    if (kapottszam >= lista[i].Elso.Year && kapottszam <= lista[i].Utolso.Year)
    {
        OsszSuly += lista[i].Suly;
        Darab++;
    }
}
double atlagsuly = OsszSuly / Darab;
Console.WriteLine($"6. feladat:{Math.Round(atlagsuly, 2)} font ");
