namespace RegistrationWithDB
{
    partial class FrmClubRegistration
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cbGender = new ComboBox();
            txtAge = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtMiddleName = new TextBox();
            label5 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            cbProgram = new ComboBox();
            label2 = new Label();
            txtStudentId = new TextBox();
            label1 = new Label();
            btnRegister = new Button();
            btnUpdate = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnRefresh = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbGender);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMiddleName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbProgram);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtStudentId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(747, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(257, 150);
            cbGender.Margin = new Padding(4, 3, 4, 3);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(174, 23);
            cbGender.TabIndex = 13;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(18, 150);
            txtAge.Margin = new Padding(4, 3, 4, 3);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(139, 23);
            txtAge.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(253, 129);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 11;
            label7.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 129);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 10;
            label6.Text = "Age:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(490, 92);
            txtMiddleName.Margin = new Padding(4, 3, 4, 3);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(215, 23);
            txtMiddleName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 72);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 8;
            label5.Text = "Middle name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(257, 92);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(215, 23);
            txtFirstName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 72);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "First Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(18, 92);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(215, 23);
            txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 4;
            label3.Text = "Last name:";
            // 
            // cbProgram
            // 
            cbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Computer Science", "BS in Information Technology", "BS in Business Administration", "BS in Hospitality Management", "BS in Tourism Management" });
            cbProgram.Location = new Point(490, 37);
            cbProgram.Margin = new Padding(4, 3, 4, 3);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(238, 23);
            cbProgram.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Program:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(18, 37);
            txtStudentId.Margin = new Padding(4, 3, 4, 3);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(198, 23);
            txtStudentId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(776, 21);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(111, 37);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(776, 65);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 37);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(14, 231);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(747, 242);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "List Of Club Members";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 25);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(723, 205);
            dataGridView1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(776, 256);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(111, 37);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 490);
            Controls.Add(btnRefresh);
            Controls.Add(groupBox2);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegister);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmClubRegistration";
            Text = "Club Registration";
            Load += FrmClubRegistration_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
    }
}