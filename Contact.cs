using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookFinal;

public class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }

    public Contact(string firstName, string lastName, string contactNumber, string email, string city, string state, string zip)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.ContactNumber = contactNumber;
        this.Email = email;
        this.City = city;
        this.State = state;
        this.Zip = zip;
    }

    public Contact() { }
}
