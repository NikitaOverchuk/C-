void printArray(int[] c)
{
    int len = c.Length;
    int ind = 0;
    while (ind < len)
    {
        Console.Write(c[ind] + " ");
        ind++;
    }
}

void fillArray(int[] arg)
{
    int len = arg.Length;
    int i = 0;
    while (i < len)
    {
        arg[i] = new Random().Next(-10, 11);
        i++;
    }
}

int findP(int[] array, int find)
{
    int len = array.Length;
    int i = 0;
    int pos = -1;
    while (i < len)
    {
        if (array[i] == find)
        {
            pos = i;
            break;
        }
        i++;
    }
    return pos;
}

int[] num = new int[10];
fillArray(num);
printArray(num);
Console.WriteLine("");
Console.WriteLine(findP(num, 4));
