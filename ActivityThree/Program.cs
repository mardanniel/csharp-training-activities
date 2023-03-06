namespace ActivityThree
{
    class Program
    {
        static void Main(string[] args)
        {
            AsCases();
            // WithUserInput();

        }

        static void AsCases()
        {
            BasicCalculator basicCalculator = new BasicCalculator();
            int sum = basicCalculator.Sum(4, 2);
            int difference = basicCalculator.Difference(4, 2);
            int product = basicCalculator.Product(4, 2);
            int quotient = basicCalculator.Quotient(4, 2);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
        }

        static void WithUserInput()
        {
            BasicCalculator basicCalculator = new BasicCalculator();
            int operation, a, b;
            Console.WriteLine("Operation [1] Sum [2] Difference [3] Product [Quotient]: ");
            operation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            b = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Console.WriteLine($"Sum: {basicCalculator.Sum(a, b)}");
                    break;
                case 2:
                    Console.WriteLine($"Difference: {basicCalculator.Difference(a, b)}");
                    break;
                case 3:
                    Console.WriteLine($"Product: {basicCalculator.Product(a, b)}");
                    break;
                case 4:
                    Console.WriteLine($"Quotient: {basicCalculator.Quotient(a, b)}");
                    break;
                default:
                    Console.WriteLine("Invalid Operation.");
                    break;
            }
        }
    }

    class BasicCalculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Difference(int a, int b)
        {
            return a - b;
        }

        public int Product(int a, int b)
        {
            return a * b;
        }

        public int Quotient(int a, int b)
        {
            return a / b;
        }
    }
}