namespace C_Sharp_Basics
{
    internal class Program
    {
        static MenuItems[] items = new MenuItems[] {
            new MenuItems(
                delegate () {
                    try {
                        Console.WriteLine("Input a number that you whan to add 1:");
                        Console.WriteLine(Int32.Parse(Console.ReadLine()) + 1);
                    } catch {
                        Console.WriteLine("Try to input a valid format");
                    }
                },
               "Next Number"
            ),
            new MenuItems(
                delegate () {
                    try {
                        Double number = (Double)(new Random()).Next(1, 200);
                        Console.WriteLine($"Your random number is: {number}");
                        Console.WriteLine($"if we add 30% the result is: {number + number*0.3}");
                    } catch {
                        Console.WriteLine("Try to input a valid format");
                    }
                },
                "Add 30 percentage to random number"
            ),
            new MenuItems(
                delegate () {
                    try {
                        Console.WriteLine("Input the height of the rectangle:");
                        Double height = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Input the width of the rectangle:");
                        Double width = Double.Parse(Console.ReadLine());
                        Console.WriteLine($"The area of the rectangle is: {height * width}");
                        Console.WriteLine($"The perimeter of the rectangle is: {height * 2 + width * 2}");
                    } catch {
                        Console.WriteLine("Try to input a valid format");
                    }
                },
                "Calculate the perimeter and area"
            ),
            new MenuItems(
                delegate () {
                    Environment.Exit(0);
                },
                "Close the program"
            )
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                Selector();
            }
        }

        static void Menu()
        {
            Console.WriteLine("Select a option to execute:");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].message}");
            }

        }

        static void Selector()
        {
            Console.WriteLine("Input your option here:");
            string input = Console.ReadLine();
            for (int i = 0; i < items.Length; i++)
            {
                if (Int32.Parse(input.Trim()) == (i + 1))
                {
                    Console.WriteLine($"Your selection as {i + 1}. {items[i].message}");
                    items[i].process();
                    Console.WriteLine("Press any number to continue");
                    Console.ReadLine();
                }
            }
        }
    }
}