int maxNum(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if (arg2 > res) res = arg2;
    if (arg3 > res) res = arg3;
    return res;
}
int a1 = 33;
int a2 = 37;
int a3 = 95;

int b1 = 0;
int b2 = -7;
int b3 = 7;

int c1 = -3;
int c2 = 0;
int c3 = 93;

int result = maxNum(maxNum(a1, a2, a3), maxNum(b1, b2, b3), maxNum(c1, c2, c3));
Console.WriteLine(result);
