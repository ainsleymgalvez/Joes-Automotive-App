using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Book
{
    class PersonEntry
    {
        // define strings
        public string Name;
        public string Email;
        public string Phone;

        public PersonEntry(string name, string email, string phone)
        {
            //convert them to variables

            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
