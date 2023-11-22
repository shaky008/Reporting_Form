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
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LockData1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LockData2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void SaveBtnForm3_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void LockData1()
        {
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

        private void LockData2()
        {
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

        private void saveData()
        {
            
            if (File.Exists(filePath))
            {
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

        private void loadData()
        {
            if (File.Exists(filePath))
            {
                try 
                {
                    using(var reader = File.OpenText(filePath))
                    {
                        while(reader.ReadLine() !="+++")
                        {
                            currentLine++;
                        }
                    }
                    StreamReader sr = new StreamReader(filePath);

                    for(int i = 0; i < currentLine+1; i++)
                    {
                        sr.ReadLine();
                    }

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
                    sr.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        
    }
}
