using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Welcome");

            Console.WriteLine("\nEnter your name:");
            string name = Console.ReadLine();

            Console.WriteLine($"\nWelcome {name} to our store! Happy shopping!!");

            string[] productname = { "Laptop", "Phone", "Headphones" };
            int[] productprice = { 50000, 35000, 15000 };
            int[] productstock = { 10, 25, 45 };

            bool continueShopping = true;

            while (continueShopping)
            {
                Console.WriteLine("\nAvailable Products:");
                Console.WriteLine("  Name      Price    Quantity ");
                for (int i = 0; i < productname.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {productname[i]} - {productprice[i]} - {productstock[i]} in stock");
                }

                Console.WriteLine("\nEnter the number of the product you want to buy:");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input >= 1 && input <= 3)
                {
                    int index = input - 1;
                    Console.WriteLine($"\n{productname[index]} - Enter quantity:");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    if (quantity <= productstock[index])
                    {
                        Console.WriteLine($"Do you want to confirm purchase of {quantity} {productname[index]}? (Yes/No)");
                        string confirm = Console.ReadLine();

                        if (confirm.ToLower() == "yes")
                        {
                            Console.WriteLine("\nItem Purchased\nInvoice:");
                            Console.WriteLine($"Product: {productname[index]}");
                            Console.WriteLine($"Qty: {quantity}");
                            Console.WriteLine($"Price per piece: {productprice[index]}");
                            Console.WriteLine($"Grand Total: {productprice[index] * quantity}");

                            productstock[index] -= quantity;
                        }
                        else
                        {
                            Console.WriteLine("Purchase cancelled.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Quantity unavailable.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product selection.");
                }

                Console.WriteLine("\nDo you want to continue shopping? (Enter/Exit)");
                string decision = Console.ReadLine();

                if (decision.ToLower() == "exit")
                {
                    continueShopping = false;
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please check the format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nThanks for shopping with us. Bye!!!");
        }
    }
}
