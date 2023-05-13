using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_WF_ADO_
{
    public partial class ContactControl1 : UserControl
    {
        public ContactControl1()
        {
            InitializeComponent();
        }

        public ContactControl1(Contact contact) : this()
        {
            this.lName.Text = contact.Name;
            this.lAddress.Text = contact.Address;
            this.lPhone.Text = contact.Phone;
            this.lEmail.Text = contact.Email;
            this.lBirthdate.Text = contact.Birthdate;
        }
    }
}
