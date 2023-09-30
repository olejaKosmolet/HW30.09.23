int SumOfNumber(int number)
{
    int result = 0;    
    while(number > 0)
    {
        result += number% 10;
        number/= 10;
    }
    return result;
}  

int InputNum (ref int number)
{
    Console.Write("Введите целое число: ");
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = 0;
int num = SumOfNumber(InputNum(ref number));
Console.WriteLine(num);