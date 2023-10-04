// void ArrrayOutput(int amount)
// {
//     int[] array = new int[amount];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.Write($"[{string.Join(",", array)}]");
// }

// int amount = Convert.ToInt32(Console.ReadLine());

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

int input = Convert.ToInt32(Console.ReadLine());

ArrrayOutput(input);
