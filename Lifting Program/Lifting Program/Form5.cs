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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] filePath = Directory.GetFiles("Z:\\Practice\\Exercise\\");

            foreach (string files in filePath)
            {
                comboBox1.Items.Add(Path.GetFileName(files));
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Z:\\Practice\\Exercise\\" + comboBox1.Text);
            var filedata = sr.ReadToEnd();
            //pictureBox1.Image = Image.FromFile(filedata);
            sr.Close();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            int select = comboBox1.SelectedIndex;
            switch (select)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile("Z:\\Practice\\Exercise\\images\\Sports_Waterbottle.png");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile("Z:\\Practice\\Exercise\\images\\welcome_ACI.png");
                    break;
                /*case 2:
                    pictureBox1.Image = Image.FromFile("..\\..\\Images\\cat3.jpg");
                    break;
            */
            }


            if (comboBox1.Text == "bench.txt")
            {
                textBox1.Text = "Chest";
            }
            else if (comboBox1.Text == "squat.txt")
            {
                textBox1.Text = "Glutes/Hamstrings";
            }
            else if (textBox1.Text == "shoulder press") ;
            else
            {
                textBox1.Text = "Back";
            }
        }
    }
}
