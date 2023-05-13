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
    public partial class Form1 : Form
    {
        Panel Panel;
        Button addBtn;
        Button reload;
        Button search;
        Label name;
        Label address;
        Label phone;
        Label email;
        Label birthdate;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel = new Panel();
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(0, 0);
            Panel.BackColor = Color.White;

            name = new Label();
            name.Text = "Name";
            name.Location = new Point(90, 5);
            name.BackColor = Color.White;
            name.Font = new Font(this.Font, FontStyle.Bold);
            address = new Label();
            address.Text = "Address";
            address.Location = new Point(250, 5);
            address.BackColor = Color.White;
            address.Font = new Font(this.Font, FontStyle.Bold);
            phone = new Label();
            phone.Text = "Phone";
            phone.Location = new Point(410, 5);
            phone.BackColor = Color.White;
            phone.Font = new Font(this.Font, FontStyle.Bold);
            email = new Label();
            email.Text = "Email";
            email.Location = new Point(535, 5);
            email.Size = new Size(email.Text.Length * 12, email.Height);
            email.BackColor = Color.White;
            email.Font = new Font(this.Font, FontStyle.Bold);
            birthdate = new Label();
            birthdate.Text = "Birthdate";
            birthdate.Location = new Point(620, 5);
            birthdate.BackColor = Color.White;
            birthdate.Font = new Font(this.Font, FontStyle.Bold);
            base.BackColor = Color.White;
            this.Controls.Add(name);
            this.Controls.Add(address);
            this.Controls.Add(phone);
            this.Controls.Add(email);
            this.Controls.Add(birthdate);

            reload = new Button();
            reload.Size = new Size(100, 40);
            reload.Location = new Point(150, this.Height - 100);
            reload.Text = "Reload form";
            reload.Click += Reload_Click;
            this.Controls.Add(reload);

            addBtn = new Button();
            addBtn.Size = new Size(100, 40);
            addBtn.Location = new Point(300, this.Height - 100);
            addBtn.Text = "Add new contact";
            addBtn.Click += AddBtn_Click;
            this.Controls.Add(addBtn);

            search = new Button();
            search.Size = new Size(100, 40);
            search.Location = new Point(450, this.Height - 100);
            search.Text = "Search Contact";
            search.Click += search_Click;
            this.Controls.Add(search);
            this.Controls.Add(Panel);

            List<Contact> Contacts = new List<Contact>();
            Contacts = ReadData();
            ShowContact(Contacts);
        }

        private void search_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();
            newForm3.Deactivate += (s, ee) => { if (newForm3.data.Count>0) ShowContact(newForm3.data); else ShowContact(ReadData()); };
            
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            ShowContact(ReadData());
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            newForm.Deactivate += ((s, ee) => { ShowContact(ReadData()); });
        }

        private void ShowContact(List<Contact> Contacts)
        {
            Panel.Controls.Clear();
            int y = 0;
            for (int i = 0; i < Contacts.Count; i++)
            {
                var item = new ContactControl1(Contacts[i]);
                item.Location = new Point(30, (y * item.Height) + 30);
                item.BackColor = Color.White;
                item.BorderStyle = BorderStyle.FixedSingle;
                y++;
                Panel.Controls.Add(item);
            }
        }

        private List<Contact> ReadData()
        {
            string connStr = "Server=DESKTOP-MV43C0T;Database=Contacts;Trusted_Connection=True;TrustServerCertificate=True;";
            List<Contact> Contacts = new List<Contact>();
            string commandText = @"SELECT [Name],[Address],[Phone],[Email],[Birthdate] FROM [People];";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(commandText, conn);
                SqlDataReader reader = command.ExecuteReader();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        Contacts.Add(new Contact(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString()));
                    }
                    reader.NextResult();
                }
            }
            return Contacts;
        }
    }
}
