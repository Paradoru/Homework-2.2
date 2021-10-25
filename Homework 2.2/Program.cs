using System;

namespace Homework_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите трехзначное число");
                var x = Convert.ToInt32(Console.ReadLine());//единицы
                int y = 0;//десятые
                int z = 0;//сотые
                if (x > 100 && x < 999)
                {
                    z = x / 100;
                    y = x / 10 % 10;
                    x %= 10;
                    if (x + y + z >= 10) Console.WriteLine("Сумма цифр - двузначное число");
                    else Console.WriteLine("Сумма цифр - не двузначное число");
                    if (x * y * z >= 100) Console.WriteLine("Произведение цифр - трёхзначное число");
                    else Console.WriteLine("Произведение цифр - не трёхзначное число");
                }
                else Console.WriteLine("Введите корректное число");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
