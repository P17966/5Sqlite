namespace _5Sqlite;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an option using number without . in the end:");
            Console.WriteLine("1. Add a new pet owner");
            Console.WriteLine("2. Add a new pet");
            Console.WriteLine("3. Update pet owner's phone number");
            Console.WriteLine("4. Search owner's phone number by pet's name");
            Console.WriteLine("5. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    TemporaryMethod();
                    break;
                case 2:
                    TemporaryMethod();
                    break;
                case 3:
                    TemporaryMethod();
                    break;
                case 4:
                    TemporaryMethod();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again. Use only numbers from 1 to 5 without . in the end.");
                    break;


            }
        }
    }
    static void TemporaryMethod()
    {
        Console.WriteLine("Temporary method");
    }
}
