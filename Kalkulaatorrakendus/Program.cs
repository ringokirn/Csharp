Console.WriteLine("Sisesta esimene arv:");
double arv1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Sisesta teine arv:");
double arv2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Sisesta tehe (+, -, *, /):");
char tehe = Convert.ToChar(Console.ReadLine());

double tulemus = 0;

if (tehe == '+')
{
    tulemus = arv1 + arv2;
}
else if (tehe == '-')
{
    tulemus = arv1 - arv2;
}
else if (tehe == '*')
{
    tulemus = arv1 * arv2;
}
else if (tehe == '/')
{
    tulemus = arv1 / arv2;
}
Console.WriteLine("Tulemus: " + tulemus);