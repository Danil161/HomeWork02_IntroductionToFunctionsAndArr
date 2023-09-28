//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int n)
{
    while (n > 999)
    {
        n /= 10;
    }
    return n % 10;
}

bool ValidateNumber(int n)
{
    if (n < 100)
    {
        Console.WriteLine("Третьей цифры нет!");
        return false;
    }
    return true;
}

int n = Prompt("Введите число = ");
if (ValidateNumber(n))
{
    Console.WriteLine(GetThirdRank(n));
}