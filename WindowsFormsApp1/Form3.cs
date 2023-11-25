/*
 * File: Form3.cs
 * Description: This file contains the code for Form3 of the Windows Forms application.
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
    public partial class Form3 : Form
    {
        int currentLine;
        string filePath = "info.txt";
        bool isLocked, isLocked2;
        public Form3()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if(File.Exists(filePath))
            { 
                if(isLocked)
                {
                    LockData1();
                    
                }

                if(isLocked2)
                {
                    LockData2();
                }
                
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LockData1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LockData2();
            SaveData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isLocked && isLocked2)
            {
                MessageBox.Show("Form Submitted");
                this.Hide();
                Form0 form = new Form0();
                form.ShowDialog();
            }
        }

        private void LockData1()
        {
            isLocked = true;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            DepartmentName.ReadOnly = false;
            DepartmentName.BackColor = Color.Gray;

            NoExplainRichTxtBox.ReadOnly = false;
            NoExplainRichTxtBox.BackColor = Color.Gray;

            CommentTxBox.ReadOnly = false;
            CommentTxBox.BackColor = Color.Gray;

            dateTimePicker1.Enabled = false;
        }

        //makes form contorl of second part readOnly
        private void LockData2()
        {            
            isLocked2 = true;

            radioButton3.Enabled = false;
            radioButton4.Enabled = false;

            NoExplain2.ReadOnly = false;
            NoExplain2.BackColor = Color.Gray;

            Comment2.ReadOnly = false;
            Comment2.BackColor = Color.Gray;

            DeanName.ReadOnly = false;
            DeanName.BackColor = Color.Gray;

            dateTimePicker2.Enabled = false;
        }

        private void SaveData()
        {
            
            if (File.Exists(filePath))
            {
                //creates StreamWriter to write from Form controls to text file
                StreamWriter sw = new StreamWriter(filePath, true);
                sw.WriteLine(radioButton1.Checked);
                sw.WriteLine(radioButton2.Checked);
                sw.WriteLine(NoExplainRichTxtBox.Text);
                sw.WriteLine(CommentTxBox.Text);
                sw.WriteLine(DepartmentName.Text);
                sw.WriteLine(dateTimePicker1.Value.ToString());
                sw.WriteLine(radioButton3.Checked);
                sw.WriteLine(radioButton4.Checked);
                sw.WriteLine(NoExplain2.Text);
                sw.WriteLine(Comment2.Text);
                sw.WriteLine(DeanName.Text);
                sw.WriteLine(dateTimePicker2.Value.ToString());
                sw.WriteLine("---");
                sw.Close();
            }
        }

        //returns home menu without saveing
        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form0 form0 = new Form0();
            form0.ShowDialog();
        }

        //Loads data from text file
        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                try 
                {
                    //increments currentline before reaching the value "+++"
                    using(var reader = File.OpenText(filePath))
                    {
                        while(reader.ReadLine() !="+++")
                        {
                            currentLine++;
                        }
                    }
                    //creates a StreamReader to read file
                    StreamReader sr = new StreamReader(filePath);

                    //readline until currentLine
                    for(int i = 0; i < currentLine+1; i++)
                    {
                        sr.ReadLine();
                    }

                    //starts reading after "+++" and populate From's contorls
                    radioButton1.Checked = bool.Parse(sr.ReadLine());
                    radioButton2.Checked = bool.Parse(sr.ReadLine());
                    NoExplainRichTxtBox.Text = sr.ReadLine();
                    CommentTxBox.Text = sr.ReadLine();
                    DepartmentName.Text = sr.ReadLine();
                    dateTimePicker1.Value = DateTime.Parse(sr.ReadLine());
                    radioButton3.Checked = bool.Parse(sr.ReadLine());
                    radioButton4.Checked = bool.Parse(sr.ReadLine());
                    NoExplain2.Text = sr.ReadLine();
                    Comment2.Text = sr.ReadLine();
                    DeanName.Text = sr.ReadLine();
                    dateTimePicker2.Value = DateTime.Parse(sr.ReadLine());

                    //sets bool value to true if --- is read
                    if(sr.ReadLine() == "---")
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

        
    }
}
