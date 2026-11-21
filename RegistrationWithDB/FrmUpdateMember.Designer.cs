namespace RegistrationWithDB
{
    partial class FrmUpdateMember
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
            label1 = new Label();
            cbStudentId = new ComboBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            txtMiddleName = new TextBox();
            label5 = new Label();
            txtAge = new TextBox();
            label6 = new Label();
            cbGender = new ComboBox();
            label7 = new Label();
            cbProgram = new ComboBox();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // cbStudentId
            // 
            cbStudentId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudentId.FormattingEnabled = true;
            cbStudentId.Location = new Point(27, 38);
            cbStudentId.Margin = new Padding(4, 3, 4, 3);
            cbStudentId.Name = "cbStudentId";
            cbStudentId.Size = new Size(256, 23);
            cbStudentId.TabIndex = 1;
            cbStudentId.SelectedIndexChanged += cbStudentId_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Last name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(27, 99);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(233, 23);
            txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 136);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(27, 157);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(233, 23);
            txtFirstName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 194);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 6;
            label4.Text = "Middle name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(27, 215);
            txtMiddleName.Margin = new Padding(4, 3, 4, 3);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(233, 23);
            txtMiddleName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 252);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(27, 272);
            txtAge.Margin = new Padding(4, 3, 4, 3);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(139, 23);
            txtAge.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 309);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 10;
            label6.Text = "Gender:";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(27, 330);
            cbGender.Margin = new Padding(4, 3, 4, 3);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(186, 23);
            cbGender.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 369);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 12;
            label7.Text = "Program:";
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Computer Science", "BS in Information Technology", "BS in Business Administration", "BS in Hospitality Management", "BS in Tourism Management" });
            cbProgram.Location = new Point(27, 390);
            cbProgram.Margin = new Padding(4, 3, 4, 3);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(256, 23);
            cbProgram.TabIndex = 13;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(99, 438);
            btnConfirm.Margin = new Padding(4, 3, 4, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(111, 35);
            btnConfirm.TabIndex = 14;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 496);
            Controls.Add(btnConfirm);
            Controls.Add(cbProgram);
            Controls.Add(label7);
            Controls.Add(cbGender);
            Controls.Add(label6);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(txtMiddleName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(cbStudentId);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmUpdateMember";
            Text = "Update Member Form";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStudentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Button btnConfirm;
    }
}