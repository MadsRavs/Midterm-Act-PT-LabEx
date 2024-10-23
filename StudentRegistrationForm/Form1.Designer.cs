namespace StudentRegistrationApplication
{
    partial class RegistrationForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            OtherRadiobutton = new RadioButton();
            YearCombobox = new ComboBox();
            monthCombobox = new ComboBox();
            DayCombobox = new ComboBox();
            label6 = new Label();
            FemaleRadiobutton = new RadioButton();
            MaleRadiobutton = new RadioButton();
            label5 = new Label();
            MiddleNameTextbox = new TextBox();
            FirstNameTextbox = new TextBox();
            LastNameTextbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            ProgramCombobox = new ComboBox();
            label8 = new Label();
            RegisterNow = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(562, 391);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.23741F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.76259F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(556, 294);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(OtherRadiobutton);
            panel1.Controls.Add(YearCombobox);
            panel1.Controls.Add(monthCombobox);
            panel1.Controls.Add(DayCombobox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(FemaleRadiobutton);
            panel1.Controls.Add(MaleRadiobutton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(MiddleNameTextbox);
            panel1.Controls.Add(FirstNameTextbox);
            panel1.Controls.Add(LastNameTextbox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 288);
            panel1.TabIndex = 0;
            // 
            // OtherRadiobutton
            // 
            OtherRadiobutton.AutoSize = true;
            OtherRadiobutton.Location = new Point(193, 207);
            OtherRadiobutton.Name = "OtherRadiobutton";
            OtherRadiobutton.Size = new Size(60, 19);
            OtherRadiobutton.TabIndex = 16;
            OtherRadiobutton.TabStop = true;
            OtherRadiobutton.Text = "Others";
            OtherRadiobutton.UseVisualStyleBackColor = true;
            // 
            // YearCombobox
            // 
            YearCombobox.FormattingEnabled = true;
            YearCombobox.Location = new Point(200, 254);
            YearCombobox.Name = "YearCombobox";
            YearCombobox.Size = new Size(79, 23);
            YearCombobox.TabIndex = 13;
            YearCombobox.Text = "-Year-";
            // 
            // monthCombobox
            // 
            monthCombobox.FormattingEnabled = true;
            monthCombobox.Location = new Point(107, 254);
            monthCombobox.Name = "monthCombobox";
            monthCombobox.Size = new Size(72, 23);
            monthCombobox.TabIndex = 12;
            monthCombobox.Text = "-Month-";
            // 
            // DayCombobox
            // 
            DayCombobox.FormattingEnabled = true;
            DayCombobox.Location = new Point(10, 254);
            DayCombobox.Name = "DayCombobox";
            DayCombobox.Size = new Size(76, 23);
            DayCombobox.TabIndex = 11;
            DayCombobox.Text = "-Day-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 236);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 10;
            label6.Text = "Date of birth *";
            // 
            // FemaleRadiobutton
            // 
            FemaleRadiobutton.AutoSize = true;
            FemaleRadiobutton.Location = new Point(124, 207);
            FemaleRadiobutton.Name = "FemaleRadiobutton";
            FemaleRadiobutton.Size = new Size(63, 19);
            FemaleRadiobutton.TabIndex = 9;
            FemaleRadiobutton.TabStop = true;
            FemaleRadiobutton.Text = "Female";
            FemaleRadiobutton.UseVisualStyleBackColor = true;
            // 
            // MaleRadiobutton
            // 
            MaleRadiobutton.AutoSize = true;
            MaleRadiobutton.Location = new Point(67, 207);
            MaleRadiobutton.Name = "MaleRadiobutton";
            MaleRadiobutton.Size = new Size(51, 19);
            MaleRadiobutton.TabIndex = 8;
            MaleRadiobutton.TabStop = true;
            MaleRadiobutton.Text = "Male";
            MaleRadiobutton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 207);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 7;
            label5.Text = "Gender *";
            // 
            // MiddleNameTextbox
            // 
            MiddleNameTextbox.Location = new Point(10, 166);
            MiddleNameTextbox.Name = "MiddleNameTextbox";
            MiddleNameTextbox.Size = new Size(269, 23);
            MiddleNameTextbox.TabIndex = 6;
            // 
            // FirstNameTextbox
            // 
            FirstNameTextbox.Location = new Point(10, 112);
            FirstNameTextbox.Name = "FirstNameTextbox";
            FirstNameTextbox.Size = new Size(269, 23);
            FirstNameTextbox.TabIndex = 5;
            // 
            // LastNameTextbox
            // 
            LastNameTextbox.Location = new Point(10, 58);
            LastNameTextbox.Name = "LastNameTextbox";
            LastNameTextbox.Size = new Size(269, 23);
            LastNameTextbox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 148);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Middle Name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 94);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 40);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(248, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(299, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 288);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(91, 254);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Image = Properties.Resources._3;
            pictureBox1.Location = new Point(33, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 193);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(ProgramCombobox);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(RegisterNow);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 303);
            panel3.Name = "panel3";
            panel3.Size = new Size(556, 85);
            panel3.TabIndex = 1;
            // 
            // ProgramCombobox
            // 
            ProgramCombobox.FormattingEnabled = true;
            ProgramCombobox.Items.AddRange(new object[] { "Bachelor of Arts (BA) in English", "Bachelor of Fine Arts (BFA) in Graphic Design", "Bachelor of Arts (BA) in History", "Bachelor of Arts (BA) in Philosophy", "Bachelor of Music (BM)", "Bachelor of Business Administration (BBA)", "Bachelor of Science (BS) in Finance", "Bachelor of Science (BS) in Marketing", "Bachelor of Arts (BA) in Management", "Master of Business Administration (MBA)", "Bachelor of Science in Education (BSE)", "Master of Education (M.Ed)", "Doctor of Education (Ed.D)", "Bachelor of Science in Nursing (BSN)", "Bachelor of Science (BS) in Public Health", "Doctor of Medicine (MD)", "Doctor of Pharmacy (PharmD)", "Bachelor of Science (BS) in Computer Engineering", "Bachelor of Science (BS) in Mechanical Engineering", "Bachelor of Science (BS) in Electrical Engineering", "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Arts (BA) in Psychology", "Bachelor of Science (BS) in Sociology", "Bachelor of Arts (BA) in Political Science", "Bachelor of Social Work (BSW)", "Bachelor of Science (BS) in Biology", "Bachelor of Science (BS) in Chemistry", "Bachelor of Science (BS) in Physics", "Bachelor of Science (BS) in Environmental Science", "Bachelor of Arts (BA) in Communication", "Bachelor of Arts (BA) in Journalism", "Bachelor of Arts (BA) in Film Studies", "Bachelor of Arts (BA) in Liberal Arts", "Bachelor of Science (BS) in Environmental Studies" });
            ProgramCombobox.Location = new Point(13, 18);
            ProgramCombobox.Name = "ProgramCombobox";
            ProgramCombobox.Size = new Size(280, 23);
            ProgramCombobox.TabIndex = 18;
            ProgramCombobox.Text = "-Select program-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 0);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 17;
            label8.Text = "Program to apply *";
            // 
            // RegisterNow
            // 
            RegisterNow.Location = new Point(13, 47);
            RegisterNow.Name = "RegisterNow";
            RegisterNow.Size = new Size(338, 23);
            RegisterNow.TabIndex = 16;
            RegisterNow.Text = "Register student";
            RegisterNow.UseVisualStyleBackColor = true;
            RegisterNow.Click += RegisterNow_Click_1;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 415);
            Controls.Add(tableLayoutPanel1);
            Name = "RegistrationForm";
            Text = "Registration Form";
            Load += RegistrationForm_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private ComboBox YearCombobox;
        private ComboBox monthCombobox;
        private ComboBox DayCombobox;
        private Label label6;
        private RadioButton FemaleRadiobutton;
        private RadioButton MaleRadiobutton;
        private Label label5;
        private TextBox MiddleNameTextbox;
        private TextBox FirstNameTextbox;
        private TextBox LastNameTextbox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button RegisterNow;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label8;
        private ComboBox ProgramCombobox;
        private RadioButton OtherRadiobutton;
    }
}
