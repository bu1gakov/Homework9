Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
DescendingNumber(number, count);


void DescendingNumber(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        DescendingNumber(n, count + 1);
        Console.Write(count + " ");
    }
}