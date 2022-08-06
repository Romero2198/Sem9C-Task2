Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = m;
Console.WriteLine($"M = {m}; N = {n} -> " + SumOfNaturalNumbers(n, m));

int SumOfNaturalNumbers(int m, int n)
{
    int max = m,
        min = n;
    if (min == max)
        return min;
    else
    {
        SumOfNaturalNumbers(max - 1, min);
        return sum += max;
    }
}