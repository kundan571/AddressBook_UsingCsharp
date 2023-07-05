namespace AddressBookFinal;

internal class Program
{
    static void Main(string[] args)
    {
        AddressBook addressBook = new AddressBook();
        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("Enter 1 To Add Contact:");
            Console.WriteLine("Enter 2 To Display Contact");
            Console.WriteLine("Enter 0 to Exit");
            string userInput = Console.ReadLine();
            choice = Convert.ToInt32(userInput);

            switch (choice)
            {
                case 1:
                    addressBook.AddContact();
                    break;
                case 2:
                    addressBook.DisplayContact();
                    break;
            }
        }
    }
}