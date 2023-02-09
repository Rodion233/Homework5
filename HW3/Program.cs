/* Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int InputInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
double[] GenerateArray(int len)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}
void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}
double MaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>max)
        {
            max = array[i];
        }
    }
    return max;
}
double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<min)
        {
            min = array[i];
        }
    }
    return min;
}
int len = InputInt("Введите длину массива");
double[] array = GenerateArray(len);
PrintArray(array);
double maxelement = MaxElement(array);
double minelement = MinElement(array);
double raznica = maxelement-minelement;
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {raznica}");