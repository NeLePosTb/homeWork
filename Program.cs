bool isWork = true;

while (isWork)
{
    Console.Write("Введите номер задания: ");

    if (int.TryParse(Console.ReadLine(), out int i));
    {
        switch (i)
        {
            case 1:
            {
                Console.Write("Введите два числа: ");

                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.Write("Максимальное число = "); Console.WriteLine(Math.Max(a, b));
                Console.Write("Минимальное число = "); Console.WriteLine(Math.Min(a, b));
                break;
            }
            
            case 2:
            {
                Console.Write("Введите три числа: ");

                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                int[] Max = {a, b, c};

                Console.Write("Максимальное число = "); Console.WriteLine(Max.Max());
                break;
            }

            case 3:
            {
                Console.Write("Введите число: ");

                int a = int.Parse(Console.ReadLine());

                if (a%2 == 0)
                {
                    Console.WriteLine("число четное");
                }
                else Console.WriteLine("число нечетное");
                break;
            }

            case 4:
            {
                Console.Write("Введите число: ");

                int a = int.Parse(Console.ReadLine());
                int b = 1;

                while (a >= b)
                {
                    if (b%2 == 0)
                    {
                        Console.WriteLine(b);
                    }
                    b++;
                }
                break;
            }

            case -1: isWork = false; break;
        }
    }
}