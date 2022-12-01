namespace Calculator;

internal class Program
{
    static void Main()
    {
        int userSelect;
        Console.WriteLine(
            "Выберите действие: 1 - Сложение,\n 2 - Вычитание,\n 3 - Умножение,\n 4 - Деление,\n 5 - Возвести в степень,\n " +
            "6 - Найти квадратный корень из числа,\n 7 - Найти 1% числа,\n 8 - Найти факториал,\n 9 - Выйти из программы");
        int totalNumber;
        string user = Console.ReadLine();
        userSelect = Convert.ToInt32(user);

        if (userSelect < 6)
        {
            Console.WriteLine("Введите первое число: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (userSelect == 1)
            {
                totalNumber = numberOne + numberTwo;
                Console.WriteLine($"Ответ: {totalNumber}");
            }

            if (userSelect == 2)
            {
                totalNumber = numberOne - numberTwo;
                Console.WriteLine($"Ответ: {totalNumber}");
            }

            if (userSelect == 3)
            {
               totalNumber = numberOne * numberTwo;
                Console.WriteLine($"Ответ: {totalNumber}");
            }

            if (userSelect == 4)
            {
               totalNumber = numberOne / numberTwo;
                Console.WriteLine($"Ответ: {totalNumber}");
            }

            if (userSelect == 4)
            {
                totalNumber = (int)Math.Pow(numberOne, numberTwo);
            }

            if (userSelect == 5)
            {
                totalNumber = (int)Math.Pow(numberOne, numberTwo);
                Console.WriteLine($"Ответ: {totalNumber}");
            }
            Main();
        }

        if (userSelect >= 6)
        {
            if (userSelect == 9)
            {
                Environment.Exit(0);
            }
            
            int numberSelect;
            Console.WriteLine("Введите число: ");
            numberSelect = Convert.ToInt32(Console.ReadLine());
            
            if (userSelect == 6)
            {
                totalNumber = (int)Math.Sqrt(numberSelect);
                Console.WriteLine($"Ответ: {totalNumber}");
            }

            if (userSelect == 7)
            {
                totalNumber = numberSelect / 100;
                Console.WriteLine($"Ответ: {totalNumber}");
            }

            if (userSelect == 8)
            {
                int cycle = 1;
                for (int x = 1; x <= numberSelect; numberSelect++)
                {
                    cycle = cycle * numberSelect;
                }
                Console.WriteLine($"Ответ: {cycle}");
            }
            Main();
        }
    }
}