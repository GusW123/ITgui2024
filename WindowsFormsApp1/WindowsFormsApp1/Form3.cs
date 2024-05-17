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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

     //  private void button1_Click(object sender, EventArgs e)
   //     {
     //       {
  //              string[] allLines = txtMultiline.Text.Split('\n');
    //            int count = 1;
    //            lblOutput.Text = "Hello";
    //            foreach (string line in allLines)
   //             {
      //              lblOutput.Text = String.Format("{0}{1} {2}\n", lblOutput.Text, count, line);
     //               count++;
//                }
 ///           }
    //    }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void end_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
