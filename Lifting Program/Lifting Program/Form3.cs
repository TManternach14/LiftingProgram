using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifting_Program
{
    public partial class Form3 : Form
    {
        private string[] lines;
        private int index = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filePath = comboBox1.SelectedItem;
            if (!File.Exists("Z:\\Practice\\" + filePath)) // If file does not exists
            {
                MessageBox.Show("File does not exist.");
            }
            else
            {
                StreamReader sr = new StreamReader("Z:\\Practice\\" + filePath);
                string filedata = sr.ReadToEnd();
                richTextBox2.Text = filedata.ToString();
                sr.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] filePath = Directory.GetFiles("Z:\\Practice\\");

            foreach (string files in filePath)
            {

                comboBox1.Items.Add(Path.GetFileName(files));

            }
        }
    }
}
