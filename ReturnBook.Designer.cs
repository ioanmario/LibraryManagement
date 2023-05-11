namespace LibraryManagement
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtEnterEnroll = new TextBox();
            btnSerachStudent = new Button();
            btnRefresh = new Button();
            btnExit = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBookName = new TextBox();
            txtBookIssueDate = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            btnCancel = new Button();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 203);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 260);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "Enrollment No";
            // 
            // txtEnterEnroll
            // 
            txtEnterEnroll.Location = new Point(34, 295);
            txtEnterEnroll.Name = "txtEnterEnroll";
            txtEnterEnroll.Size = new Size(210, 27);
            txtEnterEnroll.TabIndex = 2;
            txtEnterEnroll.TextChanged += txtEnterEnroll_TextChanged;
            // 
            // btnSerachStudent
            // 
            btnSerachStudent.Location = new Point(34, 340);
            btnSerachStudent.Name = "btnSerachStudent";
            btnSerachStudent.Size = new Size(210, 29);
            btnSerachStudent.TabIndex = 3;
            btnSerachStudent.Text = "Search Student";
            btnSerachStudent.UseVisualStyleBackColor = true;
            btnSerachStudent.Click += btnSerachStudent_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(34, 398);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(150, 398);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 29);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 6;
            label2.Text = "Book Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 58);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 7;
            label3.Text = "Book Issue Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 91);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 8;
            label4.Text = "Book Return Date";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(228, 18);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(259, 27);
            txtBookName.TabIndex = 9;
            // 
            // txtBookIssueDate
            // 
            txtBookIssueDate.Location = new Point(230, 51);
            txtBookIssueDate.Name = "txtBookIssueDate";
            txtBookIssueDate.Size = new Size(257, 27);
            txtBookIssueDate.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(229, 84);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(260, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(702, 368);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Location = new Point(260, 428);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtBookIssueDate);
            panel2.Controls.Add(txtBookName);
            panel2.Location = new Point(260, 428);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 140);
            panel2.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(523, 64);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(523, 29);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 12;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(974, 572);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(btnExit);
            Controls.Add(btnRefresh);
            Controls.Add(btnSerachStudent);
            Controls.Add(txtEnterEnroll);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ReturnBook";
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtEnterEnroll;
        private Button btnSerachStudent;
        private Button btnRefresh;
        private Button btnExit;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBookName;
        private TextBox txtBookIssueDate;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Button btnCancel;
        private Button btnReturn;
    }
}