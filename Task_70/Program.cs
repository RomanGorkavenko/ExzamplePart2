int a = 6;
int b = 10;
int n = 5;

Summa(a, b, n);

void Summa(int num, int num2, int length)
{
    if (length <= 0)
    {
        return;
    }
    Console.WriteLine(num);
    Summa(num2, num += num2, --length);
}

// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine(Summa(a, b, n));
// }

// int Summa(int num, int num2, int length)
// {
//     return length <= 0 ? Summa(num2, num += num2, --length) : 1;
    
// }
