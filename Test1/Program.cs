Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string num1 = num.ToString();
if(num > 9999 || num < 100000)
{
    if((num.ToString()[0] == num.ToString()[4]) && (num.ToString()[1] == num.ToString()[3]))
    {
        Console.WriteLine("Число является полиндромом");
    }
    else
    {
        Console.WriteLine("Число не является полиндромом");
    }
}
