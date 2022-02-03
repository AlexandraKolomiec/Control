// Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int [] Array = new int [20];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1, 50); 
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();

int[] GenerateNewArray(int[]Array)
{
    int [] ResultArray = new int[Array(i)];
    int j = 0;
    for( int i = 0; i < Array.Length; i++)
    {
        if (Array [i] %2 == 0)
        {
            ResultArray[j] = Array[i];
            j++;
        }
        return ResultArray;
    }
}
int[] ResultArray = GenerateNewArray(Array);
Console.Write($"{ResultArray[j]} ");