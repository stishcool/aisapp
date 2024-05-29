namespace aisapp
{
    partial class DatabaseForm
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
            txtServer = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDatabase = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            btnConnect = new Button();
            SuspendLayout();
            // 
            // txtServer
            // 
            txtServer.Location = new Point(133, 200);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(100, 23);
            txtServer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 182);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 182);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Database";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(280, 200);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(100, 23);
            txtDatabase.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 182);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(417, 200);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(548, 182);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(548, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 6;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(333, 256);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(122, 39);
            btnConnect.TabIndex = 8;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // DatabaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConnect);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(txtDatabase);
            Controls.Add(label1);
            Controls.Add(txtServer);
            Name = "DatabaseForm";
            Text = "DatabaseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtServer;
        private Label label1;
        private Label label2;
        private TextBox txtDatabase;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtPassword;
        private Button btnConnect;
    }
}