Console.WriteLine("Podaj pierwszą liczbę:");
double liczba1 = double.Parse(Console.ReadLine());

Console.WriteLine("Podaj drugą liczbę:");
double liczba2 = double.Parse(Console.ReadLine());

double suma = liczba1 + liczba2;
double roznica = liczba1 - liczba2;

Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Różnica: {roznica}");

double iloczyn = liczba1 * liczba2;
Console.WriteLine($"Iloczyn: {iloczyn}");

if (liczba2 != 0)
{
    double iloraz = liczba1 / liczba2;
    Console.WriteLine($"Iloraz: {iloraz}");
}
else
{
    Console.WriteLine("Błąd: Nie można dzielić przez zero!");
}