Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Summ(m, n);

void Summ(int m, int n)
{
    Console.Write(MtoN(m - 1, n));
}

int MtoN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + MtoN(m, n);
        return res;
    }
}