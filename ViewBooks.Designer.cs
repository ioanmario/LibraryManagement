namespace LibraryManagement
{
    partial class ViewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooks));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtPDate = new TextBox();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtPublication = new TextBox();
            txtAuthor = new TextBox();
            txtBName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            txtBookName = new TextBox();
            label8 = new Label();
            btnRefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, -266);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 144);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(391, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 144);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, -113);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Book Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, -116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(575, -116);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(931, 244);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPDate);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtPublication);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(txtBName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(27, 546);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 254);
            panel2.TabIndex = 5;
            // 
            // txtPDate
            // 
            txtPDate.Location = new Point(609, 40);
            txtPDate.Name = "txtPDate";
            txtPDate.Size = new Size(250, 27);
            txtPDate.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(538, 175);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 34);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(414, 175);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 34);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(289, 175);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 34);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(609, 115);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 27);
            txtQuantity.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(609, 79);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtPublication
            // 
            txtPublication.Location = new Point(160, 116);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(234, 27);
            txtPublication.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(160, 82);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(234, 27);
            txtAuthor.TabIndex = 7;
            // 
            // txtBName
            // 
            txtBName.Location = new Point(160, 43);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(234, 27);
            txtBName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 119);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 5;
            label5.Text = "Book Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(429, 82);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 4;
            label6.Text = "Book Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 43);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 3;
            label7.Text = "Book Purchase Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 119);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 2;
            label4.Text = "Book Publication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 82);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 1;
            label3.Text = "Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 43);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(407, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 139);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(325, 193);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(317, 27);
            txtBookName.TabIndex = 7;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(211, 193);
            label8.Name = "label8";
            label8.Size = new Size(108, 23);
            label8.TabIndex = 8;
            label8.Text = "Book Name";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(192, 0, 0);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = SystemColors.ButtonHighlight;
            btnRefresh.Location = new Point(648, 193);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 29);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(982, 834);
            Controls.Add(btnRefresh);
            Controls.Add(label8);
            Controls.Add(txtBookName);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ViewBooks";
            Text = "ViewBooks";
            Load += ViewBooks_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtPublication;
        private TextBox txtAuthor;
        private TextBox txtBName;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox txtPDate;
        private TextBox txtBookName;
        private Label label8;
        private Button btnRefresh;
    }
}