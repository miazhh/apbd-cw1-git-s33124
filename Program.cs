Console.WriteLine("Podaj pierwszą liczbę:");
double liczba1 = double.Parse(Console.ReadLine());

Console.WriteLine("Podaj drugą liczbę:");
double liczba2 = double.Parse(Console.ReadLine());

double suma = liczba1 + liczba2;
double roznica = liczba1 - liczba2;

Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Różnica: {roznica}");