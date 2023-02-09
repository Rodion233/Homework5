/* Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
int[] GenerateArray(int len = 8)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}
// int[] Inversion(int[] array)
// {
//     for (int i = 0; i < array.Length; i=i+2)
//     {
//         int sum =0;
//         sum += array[i];
//     }
//     return sum;
// }
int length = 10;
int[] array = new int[length];
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < length; i++) {
    array[i] = rnd.Next(1, 70);
    if (array[i] % 2 != 0) {
        sum += array[i];
    }
}
int ar =Convert.ToInt32(array);
System.Console.WriteLine(ar);
Console.WriteLine(sum);