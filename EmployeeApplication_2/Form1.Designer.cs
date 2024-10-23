namespace EmployeeApplication_2
{
    partial class frmComputeSalary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_firstname = new TextBox();
            label1 = new Label();
            button1 = new Button();
            txt_lastname = new TextBox();
            txt_department = new TextBox();
            txt_jobtitle = new TextBox();
            txt_rph = new TextBox();
            txt_thw = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lbl_firstname = new Label();
            lbl_lastname = new Label();
            lbl_salary = new Label();
            SuspendLayout();
            // 
            // txt_firstname
            // 
            txt_firstname.Location = new Point(14, 46);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(193, 25);
            txt_firstname.TabIndex = 0;
            txt_firstname.KeyDown += TextBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 26);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 1;
            label1.Text = "First name";
            // 
            // button1
            // 
            button1.Location = new Point(96, 233);
            button1.Name = "button1";
            button1.Size = new Size(169, 26);
            button1.TabIndex = 2;
            button1.Text = "Compute Salary";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(226, 46);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(182, 25);
            txt_lastname.TabIndex = 3;
            txt_lastname.KeyDown += TextBox_KeyDown;
            // 
            // txt_department
            // 
            txt_department.Location = new Point(14, 110);
            txt_department.Name = "txt_department";
            txt_department.Size = new Size(193, 25);
            txt_department.TabIndex = 4;
            txt_department.KeyDown += TextBox_KeyDown;
            // 
            // txt_jobtitle
            // 
            txt_jobtitle.Location = new Point(226, 110);
            txt_jobtitle.Name = "txt_jobtitle";
            txt_jobtitle.Size = new Size(182, 25);
            txt_jobtitle.TabIndex = 5;
            txt_jobtitle.KeyDown += TextBox_KeyDown;
            // 
            // txt_rph
            // 
            txt_rph.Location = new Point(14, 193);
            txt_rph.Name = "txt_rph";
            txt_rph.Size = new Size(193, 25);
            txt_rph.TabIndex = 6;
            txt_rph.KeyDown += TextBox_KeyDown;
            // 
            // txt_thw
            // 
            txt_thw.Location = new Point(226, 193);
            txt_thw.Name = "txt_thw";
            txt_thw.Size = new Size(182, 25);
            txt_thw.TabIndex = 7;
            txt_thw.KeyDown += TextBox_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 26);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 8;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 90);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 9;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 90);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 10;
            label4.Text = "Job title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 172);
            label5.Name = "label5";
            label5.Size = new Size(92, 17);
            label5.TabIndex = 11;
            label5.Text = "Rate per hour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(226, 172);
            label6.Name = "label6";
            label6.Size = new Size(125, 17);
            label6.TabIndex = 12;
            label6.Text = "Total hours worked";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 274);
            label7.Name = "label7";
            label7.Size = new Size(79, 17);
            label7.TabIndex = 13;
            label7.Text = "First name: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 314);
            label8.Name = "label8";
            label8.Size = new Size(73, 17);
            label8.TabIndex = 14;
            label8.Text = "Last name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 350);
            label9.Name = "label9";
            label9.Size = new Size(82, 17);
            label9.TabIndex = 15;
            label9.Text = "Basic Salary:";
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Location = new Point(123, 274);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(80, 17);
            lbl_firstname.TabIndex = 16;
            lbl_firstname.Text = "[First name]";
            // 
            // lbl_lastname
            // 
            lbl_lastname.AutoSize = true;
            lbl_lastname.Location = new Point(123, 314);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(78, 17);
            lbl_lastname.TabIndex = 17;
            lbl_lastname.Text = "[Last name]";
            // 
            // lbl_salary
            // 
            lbl_salary.AutoSize = true;
            lbl_salary.Location = new Point(123, 350);
            lbl_salary.Name = "lbl_salary";
            lbl_salary.Size = new Size(53, 17);
            lbl_salary.TabIndex = 18;
            lbl_salary.Text = "[Salary]";
            // 
            // frmComputeSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(420, 382);
            Controls.Add(lbl_salary);
            Controls.Add(lbl_lastname);
            Controls.Add(lbl_firstname);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_thw);
            Controls.Add(txt_rph);
            Controls.Add(txt_jobtitle);
            Controls.Add(txt_department);
            Controls.Add(txt_lastname);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txt_firstname);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Teal;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmComputeSalary";
            Text = "Employee Application Form";
            KeyDown += TextBox_KeyDown;
            ResumeLayout(false);
            PerformLayout();
            // Tab index for keydown events hiererchy
            txt_firstname.TabIndex = 0;
            txt_lastname.TabIndex = 1;
            txt_department.TabIndex = 2;
            txt_jobtitle.TabIndex = 3;
            txt_rph.TabIndex = 4;
            txt_thw.TabIndex = 5;
            button1.TabIndex = 6;

        }

        #endregion

        private TextBox txt_firstname;
        private Label label1;
        private Button button1;
        private TextBox txt_lastname;
        private TextBox txt_department;
        private TextBox txt_jobtitle;
        private TextBox txt_rph;
        private TextBox txt_thw;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbl_firstname;
        private Label lbl_lastname;
        private Label lbl_salary;
    }
}
