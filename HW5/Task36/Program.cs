// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
   int [] array = new int [size];
   for (int i = 0; i < size; i++)
   {
    array [i] = new Random().Next(minValue,maxValue+1);
   }
    return array;
}
int [] resultArray = GetArray(4, -100, 100);
Console.WriteLine($"Массив:[{string.Join("; ",resultArray)}]");

int GetSumElementsOddIndex ()
{
int sum = 0;
for (int i = 0; i < resultArray.Length; i++)
{
    if (i%2==1)
    {
        sum=sum + resultArray[i];
    }
}
return sum;
}
int amount = GetSumElementsOddIndex();
Console.WriteLine($"Сумма элементов с нечетными индексами в массиве:{GetSumElementsOddIndex()}");