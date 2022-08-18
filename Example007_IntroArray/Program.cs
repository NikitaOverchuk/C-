int maxNum(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if (arg2 > res) res = arg2;
    if (arg3 > res) res = arg3;
    return res;
}
int[] num = {-1, 2, 3, 0, 5, 6, 78, 8, 231};
int result = maxNum(
                    maxNum(num[0], num[1], num[2]), 
                    maxNum(num[3], num[4], num[5]), 
                    maxNum(num[6], num[7], num[8]));
Console.WriteLine(num);
Console.WriteLine(result);
