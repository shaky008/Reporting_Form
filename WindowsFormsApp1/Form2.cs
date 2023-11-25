/*
 * File: Form2.cs
 * Description: This file contains the code for Form2 of the Windows Forms application.
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        //variable for counting line in file, the filePath and form lockings respectively
        int currentLine;
        string filePath = "info.txt";
        bool isLocked, isLocked2;

        public Form2()
        {
            InitializeComponent();
            LoadData();
        }

        //loads the data when the form is opened
        private void Form2_Load(object sender, EventArgs e)
        {
           if (File.Exists(filePath))
            {
                
                if (isLocked)
                {
                    StudentLockData();
                    
                }
                if(isLocked2)
                {
                    LockDataFaculty();
                }
            }
        }

        private void SignedStudent_Click(object sender, EventArgs e)
        {
            StudentLockData();
        }


        private void SignedFaculty_Click(object sender, EventArgs e)
        {
            LockDataFaculty();
            SaveData();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (isLocked && isLocked2)
            {
                MessageBox.Show("Form Submitted");
                this.Hide();
                Form0 form = new Form0();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Save and Sign to continue");
            }

        }

        private void SaveData()
        {
            if (File.Exists(filePath))
            {
                //creates a streamWriter to write data to the file
                StreamWriter sw = new StreamWriter(filePath, true);

                //writes data from the users to the text file
                sw.WriteLine(Form2StudentTxtBox.Text);
                sw.WriteLine(radioButton2.Checked);
                sw.WriteLine(radioButton1.Checked);
                sw.WriteLine(MyTruEmail.Text);
                sw.WriteLine(dateTimePicker1.Value.ToString());
                sw.WriteLine(FacultyNameTextBox.Text);
                sw.WriteLine(dateTimePicker2.Value.ToString());
                sw.WriteLine("+++");
                sw.Close();
            }
          
        }

        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    //reads the file and increment each line before it reaches "==="
                    using (var reader = File.OpenText(filePath))
                    {
                        while (reader.ReadLine() != "===")
                        {
                            currentLine++;
                        }
                    }
                    //creates StreamReadaer to read the file
                    StreamReader sr = new StreamReader(filePath);

                    //reads the line until the currentline+1 (skip)
                    for (int i = 0; i < currentLine + 1; i++)
                    {
                        sr.ReadLine();
                    }
                    //starts reading after "==="from the textfile and populate form contorls
                    Form2StudentTxtBox.Text = sr.ReadLine();
                    radioButton2.Checked = bool.Parse(sr.ReadLine());
                    radioButton1.Checked = bool.Parse(sr.ReadLine());
                    MyTruEmail.Text = sr.ReadLine();
                    dateTimePicker1.Value = DateTime.Parse(sr.ReadLine());
                    FacultyNameTextBox.Text = sr.ReadLine();
                    dateTimePicker2.Value = DateTime.Parse(sr.ReadLine());
                    
                    //sets the bool values to true if the file reads "+++"
                    if(sr.ReadLine() == "+++")
                    {
                        isLocked = true;
                        isLocked2 = true;
                    }
                    sr.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("File the form");
                }
            }
                

        }

        //makes the first part of the controls in the form as readOnly
        private void StudentLockData()
        {
            isLocked = true;
           
            Form2StudentTxtBox.ReadOnly = true;
            Form2StudentTxtBox.BackColor = Color.Gray;

            MyTruEmail.ReadOnly = true;
            MyTruEmail.BackColor = Color.Gray;

            dateTimePicker1.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            
        }

        //makes the second part of the controls in the form as readOnly
        private void LockDataFaculty()
        {
            isLocked2 = true;
            FacultyNameTextBox.ReadOnly = true;
            FacultyNameTextBox.BackColor = Color.Gray;

            dateTimePicker2.Enabled = false;

        }

        //Returns to home without saving
        private void Home_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form0 form0 = new Form0();
            form0.ShowDialog();
        }

     


    }
}



