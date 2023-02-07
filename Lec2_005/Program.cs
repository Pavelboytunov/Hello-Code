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

int[] array = new int[10];  //создай новый массив, в котором будет 10 элементов

FillArray(array); //заполнил массив
PrintArray(array); //распечатал массив
