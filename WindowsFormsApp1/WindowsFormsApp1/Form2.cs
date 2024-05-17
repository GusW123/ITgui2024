using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_of_Code 
{
   
    public partial class Form2 : Form
    {
        int L = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
     
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.Text == "Write")
           label1.Text = "Correct!";
            if (comboBox1.Text == "Type")
                label1.Text = "Try again!";
            L++;
            if (comboBox1.Text == "Enter")
                label1.Text = "*incorrect buzzer sound*";
            L++;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            comboBox1.Visible = true;
            label9.Visible = true;
            comboBox2.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "class")
                label9.Text = "Correct!";
            if (comboBox2.Text == "school")
                label9.Text = "Try again";
            L++;
            if (comboBox2.Text == "conglomerate")
            label9.Text = "Wrong answer buddy";
            L++;
            if (comboBox2.Text == "group")
                label9.Text = "Wrong as always";
            L++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
        }

        private void nextpage_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.StartPosition = FormStartPosition.Manual;
            f3.Location = this.Location;
            f3.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }
    }
}
