namespace Lab1_Homework_Лепилкин_ISP_232
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            int d = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine(d + s);
            Console.WriteLine(d - s);
            Console.WriteLine(d * s);
            Console.WriteLine((double)d / s);

            // задание 2
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string lang = Console.ReadLine();
            Console.WriteLine($"Привет,{name}!");
            Console.WriteLine($"Тебе {age} лет.");
            Console.WriteLine($"Твой любимый язык - {lang}");

            // задание 3
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int x = 5;
            Console.WriteLine($"f(5) = {a * x * x + b * x + c}");

            // задание 4
            Console.Write("Введите ваше имя: ");
            string name1 = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            int age1 = int.Parse(Console.ReadLine());
            Console.Write("Введите ваш город: ");
            string city = Console.ReadLine();
            Console.Write("Введите ваше любимое число: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Введите температуру в °C: ");
            int temp = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("=== ПЕРСОНАЛЬНЫЙ ПРОФИЛЬ ===");
            Console.WriteLine();
            Console.WriteLine($"Привет,{name1}!");
            Console.WriteLine($"Тебе {age1} лет.");
            Console.WriteLine($"В следующем году тебе будет {age1 + 1}.");

            Console.WriteLine();

            Console.WriteLine($"Ты живешь в городе {city}.");
            Console.WriteLine($"Твое любимое число: {num} (в квадрате: {num * num})");

            Console.WriteLine();

            Console.WriteLine("Температура за окном:");
            Console.WriteLine($"- В Цельсиях: {temp}°C");
            Console.WriteLine($"- В Фаренгейтах: {(temp * 9 / 5) + 32}°F");

            Console.WriteLine();

            Console.WriteLine("=== КОНЕЦ ПРОФИЛЯ ===");




        }
    }
}
