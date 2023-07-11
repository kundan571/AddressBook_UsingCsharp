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
            Console.WriteLine("Enter 3 To Edit Contact");
            Console.WriteLine("Enter 4 To Delete Contact:");
            Console.WriteLine("Enter 0 to Exit");

            try
            {
                string userInput = Console.ReadLine();
                choice = Convert.ToInt32(userInput);

                switch (choice)
                {
                    case 1:
                        addressBook.AddContact();
                        addressBook.WriteToFile();
                        break;
                    case 2:
                        addressBook.ReadFromFile();
                        addressBook.DisplayContact();
                        break;
                    case 3:
                        addressBook.ReadFromFile();
                        addressBook.EditContact();
                        addressBook.WriteToFile();
                        break;
                    case 4:
                        addressBook.ReadFromFile();
                        addressBook.DeleteContact();
                        addressBook.WriteToFile();
                        break;
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Custom exception caught:" + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}