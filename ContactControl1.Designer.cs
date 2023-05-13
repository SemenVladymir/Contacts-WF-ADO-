namespace Contacts_WF_ADO_
{
    partial class ContactControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lName = new System.Windows.Forms.Label();
            this.lAddress = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lBirthdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(3, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(65, 16);
            this.lName.TabIndex = 0;
            this.lName.Text = "Full name";
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(198, 0);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(58, 16);
            this.lAddress.TabIndex = 1;
            this.lAddress.Text = "Address";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(447, 0);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(46, 16);
            this.lPhone.TabIndex = 2;
            this.lPhone.Text = "Phone";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(614, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(41, 16);
            this.lEmail.TabIndex = 3;
            this.lEmail.Text = "Email";

            // 
            // lBirthdate
            // 
            this.lBirthdate.AutoSize = true;
            this.lBirthdate.Location = new System.Drawing.Point(774, 0);
            this.lBirthdate.Name = "lBirthdate";
            this.lBirthdate.Size = new System.Drawing.Size(60, 16);
            this.lBirthdate.TabIndex = 4;
            this.lBirthdate.Text = "Birthdate";
            // 
            // ContactControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lBirthdate);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.lName);
            this.Name = "ContactControl1";
            this.Size = new System.Drawing.Size(866, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lBirthdate;
    }
}
