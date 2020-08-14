using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_MailAddressBook
{
    class PersonEntry
    {
        public string Name { get; set;}
        public string lastName { get; set; }
        public string Email { get; set; }
        public string phoneNumber { get; set; }

        public PersonEntry()
        {
            this.Name = "";
            this.lastName = "";
            this.Email = "";
            this.phoneNumber = "";
        }

        public PersonEntry(string Name, string lastName, string Email, string phoneNumber)
        {
            this.Name = Name;
            this.lastName = lastName;
            this.Email = Email;
            this.phoneNumber = phoneNumber;
        }

    }
}
