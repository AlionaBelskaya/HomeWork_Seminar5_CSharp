// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] GetArray(int size, double minValue, double maxValue)
{
   double [] array = new double [size];
   Random rnd = new Random();
   for (int i = 0; i < size; i++)
   {
   array [i] = new Random().NextDouble();  
   }
    return array;
}
double [] resultArray = GetArray(5, -1, 1);
Console.WriteLine($"Массив:[{string.Join(" ", resultArray.Select(n => $"{n:F3}"))}]");

double DifferenceMinMax ()
{
double difference = 0;
int size = resultArray.Length;
double max = resultArray[0];
double min = resultArray[0];
for (int i = 0; i < size; i++)
{
    if (resultArray[i] < min)
    {
        min = resultArray[i];
    }
    else if (resultArray[i] > max)
    {
        max = resultArray[i];
    }
difference=max-min;
}
return difference;
}
double subtraction = DifferenceMinMax ();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива:" + Math.Round(subtraction, 3));