namespace LibraryManagement
{
    partial class ViewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudent));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtSearchEnrollment = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtSCyear = new TextBox();
            btCancel = new Button();
            btDelete = new Button();
            btUpdate = new Button();
            txtSEmail = new TextBox();
            txtScontact = new TextBox();
            txtSDepartment = new TextBox();
            txtSenrollment = new TextBox();
            txtSName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(389, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 152);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(216, 196);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 1;
            label1.Text = "Enrollment No";
            // 
            // txtSearchEnrollment
            // 
            txtSearchEnrollment.Location = new Point(378, 196);
            txtSearchEnrollment.Name = "txtSearchEnrollment";
            txtSearchEnrollment.Size = new Size(219, 27);
            txtSearchEnrollment.TabIndex = 2;
            txtSearchEnrollment.TextChanged += txtSearchEnrollment_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(192, 0, 0);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = SystemColors.ButtonHighlight;
            btnRefresh.Location = new Point(603, 195);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(964, 252);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSCyear);
            panel2.Controls.Add(btCancel);
            panel2.Controls.Add(btDelete);
            panel2.Controls.Add(btUpdate);
            panel2.Controls.Add(txtSEmail);
            panel2.Controls.Add(txtScontact);
            panel2.Controls.Add(txtSDepartment);
            panel2.Controls.Add(txtSenrollment);
            panel2.Controls.Add(txtSName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 528);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 254);
            panel2.TabIndex = 6;
            // 
            // txtSCyear
            // 
            txtSCyear.Location = new Point(609, 40);
            txtSCyear.Name = "txtSCyear";
            txtSCyear.Size = new Size(250, 27);
            txtSCyear.TabIndex = 15;
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.FromArgb(192, 0, 0);
            btCancel.FlatStyle = FlatStyle.Popup;
            btCancel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btCancel.ForeColor = SystemColors.ButtonHighlight;
            btCancel.Location = new Point(538, 175);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(109, 34);
            btCancel.TabIndex = 14;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // btDelete
            // 
            btDelete.BackColor = Color.FromArgb(192, 0, 0);
            btDelete.FlatStyle = FlatStyle.Popup;
            btDelete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btDelete.ForeColor = SystemColors.ButtonHighlight;
            btDelete.Location = new Point(414, 175);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(109, 34);
            btDelete.TabIndex = 13;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // btUpdate
            // 
            btUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btUpdate.FlatStyle = FlatStyle.Popup;
            btUpdate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdate.ForeColor = SystemColors.ButtonHighlight;
            btUpdate.Location = new Point(289, 175);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(109, 34);
            btUpdate.TabIndex = 12;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtSEmail
            // 
            txtSEmail.Location = new Point(609, 115);
            txtSEmail.Name = "txtSEmail";
            txtSEmail.Size = new Size(250, 27);
            txtSEmail.TabIndex = 10;
            // 
            // txtScontact
            // 
            txtScontact.Location = new Point(609, 79);
            txtScontact.Name = "txtScontact";
            txtScontact.Size = new Size(250, 27);
            txtScontact.TabIndex = 9;
            // 
            // txtSDepartment
            // 
            txtSDepartment.Location = new Point(160, 116);
            txtSDepartment.Name = "txtSDepartment";
            txtSDepartment.Size = new Size(234, 27);
            txtSDepartment.TabIndex = 8;
            // 
            // txtSenrollment
            // 
            txtSenrollment.Location = new Point(160, 82);
            txtSenrollment.Name = "txtSenrollment";
            txtSenrollment.Size = new Size(234, 27);
            txtSenrollment.TabIndex = 7;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(160, 43);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(234, 27);
            txtSName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 119);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 5;
            label5.Text = "Institutional Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(429, 82);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 4;
            label6.Text = "Contact Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 43);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 3;
            label7.Text = "College Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 119);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 2;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 82);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 1;
            label3.Text = "Enrollment Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 43);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // ViewStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(982, 833);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearchEnrollment);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ViewStudent";
            Text = "ViewStudent";
            Load += ViewStudent_Load;
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
        private TextBox txtSearchEnrollment;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtSCyear;
        private Button btCancel;
        private Button btDelete;
        private Button btUpdate;
        private TextBox txtSEmail;
        private TextBox txtScontact;
        private TextBox txtSDepartment;
        private TextBox txtSenrollment;
        private TextBox txtSName;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}