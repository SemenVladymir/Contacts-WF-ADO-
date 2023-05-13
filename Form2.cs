using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_WF_ADO_
{
    public partial class Form2 : Form
    {
        string name;
        string address;
        string phone;
        string email;
        string birthdate;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnOk.Click += AddContact_Click;
            btnCancel.Click += (s, ee) => { this.Close(); };
        }


        private void AddContact_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            address = txtAddress.Text;
            phone = txtPhone.Text;
            email = txtEmail.Text;
            birthdate = txtBirthdate.Text;
            if (name != "")
            {
                string connStr = "Server=DESKTOP-MV43C0T;Database=Contacts;Trusted_Connection=True;TrustServerCertificate=True;";
                string commandText = $@"INSERT INTO [People] ([Name],[Address],[Phone],[Email],[Birthdate]) VALUES ('{name}', '{address}', '{phone}', '{email}', '{birthdate}');";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(commandText, conn);
                    int count = command.ExecuteNonQuery();
                }
            }
            else
                MessageBox.Show("You need to fill out a form!");
            this.Close();
        }
    }
}
