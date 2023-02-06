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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filePath = textBox2.Text;
            if (!File.Exists("Z:\\Practice\\" + filePath + ".txt")) // If file does not exists
            {
                var newFile = File.Create("Z:\\Practice\\" + filePath + ".txt"); // Create file
                newFile.Close();
            }
            else
            {
                string message = "This File already exists.";
                MessageBox.Show(message);
            }
            this.Close();
            this.InitializeComponent();
        }
    }
}
