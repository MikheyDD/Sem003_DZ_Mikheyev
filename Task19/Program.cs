Console.WriteLine("Введите пятизначное число");
var num = Convert.ToInt32(Console.ReadLine());
if (num < 10000 || num > 99999)
{
    Console.WriteLine("Число не пятизначное");
}
else
{
    if (num % 10 == num / 10000 && num / 10 % 10 == num / 1000 % 10)
        {
            Console.WriteLine("Палиндром");
        }
    else 
    Console.WriteLine("Не палиндром");
}
