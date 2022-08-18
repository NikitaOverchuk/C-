int[] num = {1, 2, 3, 4 ,5, 6, 7, 8, 9};
int i = 0;
int len = num.Length;
int find = 8;
while (i < len)
{
    if (num[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    i++;
}
