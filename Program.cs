namespace Swim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // работа выполненная на паре
            #region 1. Написать программу, которая находит среднее арифметическое значение из двух чисел.
            /*Console.Write("Введите первое число: ");
            int u = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое: {(u + y) / 2}");*/
            #endregion

            #region 2. Написать программу, которая находит корень линейного уравнения ax + b = 0.
            /*Console.Write("Введите коэффициент a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x = {b / a}");*/
            #endregion

            #region 3. Пользователь вводит число. Программа вычисляет 3-ю степень этого числа.
            /*Console.Write("Введите число для возведения в куб: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num}**3 = {num * num * num}");*/
            #endregion

            #region 4. Написать программу, которая  предлагает пользователю ввести радиус окружности  и считает площадь этой окружности. Число Pi задать в программе как константу.
            /*const double Pi = 3.14;
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double P = Pi * (r * r);
            Console.WriteLine($"Площадь окружноcти с радиусов {r} равна {P}");*/
            #endregion

            #region 5. Написать программу, которая  переводит доллары в гривны. Курс доллара задать в программе как константу.
            /*const double dollarRate = 39.1;
            Console.Write("Введите сумму в долларах: ");
            double dollars = Convert.ToDouble(Console.ReadLine());
            double hryvnias = dollars * dollarRate;
            Console.WriteLine("{0} долларов = {1} гривен", dollars, hryvnias);*/
            #endregion

            // работа выполненная дома
            #region 6. Написать программу, которая переводит сухопутные мили в километры. Одна миля – 1.609 км.
            /*const double oneMiles = 1.609;
            double kilometers;

            Console.WriteLine("Enter how many kilometers to convert to miles");
            do
            {
                Console.Write("> ");
                kilometers = Convert.ToDouble(Console.ReadLine());
            } while (kilometers <= 0);

            double miles = kilometers * oneMiles;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{kilometers} kilometers have {miles} miles");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

            #region 7. Написать программу, которая предлагает пользователю ввести год своего рождения и текущий год и в ответ показывает возраст пользователя.
            /*int birthYear;
            int currentYear;

            Console.WriteLine("Enter your year of birth");
            do
            {
                Console.Write("> ");
                birthYear = Convert.ToInt32(Console.ReadLine());
            } while (birthYear > 2023 || birthYear < 0);

            Console.WriteLine("Enter current year");
            do
            {
                Console.Write("> ");
                currentYear = Convert.ToInt32(Console.ReadLine());
            } while (currentYear > 2023 || currentYear < 0 || currentYear < birthYear);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"You are {currentYear - birthYear} years old");            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion.

            #region 8. Написать программу, которая находит процент P от суммы S.
            /*double S;
            double P;

            Console.WriteLine("Enter sum");
            do
            {
                Console.Write("> ");
                S = Convert.ToDouble(Console.ReadLine());
            } while (S <= 0);

            Console.WriteLine("Enter discount");
            do
            {
                Console.Write("> ");
                P = Convert.ToDouble(Console.ReadLine());
            } while (P <= 0 || P > 100);

            double resultSumWithDiscount = S * P / 100;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Result sum is {resultSumWithDiscount}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

            #region 9. Написать программу для определения диаметра окружности, которую можно получить из отрезка проволоки длиной Х (X задает пользователь).
            /*const double PI = 3.14;
            double length;
            double diameter;

            Console.WriteLine("Enter line segment");
            do
            {
                Console.Write("> ");
                length = Convert.ToDouble(Console.ReadLine());
            } while (length <= 0);

            diameter = length / PI;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Circumference length {length} with diameter {diameter}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

            #region 10. Пользователь трижды вводит достоинство купюр и их количество. Программа должна посчитать общую сумму денег.
            /*int sum = 0;

            int i = 0;
            while (++i <= 3)
            {
                Console.WriteLine($"{i}.");
                int denominationBanknote;
                Console.WriteLine("Enter the denomination of the banknote");
                do
                {
                    Console.Write("> ");
                    denominationBanknote = Convert.ToInt32(Console.ReadLine());
                } while (denominationBanknote <= 0 || denominationBanknote > 1000);

                int numberOfBanknotes;
                Console.WriteLine("Enter the number of banknotes");
                do
                {
                    Console.Write("> ");
                    numberOfBanknotes = Convert.ToInt32(Console.ReadLine());
                } while (numberOfBanknotes <= 0);

                sum += numberOfBanknotes * denominationBanknote;
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;           
            Console.WriteLine($"The total amount of money {sum}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;*/
            #endregion

        }
    }
}