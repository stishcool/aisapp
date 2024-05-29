namespace aisapp
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegister = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            label8 = new Label();
            txtPatronymic = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(300, 346);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 48);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Зарегистироваться";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(233, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(40, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(233, 23);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 147);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Почта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 232);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(284, 60);
            label3.Name = "label3";
            label3.Size = new Size(179, 32);
            label3.TabIndex = 5;
            label3.Text = "Регистрация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 232);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Адрес";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 147);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Телефон";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(284, 250);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(233, 23);
            txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(304, 171);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(213, 23);
            txtPhone.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(538, 232);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 13;
            label6.Text = "Фамилия";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(541, 147);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "Имя";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(538, 250);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(233, 23);
            txtSurname.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(538, 171);
            txtName.Name = "txtName";
            txtName.Size = new Size(233, 23);
            txtName.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(538, 296);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 15;
            label8.Text = "Отчество";
            // 
            // txtPatronymic
            // 
            txtPatronymic.Location = new Point(538, 314);
            txtPatronymic.Name = "txtPatronymic";
            txtPatronymic.Size = new Size(233, 23);
            txtPatronymic.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(284, 174);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 16;
            label9.Text = "+7";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtPatronymic);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnRegister);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Label label6;
        private Label label7;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label label8;
        private TextBox txtPatronymic;
        private Label label9;
    }
}