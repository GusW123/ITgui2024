using System;
using System.Windows.Forms;

namespace School_of_Code
{
    public partial class form1 : Form
    {
        public static string testString = "Data from form1";

        public form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        // does nothing
  

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            txtName.Visible = true;

        }


        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        // does nothing
        private void button3_Click(object sender, EventArgs e)
        {
            btnExplain.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            lbloutput.Visible = false;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void nextpage_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = this.Location;
            f2.Show();
            this.Hide();
        }

        private void txtmax_TextChanged(object sender, EventArgs e)
        {  
           
            doALoop();
        
        }
        //private void Form1(object sender, EventArgs e)
        //{
        //    txtmin.Focus();
        //}


        private void name_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text;
            btnShow.Text = "Hi "+  name +", thanks for choosing to play (or being forced to grade) my coding game. Here you will learn several basic skills which you will be able to use to code in C#. To start we will begin with a simple example of some c# coding. \r\n";
            btnShow.Visible = true;
        }

        private void txtmin_TextChanged(object sender, EventArgs e)
          {
      doALoop();
    }

        //doAloop function 
        private void doALoop()
        {
            lbloutput.Text = "";
            outnum.Text = txtmax.Text;
            outnum2.Text = txtmax.Text;
            outmin.Text = txtmin.Text;
            outmin2.Text = txtmin.Text;
            //  String input;
            //     int parsedValue;
            //     if (int.TryParse(!txtmin.Text, out parsedValue))

            //    int integer;
            //     int i;
            //     if (Int32.TryParse(txtmin.Text, out integer)); int i = Convert.ToInt32(txtmax.Text); i++);
            //        { }
            //    input = txtmin.Text;

            //   if (!int.TryParse(input, out Convert.ToInt32(txtmin.Text); i < Convert.ToInt32(txtmax.Text); i++);
            //   { }

            //  doALoop();


            bool isMin, isMax;
            int min = 0, max = 0;
            string shape = "";

            isMin = int.TryParse(txtmin.Text, out min);
            isMax = int.TryParse(txtmax.Text, out max);

            //   txtmin.Text = "1";
            //         txtmax.Text = "10";


            if (isMin)
            {
                if (isMax && max > 0)
                {
                    if (min >= 0)
                    {
                        if (min < max && max > 0)
                        {
                            for (int i = min; i <= max; i++)
                            {
                                for (int j = min; j <= max; j++)
                                {
                                    shape += "*";
                                }
                                shape += "\n";
                            }
                        }
                        else
                        {
                            MessageBox.Show("min must be less than max", "Min Problem");
                            txtmin.Clear();
                            txtmin.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("min must be zero or above", "Min Problem");
                        txtmin.Clear();
                        txtmin.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("please enter integers", "Max problem");
                    txtmax.Clear();
                    txtmax.Focus();
                }
            }
            else
            {
                MessageBox.Show("min is not an integer", "Min problem");
                txtmin.Clear();
                txtmin.Focus();
            }
            lbloutput.Text = shape;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            button4.Visible = true;
            lbloutput.Visible = true;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            outmin.Visible = true;
            outmin2.Visible = true;
            outnum.Visible = true;
            outnum2.Visible = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }

      
    }



    /* private void doALoop()
     {
         int min, max;
         bool minPass = int.TryParse(txtmin.Text, out min);
         bool maxPass = int.TryParse(txtmax.Text, out max);

         if (minPass && maxPass)
         {
             for (int i = min; i < max; i++)
             {
                 for (int j = min; j < max; j++)
                 {
                     lbloutput.Text = String.Format("{0}* ", lbloutput.Text);
                 }
                 lbloutput.Text = String.Format("{0}\n", lbloutput.Text);

                 
                 valid.Visible = false;
             }
         }
         else valid.Visible = true;    */

      
    
    
