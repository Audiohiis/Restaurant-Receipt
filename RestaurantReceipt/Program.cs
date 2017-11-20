using System;

namespace RestaurantReceipt
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double userInput = 0;
            double sum = 1;

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("------------------------------------------------");

            while (true)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                userInput = double.Parse(Console.ReadLine());
                sum += userInput;

                if (userInput == -1)
                {
                    Console.WriteLine("------------------------------------------------");
                    double gratuity = sum * 0.15;
                    double gratuitySum = sum - gratuity;
                    Console.WriteLine($"Subtotal: €{ sum }");
                    Console.WriteLine($"15.00 % Gratuity: €{ gratuity }");
                    Console.WriteLine($"Total: €{ gratuitySum }");
                    break;
                }
            }
        }
    }
}
