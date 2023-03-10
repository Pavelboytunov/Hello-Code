//МЕТОД VOID

void FillArray (int[] collection) // аргумент collection
 {
    int length = collection.Length; //длина массива
    int index = 0;
    while (index < length) //цикл
   {
    collection[index] = new Random().Next(1,10); // в аргумент collection положить новое случайное число от 1 до 10
    index++;
   }
 }

void PrintArray(int[] col)
 {
    int count = col.Length; //длина массива
    int position = 0; 
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
 }

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];  //создай новый массив, в котором будет 10 элементов

FillArray(array); //заполнил массив
array[4] = 4;
array[6] = 4;
PrintArray(array); //распечатал массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);