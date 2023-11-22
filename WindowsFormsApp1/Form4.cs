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
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form Submited");
            Application.Exit();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveData();
            
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SaveData()
        {
            if (File.Exists(filePath))
            {
                StreamWriter sw = new StreamWriter(filePath, true);

                sw.WriteLine(richTextBox1.Text);
                sw.WriteLine(richTextBox2.Text);

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
                    richTextBox2.Text = sr.ReadLine();   
                    sr.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        
    }
}
