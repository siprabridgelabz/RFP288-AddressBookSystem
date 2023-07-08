using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the  AddressBook program");
            ContactDetails contactDetails = new ContactDetails();
            contactDetails.details();
            Console.ReadLine();
        }
    }
}
