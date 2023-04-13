namespace lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Show_Cars();
        }

        public static void Show_Cars()
        {
            int choice;
            Automobile car;
            do
            {
                Console.Write("Enter which car to show(BMW - 1, Audi - 2, Hyundai - 3): ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        car = new BMW_X5();
                        Console.WriteLine($"Car's name: {car.name}");
                        Console.WriteLine($"Car's mark: {car.mark}");
                        Console.WriteLine($"Car's type: {car.type}");
                        Console.WriteLine($"Car's engine capacity: {car.engine_capacity}");
                        break;
                    case 2:
                        car = new Audi_A8();
                        Console.WriteLine($"Car's name: {car.name}");
                        Console.WriteLine($"Car's mark: {car.mark}");
                        Console.WriteLine($"Car's type: {car.type}");
                        Console.WriteLine($"Car's engine capacity: {car.engine_capacity}");
                        break;
                    case 3:
                        car = new Hyundai_Solaris();
                        Console.WriteLine($"Car's name: {car.name}");
                        Console.WriteLine($"Car's mark: {car.mark}");
                        Console.WriteLine($"Car's type: {car.type}");
                        Console.WriteLine($"Car's engine capacity: {car.engine_capacity}");
                        break;
                }
                Console.WriteLine();
            } while (choice != 0);
        }
    }
}