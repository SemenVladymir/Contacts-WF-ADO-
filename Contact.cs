using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts_WF_ADO_
{
    public class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Birthdate { get; set; }

        public Contact()
        {
            this.Name = string.Empty;
            this.Address = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.Birthdate = string.Empty;
        }
        public Contact(string name, string address, string phone, string email, string birthdate)
        {
            this.Name = name;
            this.Address = $"| {address}";
            this.Phone = $"| {phone}";
            this.Email = $"| {email}";
            this.Birthdate = $"| {birthdate}";
        }

        public override string ToString()
        {
            return $"|{Name}|{Address}|{Phone}|{Email}|{Birthdate}";
        }
    }
}
