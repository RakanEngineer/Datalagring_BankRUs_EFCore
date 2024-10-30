using Datalagring_BankRUs_EFCore.Models;
using static System.Console;

namespace Datalagring_BankRUs_EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool shouldExit = false;

            while (!shouldExit)
            {
                WriteLine("1. Registrera kund");
                WriteLine("2. Visa kunder");
                WriteLine("3. Öppna konto");
                WriteLine("4. Visa kund");
                WriteLine("5. Avsluta");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        RegisterCustomer();

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        DisplayCustomers();

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        OpenAccount();

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        DisplayCustomer();

                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:

                        shouldExit = true;

                        break;
                }

                Clear();
            }
        }

        private static void RegisterCustomer()
        {
            bool isCorrect = false;

            do
            {
                Write("Förnamn: ");

                string firstName = ReadLine();

                Write("Efternamn: ");

                string lastName = ReadLine();

                Write("Personnummer: ");

                string socialSecurityNumber = ReadLine();

                Write("Gata: ");

                string street = ReadLine();

                Write("Ort: ");

                string city = ReadLine();

                Write("Postnummer: ");

                string postcode = ReadLine();

                WriteLine();

                WriteLine("Är detta korrekt? (J)a eller (N)ej");

                ConsoleKeyInfo keyPressed;

                bool isValidKey = false;

                do
                {
                    keyPressed = ReadKey(true);

                    isValidKey = keyPressed.Key == ConsoleKey.J ||
                                 keyPressed.Key == ConsoleKey.N;

                } while (!isValidKey);

                if (keyPressed.Key == ConsoleKey.J)
                {
                    // TODO: Implementera SaveCustomer(customer)

                }

                Clear();

            } while (!isCorrect);
        }

        private static void DisplayCustomers()
        {
            // TODO: Ersätt new List<Customer>() med lista av kunder som 
            // laddas in från database.

            List<Customer> customerList = new List<Customer>();

            Write("Namn".PadRight(20, ' '));
            WriteLine("Personnummer");
            WriteLine("------------------------------------------------");

            foreach (Customer customer in customerList)
            {
                string fullName = $"{customer.FirstName} {customer.LastName}";

                Write(fullName.PadRight(20, ' '));
                WriteLine(customer.SocialSecurityNumber);
            }

            ReadKey(true);
        }

        private static void OpenAccount()
        {
            // TODO: Implementera OpenAccount()
        }

        private static void SaveCustomer(Customer customer)
        {
            // TODO: Implementera SaveCustomer()
        }

        private static void DisplayCustomer()
        {
            // TODO: Implementera DisplayCustomer()
        }
    }
    
}
