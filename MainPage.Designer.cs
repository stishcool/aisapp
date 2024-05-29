namespace aisapp
{
    partial class MainPage
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
            btnLogin = new Button();
            btnRegistration = new Button();
            panel1 = new Panel();
            btnDatabase = new Button();
            lblCategoryLaptops = new Label();
            lblCategoryComputers = new Label();
            lblCategorySmartphones = new Label();
            lblCategoryTelevisors = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            pBoxSale = new PictureBox();
            panel4 = new Panel();
            label11 = new Label();
            pictureBox6 = new PictureBox();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxSale).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(589, 25);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.Location = new Point(670, 25);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(90, 23);
            btnRegistration.TabIndex = 1;
            btnRegistration.Text = "Регистрация";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnDatabase);
            panel1.Controls.Add(lblCategoryLaptops);
            panel1.Controls.Add(lblCategoryComputers);
            panel1.Controls.Add(lblCategorySmartphones);
            panel1.Controls.Add(lblCategoryTelevisors);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(138, 346);
            panel1.TabIndex = 2;
            // 
            // btnDatabase
            // 
            btnDatabase.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDatabase.Location = new Point(3, 319);
            btnDatabase.Name = "btnDatabase";
            btnDatabase.Size = new Size(65, 21);
            btnDatabase.TabIndex = 5;
            btnDatabase.Text = "database";
            btnDatabase.UseVisualStyleBackColor = true;
            btnDatabase.Click += btnDatabase_Click;
            // 
            // lblCategoryLaptops
            // 
            lblCategoryLaptops.AutoSize = true;
            lblCategoryLaptops.Location = new Point(18, 170);
            lblCategoryLaptops.Name = "lblCategoryLaptops";
            lblCategoryLaptops.Size = new Size(60, 15);
            lblCategoryLaptops.TabIndex = 4;
            lblCategoryLaptops.Text = "Ноутбуки";
            lblCategoryLaptops.Click += lblCategoryLaptops_Click;
            // 
            // lblCategoryComputers
            // 
            lblCategoryComputers.AutoSize = true;
            lblCategoryComputers.Location = new Point(17, 137);
            lblCategoryComputers.Name = "lblCategoryComputers";
            lblCategoryComputers.Size = new Size(80, 15);
            lblCategoryComputers.TabIndex = 3;
            lblCategoryComputers.Text = "Компьютеры";
            lblCategoryComputers.Click += lblCategoryComputers_Click;
            // 
            // lblCategorySmartphones
            // 
            lblCategorySmartphones.AutoSize = true;
            lblCategorySmartphones.Location = new Point(18, 101);
            lblCategorySmartphones.Name = "lblCategorySmartphones";
            lblCategorySmartphones.Size = new Size(74, 15);
            lblCategorySmartphones.TabIndex = 2;
            lblCategorySmartphones.Text = "Смартфоны";
            lblCategorySmartphones.Click += lblCategorySmartphones_Click;
            // 
            // lblCategoryTelevisors
            // 
            lblCategoryTelevisors.AutoSize = true;
            lblCategoryTelevisors.Location = new Point(18, 65);
            lblCategoryTelevisors.Name = "lblCategoryTelevisors";
            lblCategoryTelevisors.Size = new Size(67, 15);
            lblCategoryTelevisors.TabIndex = 1;
            lblCategoryTelevisors.Text = "Телвизоры";
            lblCategoryTelevisors.Click += lblCategoryTelevisors_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Категории";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnRegistration);
            panel2.Controls.Add(btnLogin);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 74);
            panel2.TabIndex = 3;
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(pBoxSale);
            panel3.Location = new Point(156, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(632, 146);
            panel3.TabIndex = 4;
            // 
            // pBoxSale
            // 
            pBoxSale.Image = Properties.Resources.SalePhones;
            pBoxSale.Location = new Point(0, 0);
            pBoxSale.Name = "pBoxSale";
            pBoxSale.Size = new Size(632, 146);
            pBoxSale.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSale.TabIndex = 0;
            pBoxSale.TabStop = false;
            pBoxSale.Click += pBoxSale_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(pictureBox6);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(156, 244);
            panel4.Name = "panel4";
            panel4.Size = new Size(632, 194);
            panel4.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(192, 9);
            label11.Name = "label11";
            label11.Size = new Size(233, 25);
            label11.TabIndex = 5;
            label11.Text = "Популярные категории";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.LaptopIcon;
            pictureBox6.Location = new Point(487, 53);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(117, 108);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(487, 173);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 6;
            label9.Text = "Ноутбуки";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.PCIcon1;
            pictureBox5.Location = new Point(335, 53);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(117, 108);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(335, 173);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 4;
            label8.Text = "Компьютеры";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.SmartphoneIcon;
            pictureBox4.Location = new Point(183, 53);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(117, 108);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(183, 173);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 2;
            label7.Text = "Смартфоны";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.TVIcon;
            pictureBox3.Location = new Point(30, 53);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 108);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 173);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 0;
            label6.Text = "Телевизоры";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainPage";
            Text = "MainPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBoxSale).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnRegistration;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label lblCategoryComputers;
        private Label lblCategorySmartphones;
        private Label lblCategoryTelevisors;
        private Panel panel3;
        private PictureBox pBoxSale;
        private Panel panel4;
        private Label lblCategoryLaptops;
        private Label label11;
        private PictureBox pictureBox6;
        private Label label9;
        private PictureBox pictureBox5;
        private Label label8;
        private PictureBox pictureBox4;
        private Label label7;
        private PictureBox pictureBox3;
        private Label label6;
        private Button btnDatabase;
    }
}