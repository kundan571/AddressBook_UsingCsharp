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
}
