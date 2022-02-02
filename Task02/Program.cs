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

void FormatedArray(int[]array)
{
    for (int count = 0; count < array.Length; count++)
    {
        if (array[count] %2 == 0)
        {
            Console.Write($"{array[count]} ");
        }
    }
}
FormatedArray(Array);