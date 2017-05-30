using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 2;

            //DirectoryInfo di = new DirectoryInfo(@"C:\Users\netumantram\Downloads");

            DirectoryInfo di = new DirectoryInfo(@textBox1.Text);

            Console.WriteLine("No search pattern returns:");
            foreach (var fi in di.GetFiles())
            {
                richTextBox1.Text += fi.Name + "\n";
                //Console.WriteLine(fi.Name);
                dataGridView1.Rows.Add( fi.Name, fi.Length);   

            }

            /*
            foreach (var fi in di.GetFiles("*", SearchOption.AllDirectories))
            {
                richTextBox1.Text += fi.Name + "\n";
                //Console.WriteLine(fi.Name);
                dataGridView1.Rows.Add(fi.Name, fi.Length);

            }
             */

        }
    }
}
