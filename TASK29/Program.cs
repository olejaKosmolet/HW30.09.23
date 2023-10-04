// void ArrrayOutput(int amount)
// {
//     int[] array = new int[amount];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.Write($"[{string.Join(",", array)}]");
// }
// Console.Write("Введите количество элементов массива: ");
// int amount = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Заполните массив: ");
// ArrrayOutput(amount);

void ArrrayOutput(int amount)
{
    int[] array = new int[amount];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    Console.Write($"[{string.Join(",", array)}]");
}
Console.Write("Введите количество элементов массива: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.Write($"Получите массив количество которого {input} элементов: \n");
ArrrayOutput(input);
