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
        int currentLine;
        string filePath = "info.txt";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SignedStudent_Click(object sender, EventArgs e)
        {
            StudentLockData();
        }


        private void SignedFaculty_Click(object sender, EventArgs e)
        {
            LockDataFaculty();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            SaveData();
            

        }

        private void SaveData()
        {
            if (File.Exists(filePath))
            {
                StreamWriter sw = new StreamWriter(filePath, true);

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
                    using (var reader = File.OpenText(filePath))
                    {
                        while (reader.ReadLine() != "===")
                        {
                            currentLine++;
                        }
                    }
                    StreamReader sr = new StreamReader(filePath);


                    for (int i = 0; i < currentLine + 1; i++)
                    {
                        sr.ReadLine();
                    }
                    Form2StudentTxtBox.Text = sr.ReadLine();
                    radioButton2.Checked = bool.Parse(sr.ReadLine());
                    radioButton1.Checked = bool.Parse(sr.ReadLine());
                    MyTruEmail.Text = sr.ReadLine();
                    dateTimePicker1.Value = DateTime.Parse(sr.ReadLine());
                    FacultyNameTextBox.Text = sr.ReadLine();
                    dateTimePicker2.Value = DateTime.Parse(sr.ReadLine());
                    sr.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
                

        }

        private void StudentLockData()
        {
            Form2StudentTxtBox.ReadOnly = true;
            Form2StudentTxtBox.BackColor = Color.Gray;

            MyTruEmail.ReadOnly = true;
            MyTruEmail.BackColor = Color.Gray;

            dateTimePicker1.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void LockDataFaculty()
        {
            FacultyNameTextBox.ReadOnly = true;
            FacultyNameTextBox.BackColor = Color.Gray;

            dateTimePicker2.Enabled = false;
            
        }

    }
}

//reference
//https://stackoverflow.com/questions/119559/determine-the-number-of-lines-within-a-text-file
