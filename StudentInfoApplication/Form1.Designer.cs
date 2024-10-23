namespace StudentInfoApplication
{
    partial class frmStudentInfo
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
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            lstLastName = new ListBox();
            lstFirstName = new ListBox();
            lstStudentID = new ListBox();
            txtFirstName = new TextBox();
            txtStudentID = new TextBox();
            txtLastName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lstLastName);
            panel1.Controls.Add(lstFirstName);
            panel1.Controls.Add(lstStudentID);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(txtStudentID);
            panel1.Controls.Add(txtLastName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 312);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(443, 107);
            label6.Name = "label6";
            label6.Size = new Size(99, 17);
            label6.TabIndex = 12;
            label6.Text = "Last Name List";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(231, 107);
            label5.Name = "label5";
            label5.Size = new Size(101, 17);
            label5.TabIndex = 11;
            label5.Text = "First Name List";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(24, 107);
            label4.Name = "label4";
            label4.Size = new Size(100, 17);
            label4.TabIndex = 10;
            label4.Text = "Student ID List";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(443, 19);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 9;
            label3.Text = "First name *";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(24, 19);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 8;
            label2.Text = "Student ID *";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(231, 19);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 7;
            label1.Text = "Last name *";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Orange;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 255, 128);
            button1.Location = new Point(552, 66);
            button1.Name = "button1";
            button1.Size = new Size(86, 25);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.KeyDown += button1_KeyDown;
            // 
            // lstLastName
            // 
            lstLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstLastName.BorderStyle = BorderStyle.FixedSingle;
            lstLastName.ForeColor = SystemColors.InfoText;
            lstLastName.FormattingEnabled = true;
            lstLastName.ItemHeight = 15;
            lstLastName.Location = new Point(443, 125);
            lstLastName.Name = "lstLastName";
            lstLastName.Size = new Size(195, 167);
            lstLastName.TabIndex = 5;
            // 
            // lstFirstName
            // 
            lstFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lstFirstName.BorderStyle = BorderStyle.FixedSingle;
            lstFirstName.ForeColor = SystemColors.InfoText;
            lstFirstName.FormattingEnabled = true;
            lstFirstName.ItemHeight = 15;
            lstFirstName.Location = new Point(233, 126);
            lstFirstName.Name = "lstFirstName";
            lstFirstName.Size = new Size(190, 167);
            lstFirstName.TabIndex = 4;
            // 
            // lstStudentID
            // 
            lstStudentID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstStudentID.BorderStyle = BorderStyle.FixedSingle;
            lstStudentID.ForeColor = SystemColors.InfoText;
            lstStudentID.FormattingEnabled = true;
            lstStudentID.ItemHeight = 15;
            lstStudentID.Location = new Point(24, 125);
            lstStudentID.Name = "lstStudentID";
            lstStudentID.Size = new Size(195, 167);
            lstStudentID.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.BackColor = SystemColors.Menu;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.ForeColor = SystemColors.InfoText;
            txtFirstName.Location = new Point(443, 37);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(195, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtStudentID
            // 
            txtStudentID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentID.BackColor = SystemColors.Menu;
            txtStudentID.BorderStyle = BorderStyle.FixedSingle;
            txtStudentID.ForeColor = SystemColors.InfoText;
            txtStudentID.Location = new Point(24, 37);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(195, 23);
            txtStudentID.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.BackColor = SystemColors.Menu;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.ForeColor = SystemColors.InfoText;
            txtLastName.Location = new Point(231, 37);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(195, 23);
            txtLastName.TabIndex = 0;
            // 
            // frmStudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(655, 312);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmStudentInfo";
            Text = "frmStudentInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private ListBox lstLastName;
        private ListBox lstFirstName;
        private ListBox lstStudentID;
        private TextBox txtFirstName;
        private TextBox txtStudentID;
        private TextBox txtLastName;
        private Label label6;
    }
}
