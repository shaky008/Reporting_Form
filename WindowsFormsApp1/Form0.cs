/*
 * File: Form0.cs
 * Author: [Utsav Shakya]
 * Description:This is the Main Home Screen where user can see all the forms and search the requied text
 * References:
 * https://stackoverflow.com/questions/1499049/foreach-control-in-form-how-can-i-do-something-to-all-the-textboxes-in-my-form
 * https://stackoverflow.com/questions/119559/determine-the-number-of-lines-within-a-text-file
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        //opens Form1 GUI
        private void Form1Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        //opens Form2 GUI
        private void Form2Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        //opens Form3 GUI
        private void Form3Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        //opens Form4 GUI
        private void Form4Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        //Exits from the application
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exting From Application");
            Application.Exit();
        }

        //searches the text user is looking for
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search(KeyWord.Text);
        }

        //delete file if exist
        private void DeleteFileBtn_Click(object sender, EventArgs e)
        {
            if(File.Exists("info.txt"))
            {
                File.Delete("info.txt");
            }
            MessageBox.Show("File Deleted");
        }

        public void Search(string text)
        {
            var pstartinfo = new ProcessStartInfo();

            pstartinfo.FileName = @"C:\Users\sshak\AppData\Local\Microsoft\WindowsApps\python.exe";

            var script = "Class1.py";

            pstartinfo.UseShellExecute = false;
            pstartinfo.CreateNoWindow = true;
            pstartinfo.RedirectStandardOutput = true;
            pstartinfo.RedirectStandardError = true;

            pstartinfo.Arguments = $"\"{script} \"{text}\"";

            using (Process process = Process.Start(pstartinfo))
            {
                string error = process.StandardError.ReadToEnd();
                string output = process.StandardOutput.ReadToEnd();

                MessageBox.Show($"Output: {output}");
            }

        }



      
    }
}
