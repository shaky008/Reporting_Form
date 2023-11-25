/*
 * File: Form4.cs
 * Description: This file contains the code for Form4 of the Windows Forms application.
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
    public partial class Form4 : Form
    {
        string filePath = "info.txt";
        int currentLine;
        bool isLocked, isLocked2;
        public Form4()
        {
            InitializeComponent();
            LoadData();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(isLocked && isLocked2)
            {
                MessageBox.Show("Form Submited");
                this.Hide();
                Form0 form = new Form0();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Save first");
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            LockData();
            SaveData();

            
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveData()
        {
            if (File.Exists(filePath))
            {
                StreamWriter sw = new StreamWriter(filePath, true);

                sw.Write(richTextBox1.Text);
                sw.WriteLine(richTextBox2.Text);
                

                sw.Close();
            }
           
        }

        private void LockData()
        {
            if (File.Exists(filePath))
            {
                isLocked = true;
                isLocked2 = true;

                foreach (Control contorl in this.Controls)
                {
                    if (contorl is RichTextBox richTextBox)
                    {
                        richTextBox.ReadOnly = true;
                    }
                }
            }
        }

        //returns home menu without saving
        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form0 form0 = new Form0();
            form0.ShowDialog();
        }

        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    using (var reader = File.OpenText(filePath))
                    {
                        while(reader.ReadLine() != "---")
                        {
                            currentLine++;
                        }
                    }

                    StreamReader sr = new StreamReader(filePath);

                    for(int i = 0; i < currentLine+1; i++)
                    {
                        sr.ReadLine();
                    }
                    
                    richTextBox1.Text = sr.ReadLine();
                    richTextBox2.Text = sr.ReadToEnd();
                    if(sr.ReadLine()=="$$$")
                    {
                        isLocked = true;
                        isLocked2 = true;
                    }

                    sr.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show("File the form");
                }
            }
        }

        
    }
}
