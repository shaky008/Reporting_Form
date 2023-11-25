/*
 * File: Form1.cs
 * Description: This file contains the code for Form1 of the Windows Forms application.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //variable for file path and form locking
        string filePath = "info.txt";
        bool isLocked;
   


        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            if (File.Exists(filePath))
            {
                if(isLocked)
                {
                    LockData();
                }
            }
        }

        //hides the current Form and Opens The home Menu Form
        private void NextBtn_Click(object sender, EventArgs e)
        {
            //checks if file is is signed or not (islocked)
            if (isLocked)
            {
                MessageBox.Show("Form Submitted");
                this.Hide();
                Form0 form = new Form0();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sign first to continue");
            }

        }

        //saves and locks the Form on Click
        private void SignedBtn_Click(object sender, EventArgs e)
        {
            LockData();
            SaveData();
        }

        //saves users data into a text file
        private void SaveData()
        {
            //creates StreamWriter to write user data from Form contorls to the file
            StreamWriter sw = new StreamWriter(filePath, true);

            sw.WriteLine(NameTextBox.Text);
            sw.WriteLine(IdTextBox.Text);
            sw.WriteLine(EmailTextBox.Text);
            sw.WriteLine(FacultyName.Text);
            sw.WriteLine(dateTimePicker2.Value.ToString());
            sw.WriteLine(CourseNameAndNum.Text);
            sw.WriteLine(AssignmentNumOrExam.Text);
            sw.WriteLine(DepartmentStudent.Text);
            sw.WriteLine(TermOrSemester.Text);
            sw.WriteLine(ViolationReasonBox.Text);
            sw.WriteLine(checkBox1.Checked);
            sw.WriteLine(checkBox2.Checked);
            sw.WriteLine(FacultyMemberName.Text);
            sw.WriteLine(FacultyDate.Value);
            sw.WriteLine("===");
            sw.Close();


        }

        //makes all the components readOnly, locking for users to make changes 
        private void LockData()
        {
            isLocked = true;

            foreach (Control contorl in this.Controls)
            {
                if (contorl is TextBox textbox)
                {
                    textbox.ReadOnly = true;
                    textbox.BackColor = Color.Gray;
                }

                if (contorl is RichTextBox textbox1)
                {
                    textbox1.ReadOnly = true;
                    textbox1.BackColor = Color.Gray;
                }

                if (contorl is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Enabled = false;
                }

                if (contorl is CheckBox checkbox)
                {
                    checkbox.Enabled = false;
                }
            }
            
        }

        //loads all the data stored in the text file
        private void LoadData()
        {
           
            if (File.Exists(filePath))
            {
                try
                {
                    //creates a StreamReader to read the file
                    StreamReader sr = new StreamReader(filePath);

                    //reads texts lines one by one and populate its value to contorls in the from
                    NameTextBox.Text = sr.ReadLine();
                    IdTextBox.Text = sr.ReadLine();
                    EmailTextBox.Text = sr.ReadLine();
                    FacultyName.Text = sr.ReadLine();
                    dateTimePicker2.Value = DateTime.Parse(sr.ReadLine());
                    CourseNameAndNum.Text = sr.ReadLine();
                    AssignmentNumOrExam.Text = sr.ReadLine();
                    DepartmentStudent.Text = sr.ReadLine();
                    TermOrSemester.Text = sr.ReadLine();
                    ViolationReasonBox.Text = sr.ReadLine();
                    checkBox1.Checked = bool.Parse(sr.ReadLine());
                    checkBox2.Checked = bool.Parse(sr.ReadLine());
                    FacultyMemberName.Text = sr.ReadLine();
                    FacultyDate.Value = DateTime.Parse(sr.ReadLine());

                    //if file reads "===" set the bool value true
                    if(sr.ReadLine() == "===")
                    {
                        isLocked = true;
                    }

                    sr.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("File Your Form");
                }

            }
            

        }

        //Returns to home without saving
        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form0 form0 = new Form0();
            form0.ShowDialog();
        }
    }
}
