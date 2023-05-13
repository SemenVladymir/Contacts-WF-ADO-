using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Contacts_WF_ADO_
{
    public partial class Form3 : Form
    {
        public List <Contact> data = new List <Contact>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnOk.Click += Search_Click;
            btnCancel.Click += (s, ee) => { this.Close(); };
        }


        private void Search_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                string txtSearch = txtInput.Text;
                string connStr = "Server=DESKTOP-MV43C0T;Database=Contacts;Trusted_Connection=True;TrustServerCertificate=True;";
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
                            if (reader.GetValue(0).ToString().Contains(txtSearch) || reader.GetValue(1).ToString().Contains(txtSearch) || reader.GetValue(2).ToString().Contains(txtSearch)
                                || reader.GetValue(3).ToString().Contains(txtSearch) || reader.GetValue(4).ToString().Contains(txtSearch))
                                data.Add(new Contact(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString()));
                        }
                        reader.NextResult();
                    }
                }
                if (data.Count == 0)
                    MessageBox.Show("Data isn`t found!");
            }
            else
                MessageBox.Show("You need to input data!");
            this.Close();
        }
    }
}
