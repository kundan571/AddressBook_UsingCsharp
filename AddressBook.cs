using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookFinal;

public class AddressBook
{
    private List<Contact> contactsList = new List<Contact>();
    public Contact AddContact()
    {
        Contact contact = new Contact();
        if (contactsList.Count == 0)
        {
            Console.WriteLine("Enter First Name:");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter ContactNumber:");
            contact.ContactNumber = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter City:");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State:");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip:");
            contact.Zip = Console.ReadLine();
            contactsList.Add(contact);
        }
        else
        {
            Console.WriteLine("Enter First Name:");
            contact.FirstName = Console.ReadLine();
            if (contactsList.Find(name => name.FirstName == contact.FirstName) != null)
            {
                Console.WriteLine("Name Exist");
                return null;
            }
            else
            {
                Console.WriteLine("Enter Last Name:");
                contact.LastName = Console.ReadLine();
                Console.WriteLine("Enter ContactNumber:");
                contact.ContactNumber = Console.ReadLine();
                Console.WriteLine("Enter Email:");
                contact.Email = Console.ReadLine();
                Console.WriteLine("Enter City:");
                contact.City = Console.ReadLine();
                Console.WriteLine("Enter State:");
                contact.State = Console.ReadLine();
                Console.WriteLine("Enter Zip:");
                contact.Zip = Console.ReadLine();
                contactsList.Add(contact);
            }
        }
        return contact;
    }
    public void DisplayContact()
    {
        foreach (Contact contact in contactsList)
        {
            Console.WriteLine($"First Name: {contact.FirstName}");
            Console.WriteLine($"Last Name: {contact.LastName}");
            Console.WriteLine($"Contact Number: {contact.ContactNumber}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"City: {contact.City}");
            Console.WriteLine($"State: {contact.State}");
            Console.WriteLine($"Zip: {contact.Zip}");
        }
    }

    public void EditContact()
    {
        Console.WriteLine("Enter the name you want to edit:");
        string editName = Console.ReadLine();
        foreach(Contact contact in contactsList)
        {
            if (contact.FirstName == editName)
            {
                Console.WriteLine("Enter the option you want to be update");
                Console.WriteLine("1: FirstName: \n2: LastNmae: \n3: ContactNumber: \n4:Email: \n5: City: \n6: State: \n7: Zip:");
                int menu = Convert.ToInt32( Console.ReadLine() );
                switch(menu)
                {
                    case 1:
                        Console.WriteLine("Enter the first name you want to update");
                        contact.FirstName = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the last name you want to update");
                        contact.LastName = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter the ContactNumber you want to update");
                        contact.ContactNumber = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter the Email you want to update");
                        contact.Email = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Enter the City you want to update");
                        contact.City = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Enter the State you want to update");
                        contact.State = Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Enter the Zip you want to update");
                        contact.Zip = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Enter the Correct input");
                        break;
                }
                Console.WriteLine("Contact is successfully updated");
            }
            else
            {
                Console.WriteLine("Entered name does not exist: Please Enter correct name:");
            }
        }
    }

    public void DeleteContact()
    {
        Console.WriteLine("Enter the first name of contact you want to delete:");
        string deleteName = Console.ReadLine();
        foreach(Contact contact in contactsList)
        {
            if (deleteName.Equals(contact.FirstName))
            {
                contactsList.Remove(contact);
                Console.WriteLine("Contact is successfully Deleted:");
                return;
            }
            else 
            {
                Console.WriteLine("Name does not exist: please enter the correct mane:");
            }
        }

    }
}
