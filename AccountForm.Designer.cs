namespace aisapp
{
    partial class AccountForm
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
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            txtPatronymic = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            btnSave = new Button();
            panel2 = new Panel();
            label2 = new Label();
            btnBack = new Button();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtPatronymic);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtSurname);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(12, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 346);
            panel3.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(400, 168);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 32;
            label9.Text = "+7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(522, 70);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 31;
            label8.Text = "Отчество";
            // 
            // txtPatronymic
            // 
            txtPatronymic.Location = new Point(522, 88);
            txtPatronymic.Name = "txtPatronymic";
            txtPatronymic.Size = new Size(233, 23);
            txtPatronymic.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(264, 70);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 29;
            label6.Text = "Фамилия";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 64);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 28;
            label7.Text = "Имя";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(264, 88);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(233, 23);
            txtSurname.TabIndex = 27;
            // 
            // txtName
            // 
            txtName.Location = new Point(17, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(233, 23);
            txtName.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 210);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 25;
            label4.Text = "Адрес";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(400, 141);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 24;
            label5.Text = "Телефон";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(17, 228);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(738, 23);
            txtAddress.TabIndex = 23;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(420, 165);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(210, 23);
            txtPhone.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(304, 18);
            label3.Name = "label3";
            label3.Size = new Size(119, 32);
            label3.TabIndex = 21;
            label3.Text = "Аккаунт";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 147);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 20;
            label1.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(153, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 23);
            txtPassword.TabIndex = 18;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(304, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 48);
            btnSave.TabIndex = 16;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnBack);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 74);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(17, 18);
            label2.Name = "label2";
            label2.Size = new Size(128, 33);
            label2.TabIndex = 4;
            label2.Text = "STC shop";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(670, 24);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "AccountForm";
            Text = "AccountForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Label label2;
        private Button btnBack;
        private Label label8;
        private TextBox txtPatronymic;
        private Label label6;
        private Label label7;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label label4;
        private Label label5;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Label label3;
        private Label label1;
        private TextBox txtPassword;
        private Button btnSave;
        private Label label9;
    }
}