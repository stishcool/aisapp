namespace aisapp
{
    partial class CartForm
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
            cBoxDescription = new CheckBox();
            btnExport = new Button();
            lAvg = new Label();
            lTotalCost = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            btnBuy = new Button();
            panel2 = new Panel();
            label2 = new Label();
            btnBack = new Button();
            btnClear = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(cBoxDescription);
            panel3.Controls.Add(btnExport);
            panel3.Controls.Add(lAvg);
            panel3.Controls.Add(lTotalCost);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnBuy);
            panel3.Location = new Point(12, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 346);
            panel3.TabIndex = 12;
            // 
            // cBoxDescription
            // 
            cBoxDescription.AutoSize = true;
            cBoxDescription.Location = new Point(98, 22);
            cBoxDescription.Name = "cBoxDescription";
            cBoxDescription.Size = new Size(99, 19);
            cBoxDescription.TabIndex = 26;
            cBoxDescription.Text = "С описанием";
            cBoxDescription.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(17, 18);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 25;
            btnExport.Text = "Экспорт";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // lAvg
            // 
            lAvg.Location = new Point(650, 238);
            lAvg.Name = "lAvg";
            lAvg.Size = new Size(111, 35);
            lAvg.TabIndex = 24;
            lAvg.Text = "Средняя";
            // 
            // lTotalCost
            // 
            lTotalCost.AutoSize = true;
            lTotalCost.Location = new Point(650, 282);
            lTotalCost.Name = "lTotalCost";
            lTotalCost.Size = new Size(40, 15);
            lTotalCost.TabIndex = 23;
            lTotalCost.Text = "Итого";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(612, 268);
            dataGridView1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(304, 18);
            label3.Name = "label3";
            label3.Size = new Size(119, 32);
            label3.TabIndex = 21;
            label3.Text = "Корзина";
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(650, 300);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(111, 34);
            btnBuy.TabIndex = 16;
            btnBuy.Text = "Купить";
            btnBuy.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnBack);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 74);
            panel2.TabIndex = 11;
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
            // btnClear
            // 
            btnClear.Location = new Point(650, 13);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 34);
            btnClear.TabIndex = 27;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "CartForm";
            Text = "CartForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label3;
        private Button btnBuy;
        private Panel panel2;
        private Label label2;
        private Button btnBack;
        private DataGridView dataGridView1;
        private Label lTotalCost;
        private Label lAvg;
        private Button btnExport;
        private CheckBox cBoxDescription;
        private Button btnClear;
    }
}