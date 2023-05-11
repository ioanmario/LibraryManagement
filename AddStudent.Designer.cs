namespace LibraryManagement
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRefresh = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            txtStudent = new TextBox();
            txtEnrollment = new TextBox();
            txtDepartment = new TextBox();
            txtMail = new TextBox();
            txtContact = new TextBox();
            txtAn = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(492, 458);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(500, 108);
            label1.Name = "label1";
            label1.Size = new Size(111, 19);
            label1.TabIndex = 3;
            label1.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(500, 145);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 4;
            label2.Text = "Enrollment  No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(500, 186);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 5;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(500, 227);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 6;
            label4.Text = "College Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(500, 267);
            label5.Name = "label5";
            label5.Size = new Size(127, 19);
            label5.TabIndex = 7;
            label5.Text = "Student Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(500, 305);
            label6.Name = "label6";
            label6.Size = new Size(114, 19);
            label6.TabIndex = 8;
            label6.Text = "Student Email";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(192, 0, 0);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = SystemColors.ButtonHighlight;
            btnRefresh.Location = new Point(509, 380);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 33);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 0, 0);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(630, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 33);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save Info";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(751, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 33);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Exit";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtStudent
            // 
            txtStudent.Location = new Point(652, 104);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(215, 27);
            txtStudent.TabIndex = 12;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(652, 144);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(215, 27);
            txtEnrollment.TabIndex = 13;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(652, 182);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(215, 27);
            txtDepartment.TabIndex = 14;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(652, 301);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(215, 27);
            txtMail.TabIndex = 17;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(652, 263);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(215, 27);
            txtContact.TabIndex = 16;
            // 
            // txtAn
            // 
            txtAn.Location = new Point(652, 223);
            txtAn.Name = "txtAn";
            txtAn.Size = new Size(215, 27);
            txtAn.TabIndex = 15;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(889, 483);
            Controls.Add(txtMail);
            Controls.Add(txtContact);
            Controls.Add(txtAn);
            Controls.Add(txtDepartment);
            Controls.Add(txtEnrollment);
            Controls.Add(txtStudent);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnRefresh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRefresh;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtStudent;
        private TextBox txtEnrollment;
        private TextBox txtDepartment;
        private TextBox txtMail;
        private TextBox txtContact;
        private TextBox txtAn;
    }
}