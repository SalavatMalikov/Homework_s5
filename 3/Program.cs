// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] array = new int [5];

int min = 100;
int max = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
    if (array[i]>max)
    {
        max=array[i];
    }
    if (array[i]<min)
    {
        min=array[i];
    }
}
Console.WriteLine(String.Join(",",array));
Console.WriteLine(max-min);

