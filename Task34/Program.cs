// Task 34. Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных 
// чисел в массиве. [345, 897, 568, 234] -> 2


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99, 1000);
}

int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i] % 2 != 0)
            count++;
    }
    return count;
}
Console.Clear();
Console.Write("Введите колличество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write(CountNumber(array));