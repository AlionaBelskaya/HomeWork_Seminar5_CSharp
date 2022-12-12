// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
   int [] array = new int [size];
   for (int i = 0; i < size; i++)
   {
    array [i] = new Random().Next(minValue,maxValue+1);
   }
    return array;
}
int [] resultArray = GetArray(6, 100, 999);
Console.WriteLine($"Массив:[{string.Join("; ",resultArray)}]");

int GetCountElements (int [] inputArray)
{
int count = 0;
foreach (var item in inputArray)
{
 if (item%2==0)
 {
   count++; 
 }   
}
return count;
}
Console.WriteLine($"Количество четных элементов в массиве:{GetCountElements(resultArray)}");