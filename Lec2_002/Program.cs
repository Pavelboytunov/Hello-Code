/* Найти max из трех чисел (ФУНКЦИЯ)*/ 

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 12;
int b1 = 15;
int c1 = 122;
int a2 = 23;
int b2 = 2;
int c2 = 1;
int a3 = 145;
int b3 = 4565;
int c3 = 234;

int max1 = Max (a1, b1, c1);
int max2 = Max (a1, b1, c1);
int max3 = Max (a1, b1, c1);
int max = Max (max1, max2, max3);

Console.WriteLine(max);
