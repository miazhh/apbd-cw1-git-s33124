Console.WriteLine("KALKULATOR");
Console.WriteLine("Podaj liczbę:");
double liczba1 = double.Parse(Console.ReadLine());

Console.WriteLine("Podaj drugą liczbę:");
double liczba2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Suma: {Kalkulator.Suma(liczba1, liczba2)}");
Console.WriteLine($"Różnica: {Kalkulator.Roznica(liczba1, liczba2)}");
Console.WriteLine($"Iloczyn: {Kalkulator.Iloczyn(liczba1, liczba2)}");
if (liczba2 != 0)
{
    Console.WriteLine($"Iloraz: {Kalkulator.Iloraz(liczba1, liczba2)}");
}
else
{
    Console.WriteLine("Błąd: Nie można dzielić przez zero!");
}

public static class Kalkulator
{
    public static double Suma(double first, double second)
    {
        Console.WriteLine("Dodawanie");
        return first + second;
    }
    public static double Roznica(double a, double b)
    {
        return a - b;
    }

    public static double Iloczyn(double a, double b)
    {
        return a * b;
    }

    public static double Iloraz(double a, double b)
    {
        return a / b;
    }
    public static double Srednia(double a, double b)
    {
        return (a + b) / 2;
    }
    public static double Max(double a, double b)
    {
        return Math.Max(a, b);
    }

    public static double Min(double a, double b)
    {
        return Math.Min(a,b);
    }
}