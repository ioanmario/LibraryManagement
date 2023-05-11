namespace LibraryManagement
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            panel1 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtEnrollment = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtCYear = new TextBox();
            txtDep = new TextBox();
            txtName = new TextBox();
            btnIssueBook = new Button();
            comboBoxBook = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtEnrollment);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 536);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Cornsilk;
            btnExit.Location = new Point(162, 444);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 35);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(192, 0, 0);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(23, 444);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 35);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(59, 381);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(164, 42);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(23, 334);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(244, 27);
            txtEnrollment.TabIndex = 2;
            txtEnrollment.TextChanged += txtEnrollment_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 290);
            label1.Name = "label1";
            label1.Size = new Size(264, 32);
            label1.TabIndex = 3;
            label1.Text = "Enter Enrollment No";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(288, 268);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(333, 80);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(333, 132);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 3;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(333, 182);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 4;
            label4.Text = "College Year";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(333, 332);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 7;
            label5.Text = "Book Name";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(333, 285);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 6;
            label6.Text = "Institutional Email";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(333, 234);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 5;
            label7.Text = "Student Contact";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(333, 376);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 8;
            label8.Text = "Book Issue Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(490, 371);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(326, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(490, 282);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContact.Location = new Point(490, 231);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(326, 27);
            txtContact.TabIndex = 12;
            // 
            // txtCYear
            // 
            txtCYear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCYear.Location = new Point(490, 182);
            txtCYear.Name = "txtCYear";
            txtCYear.Size = new Size(326, 27);
            txtCYear.TabIndex = 13;
            // 
            // txtDep
            // 
            txtDep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDep.Location = new Point(490, 132);
            txtDep.Name = "txtDep";
            txtDep.Size = new Size(326, 27);
            txtDep.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(490, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(326, 27);
            txtName.TabIndex = 15;
            // 
            // btnIssueBook
            // 
            btnIssueBook.Anchor = AnchorStyles.None;
            btnIssueBook.BackColor = Color.FromArgb(192, 0, 0);
            btnIssueBook.FlatStyle = FlatStyle.Popup;
            btnIssueBook.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIssueBook.ForeColor = SystemColors.ButtonHighlight;
            btnIssueBook.Location = new Point(490, 449);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(164, 42);
            btnIssueBook.TabIndex = 16;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = false;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // comboBoxBook
            // 
            comboBoxBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxBook.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBook.FormattingEnabled = true;
            comboBoxBook.Location = new Point(492, 333);
            comboBoxBook.Name = "comboBoxBook";
            comboBoxBook.Size = new Size(324, 28);
            comboBoxBook.TabIndex = 17;
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(838, 560);
            Controls.Add(comboBoxBook);
            Controls.Add(btnIssueBook);
            Controls.Add(txtName);
            Controls.Add(txtDep);
            Controls.Add(txtCYear);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "IssueBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBook";
            Load += IssueBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtEnrollment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtCYear;
        private TextBox txtDep;
        private TextBox txtName;
        private Button btnIssueBook;
        private ComboBox comboBoxBook;
    }
}