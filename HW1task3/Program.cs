namespace HW1task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            int a;


            Console.Write("Enter the side: ");
            int.TryParse(Console.ReadLine(), out a);


            int area = a * a;
            int perimeter = 4 * a;


            Console.WriteLine($"Area of the square: {area}");
            Console.WriteLine($"Perimeter of the square: {perimeter}");

            //task2

            string name;
            int age;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.Write($"How old are you, {name}? ");
            int.TryParse(Console.ReadLine(), out age);
            Console.Write($"{name}");
            Console.WriteLine($" {age} years old");


            //task3
            double r;
            Console.Write("Enter the radius: ");
            double.TryParse(Console.ReadLine(), out r);

            double length = 2 * Math.PI * r;
            double sArea = Math.PI * r * r;
            double volume = (4.0 / 3) * Math.PI * Math.Pow(r,3);

            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Area: {sArea}");
            Console.WriteLine($"Volume: {volume}");

        }
    }
}