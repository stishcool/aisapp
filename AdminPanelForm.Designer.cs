namespace aisapp
{
    partial class AdminPanelForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmBoxProductDelete = new ComboBox();
            cmBoxCategoryDelete = new ComboBox();
            numUDDelete = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmBoxProductAdd = new ComboBox();
            cmBoxCategoryAdd = new ComboBox();
            numUDAdd = new NumericUpDown();
            btnDelete = new Button();
            btnAdd = new Button();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            dataGridViewSearch = new DataGridView();
            btnSearch = new Button();
            txtSearchName = new TextBox();
            label7 = new Label();
            checkBoxName = new CheckBox();
            checkBoxSurname = new CheckBox();
            label8 = new Label();
            txtSearchSurmane = new TextBox();
            label9 = new Label();
            txtDeleteUser = new TextBox();
            btnDeleteUser = new Button();
            richTextBoxUserShow = new RichTextBox();
            btnShow = new Button();
            label10 = new Label();
            txtShow = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUDDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDAdd).BeginInit();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Добавление товаров";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(cmBoxProductDelete);
            panel3.Controls.Add(cmBoxCategoryDelete);
            panel3.Controls.Add(numUDDelete);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cmBoxProductAdd);
            panel3.Controls.Add(cmBoxCategoryAdd);
            panel3.Controls.Add(numUDAdd);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnAdd);
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(756, 386);
            panel3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 219);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 35;
            label4.Text = "Кол-во";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(233, 219);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 34;
            label5.Text = "Товар";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 219);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 33;
            label6.Text = "Категория";
            // 
            // cmBoxProductDelete
            // 
            cmBoxProductDelete.FormattingEnabled = true;
            cmBoxProductDelete.Location = new Point(233, 234);
            cmBoxProductDelete.Name = "cmBoxProductDelete";
            cmBoxProductDelete.Size = new Size(121, 23);
            cmBoxProductDelete.TabIndex = 32;
            // 
            // cmBoxCategoryDelete
            // 
            cmBoxCategoryDelete.FormattingEnabled = true;
            cmBoxCategoryDelete.Location = new Point(95, 235);
            cmBoxCategoryDelete.Name = "cmBoxCategoryDelete";
            cmBoxCategoryDelete.Size = new Size(121, 23);
            cmBoxCategoryDelete.TabIndex = 31;
            // 
            // numUDDelete
            // 
            numUDDelete.Location = new Point(389, 235);
            numUDDelete.Name = "numUDDelete";
            numUDDelete.Size = new Size(120, 23);
            numUDDelete.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 116);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 29;
            label3.Text = "Кол-во";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 116);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 28;
            label2.Text = "Товар";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 116);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 27;
            label1.Text = "Категория";
            // 
            // cmBoxProductAdd
            // 
            cmBoxProductAdd.FormattingEnabled = true;
            cmBoxProductAdd.Location = new Point(233, 131);
            cmBoxProductAdd.Name = "cmBoxProductAdd";
            cmBoxProductAdd.Size = new Size(121, 23);
            cmBoxProductAdd.TabIndex = 26;
            // 
            // cmBoxCategoryAdd
            // 
            cmBoxCategoryAdd.FormattingEnabled = true;
            cmBoxCategoryAdd.Location = new Point(95, 132);
            cmBoxCategoryAdd.Name = "cmBoxCategoryAdd";
            cmBoxCategoryAdd.Size = new Size(121, 23);
            cmBoxCategoryAdd.TabIndex = 25;
            // 
            // numUDAdd
            // 
            numUDAdd.Location = new Point(389, 132);
            numUDAdd.Name = "numUDAdd";
            numUDAdd.Size = new Size(120, 23);
            numUDAdd.TabIndex = 24;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(537, 227);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 34);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(537, 125);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 34);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Поиск";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(btnShow);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtShow);
            panel1.Controls.Add(richTextBoxUserShow);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtDeleteUser);
            panel1.Controls.Add(checkBoxSurname);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtSearchSurmane);
            panel1.Controls.Add(checkBoxName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtSearchName);
            panel1.Controls.Add(dataGridViewSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 386);
            panel1.TabIndex = 14;
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Location = new Point(3, 3);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.Size = new Size(536, 223);
            dataGridViewSearch.TabIndex = 22;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(664, 107);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(84, 27);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Поиск";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(556, 30);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(163, 23);
            txtSearchName.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(556, 12);
            label7.Name = "label7";
            label7.Size = new Size(176, 15);
            label7.TabIndex = 24;
            label7.Text = "Поиск пользователя по имени";
            // 
            // checkBoxName
            // 
            checkBoxName.AutoSize = true;
            checkBoxName.Location = new Point(725, 34);
            checkBoxName.Name = "checkBoxName";
            checkBoxName.Size = new Size(15, 14);
            checkBoxName.TabIndex = 25;
            checkBoxName.UseVisualStyleBackColor = true;
            // 
            // checkBoxSurname
            // 
            checkBoxSurname.AutoSize = true;
            checkBoxSurname.Location = new Point(725, 82);
            checkBoxSurname.Name = "checkBoxSurname";
            checkBoxSurname.Size = new Size(15, 14);
            checkBoxSurname.TabIndex = 28;
            checkBoxSurname.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(556, 60);
            label8.Name = "label8";
            label8.Size = new Size(192, 15);
            label8.TabIndex = 27;
            label8.Text = "Поиск пользователя по фамилии";
            // 
            // txtSearchSurmane
            // 
            txtSearchSurmane.Location = new Point(556, 78);
            txtSearchSurmane.Name = "txtSearchSurmane";
            txtSearchSurmane.Size = new Size(163, 23);
            txtSearchSurmane.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(556, 152);
            label9.Name = "label9";
            label9.Size = new Size(168, 15);
            label9.TabIndex = 30;
            label9.Text = "Удаление пользователя по ID";
            // 
            // txtDeleteUser
            // 
            txtDeleteUser.Location = new Point(556, 170);
            txtDeleteUser.Name = "txtDeleteUser";
            txtDeleteUser.Size = new Size(163, 23);
            txtDeleteUser.TabIndex = 29;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(664, 199);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(84, 27);
            btnDeleteUser.TabIndex = 31;
            btnDeleteUser.Text = "Удалить";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // richTextBoxUserShow
            // 
            richTextBoxUserShow.Location = new Point(3, 232);
            richTextBoxUserShow.Name = "richTextBoxUserShow";
            richTextBoxUserShow.Size = new Size(536, 151);
            richTextBoxUserShow.TabIndex = 32;
            richTextBoxUserShow.Text = "";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(664, 340);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(84, 27);
            btnShow.TabIndex = 35;
            btnShow.Text = "Вывод";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(556, 293);
            label10.Name = "label10";
            label10.Size = new Size(151, 15);
            label10.TabIndex = 34;
            label10.Text = "Вывод пользователя по ID";
            // 
            // txtShow
            // 
            txtShow.Location = new Point(556, 311);
            txtShow.Name = "txtShow";
            txtShow.Size = new Size(163, 23);
            txtShow.TabIndex = 33;
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "AdminPanelForm";
            Text = "AdminPanelForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUDDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDAdd).EndInit();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel3;
        private Button btnAdd;
        private Panel panel1;
        private DataGridView dataGridViewSearch;
        private Button btnSearch;
        private Button btnDelete;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmBoxProductAdd;
        private ComboBox cmBoxCategoryAdd;
        private NumericUpDown numUDAdd;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmBoxProductDelete;
        private ComboBox cmBoxCategoryDelete;
        private NumericUpDown numUDDelete;
        private Label label9;
        private TextBox txtDeleteUser;
        private CheckBox checkBoxSurname;
        private Label label8;
        private TextBox txtSearchSurmane;
        private CheckBox checkBoxName;
        private Label label7;
        private TextBox txtSearchName;
        private Button btnDeleteUser;
        private Button btnShow;
        private Label label10;
        private TextBox txtShow;
        private RichTextBox richTextBoxUserShow;
    }
}