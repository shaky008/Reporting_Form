﻿namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Name = new System.Windows.Forms.Label();
            this.StudentNum = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.FacultyMemName = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.CourseName = new System.Windows.Forms.Label();
            this.AssignmentNumber = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.TermOrSem = new System.Windows.Forms.Label();
            this.ViolationDesc = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(36, 31);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(75, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Student Name";
            // 
            // StudentNum
            // 
            this.StudentNum.AutoSize = true;
            this.StudentNum.Location = new System.Drawing.Point(229, 31);
            this.StudentNum.Name = "StudentNum";
            this.StudentNum.Size = new System.Drawing.Size(84, 13);
            this.StudentNum.TabIndex = 1;
            this.StudentNum.Text = "Student Number";
            this.StudentNum.Click += new System.EventHandler(this.StudentNum_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(372, 31);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(72, 13);
            this.Email.TabIndex = 2;
            this.Email.Text = "Student Email";
            // 
            // FacultyMemName
            // 
            this.FacultyMemName.AutoSize = true;
            this.FacultyMemName.Location = new System.Drawing.Point(36, 83);
            this.FacultyMemName.Name = "FacultyMemName";
            this.FacultyMemName.Size = new System.Drawing.Size(113, 13);
            this.FacultyMemName.TabIndex = 3;
            this.FacultyMemName.Text = "Faculty Member Name";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(199, 83);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(93, 13);
            this.Date.TabIndex = 4;
            this.Date.Text = "Date (yyyy-mm-dd)";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(428, 83);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(132, 13);
            this.CourseName.TabIndex = 5;
            this.CourseName.Text = "Course Name and Number";
            // 
            // AssignmentNumber
            // 
            this.AssignmentNumber.AutoSize = true;
            this.AssignmentNumber.Location = new System.Drawing.Point(36, 134);
            this.AssignmentNumber.Name = "AssignmentNumber";
            this.AssignmentNumber.Size = new System.Drawing.Size(142, 13);
            this.AssignmentNumber.TabIndex = 6;
            this.AssignmentNumber.Text = "Assignmnet Number or Exam";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(199, 134);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(62, 13);
            this.Department.TabIndex = 7;
            this.Department.Text = "Department";
            // 
            // TermOrSem
            // 
            this.TermOrSem.AutoSize = true;
            this.TermOrSem.Location = new System.Drawing.Point(394, 134);
            this.TermOrSem.Name = "TermOrSem";
            this.TermOrSem.Size = new System.Drawing.Size(90, 13);
            this.TermOrSem.TabIndex = 8;
            this.TermOrSem.Text = "Term or Semester";
            // 
            // ViolationDesc
            // 
            this.ViolationDesc.AutoSize = true;
            this.ViolationDesc.Location = new System.Drawing.Point(36, 182);
            this.ViolationDesc.Name = "ViolationDesc";
            this.ViolationDesc.Size = new System.Drawing.Size(507, 13);
            this.ViolationDesc.TabIndex = 9;
            this.ViolationDesc.Text = "Description of Violation of Academic Integrity Policy ED 5-0 with respect to a pa" +
    "rticular assignment or exam";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 198);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(578, 96);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Recommendations for sanction.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 169);
            this.label2.TabIndex = 12;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "By pressing the submit button, you would be signing this form";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name of the Faculty Member";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date (yyyy-mm-dd)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 630);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(39, 47);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(187, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(232, 47);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(120, 20);
            this.IdTextBox.TabIndex = 2;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(375, 47);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(259, 20);
            this.EmailTextBox.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(431, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(39, 150);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(202, 150);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(120, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(397, 150);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(120, 20);
            this.textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(29, 548);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(232, 20);
            this.textBox7.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 548);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(202, 99);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(577, 463);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(577, 494);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 665);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ViolationDesc);
            this.Controls.Add(this.TermOrSem);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.AssignmentNumber);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.FacultyMemName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.StudentNum);
            this.Controls.Add(this.Name);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label StudentNum;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label FacultyMemName;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.Label AssignmentNumber;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label TermOrSem;
        private System.Windows.Forms.Label ViolationDesc;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
