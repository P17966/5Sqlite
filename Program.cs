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
                    AddNewPetOwner();
                    break;
                case 2:
                    AddNewPet();
                    break;
                case 3:
                    UpdatePetOwnerPhoneNumber();
                    break;
                case 4:
                    SearchOwnerPhoneNumberByPetName();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again. Use only numbers from 1 to 5 without . in the end.");
                    break;


            }
        }
    }
    /* Method for testing UI, if this was real app, this would be deleted before submission.
    static void TemporaryMethod()
    {
        Console.WriteLine("Temporary method");
    }*/
    static void AddNewPetOwner()
    {
        Console.WriteLine("Give pet owner's name:");
        string? name = Console.ReadLine();
        Console.WriteLine("Give pet owner's phone number:");
        string? phoneNumber = Console.ReadLine();
    }
    static void AddNewPet()
    {
        Console.WriteLine("Give pet's name:");
        string? petName = Console.ReadLine();
        Console.WriteLine("Give pet owner's ID");
        int ownerId = Convert.ToInt32(Console.ReadLine());
    }
    static void UpdatePetOwnerPhoneNumber()
    {
        Console.WriteLine("Give pet owner's ID");
        int ownerId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give new phone number");
        string? newPhoneNumber = Console.ReadLine();
    }
    static void SearchOwnerPhoneNumberByPetName()
    {
        Console.WriteLine("Give pet's name");
        string? petName = Console.ReadLine();
    }
}
