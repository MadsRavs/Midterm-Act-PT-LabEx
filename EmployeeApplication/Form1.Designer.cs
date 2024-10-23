namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
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
            dataGridViewEmployees = new DataGridView();
            txtEmployeeId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPosition = new TextBox();
            buttonAddEmployee = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.GridColor = Color.DarkSlateGray;
            dataGridViewEmployees.Location = new Point(193, 33);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.Size = new Size(339, 221);
            dataGridViewEmployees.TabIndex = 0;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(9, 53);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(158, 23);
            txtEmployeeId.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(9, 97);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(158, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(9, 140);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(158, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(9, 183);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(158, 23);
            txtPosition.TabIndex = 4;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.BackColor = Color.DimGray;
            buttonAddEmployee.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddEmployee.ForeColor = SystemColors.ButtonHighlight;
            buttonAddEmployee.Location = new Point(28, 212);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(116, 28);
            buttonAddEmployee.TabIndex = 5;
            buttonAddEmployee.Text = "Submit";
            buttonAddEmployee.UseVisualStyleBackColor = false;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 10);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 6;
            label1.Text = "Add Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 35);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 7;
            label2.Text = "Employee ID *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 79);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "First name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 122);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 9;
            label4.Text = "Last name*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 165);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 10;
            label5.Text = "Position *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(193, 15);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 11;
            label6.Text = "Employee List:";
            // 
            // frmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(545, 259);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAddEmployee);
            Controls.Add(txtPosition);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmployeeId);
            Controls.Add(dataGridViewEmployees);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            Name = "frmEmployeeDatabase";
            Text = "Employee Database";
            KeyDown += frmEmployeeDatabase_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmployees;
        private TextBox txtEmployeeId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPosition;
        private Button buttonAddEmployee;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
