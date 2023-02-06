namespace Lifting_Program
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var createNewFile = new Form2();
            createNewFile.Show();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }


        //Push File
        private void button2_Click(object sender, EventArgs e)
        {
            var newPush = new Push(textBox16.Text, textBox2.Text, textBox3.Text, textBox1.Text, textBox4.Text);
            this.Controls.Clear();
            this.InitializeComponent();
        }

        /*//Pull File
        private void button7_Click(object sender, EventArgs e)
        {
            var newPull = new Pull(textBox7.Text, textBox11.Text, textBox10.Text, textBox12.Text, textBox5.Text);
            this.Controls.Clear();
            this.InitializeComponent();
        
        }

        //Legs File
        private void button9_Click(object sender, EventArgs e)
        {
            var newLegs = new Legs(textBox8.Text, textBox14.Text, textBox13.Text, textBox15.Text, textBox6.Text);
            this.Controls.Clear();
            this.InitializeComponent();
        }*/

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var createNewFile = new Form2();
            createNewFile.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var createNewFile = new Form2();
            createNewFile.Show();
        }

        private void textBox16_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var pastWorkout = new Form3();
            pastWorkout.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var maxConv = new Form4();
            maxConv.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var exerciseInfo = new Form5();
            exerciseInfo.Show();
        }
    }
}