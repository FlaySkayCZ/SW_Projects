using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }
        public int counter = 0;
        public int first;
        public int second;
        private void button_1_Click(object sender, EventArgs e)
        {
            if (textBox_Solution.Text == "0") { textBox_Solution.Text = "1"; }
            else { textBox_Solution.Text = textBox_Solution.Text + "1"; }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (textBox_Solution.Text == "0") { textBox_Solution.Text = "2"; }
            else { textBox_Solution.Text = textBox_Solution.Text + "2"; }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (textBox_Solution.Text == "0") { textBox_Solution.Text = "3"; }
            else { textBox_Solution.Text = textBox_Solution.Text + "3"; }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (textBox_Solution.Text == "0") { textBox_Solution.Text = "4"; }
            else { textBox_Solution.Text = textBox_Solution.Text + "4"; }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (textBox_Solution.Text == "0") { textBox_Solution.Text = "5"; }
            else { textBox_Solution.Text = textBox_Solution.Text + "5"; }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (textBox_Solution.Text == "0") { textBox_Solution.Text = "6"; }
            else { textBox_Solution.Text = textBox_Solution.Text + "6"; }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (textBox_Solution.Text == "0") { textBox_Solution.Text = "7"; }
            else { textBox_Solution.Text = textBox_Solution.Text + "7"; }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (textBox_Solution.Text == "0") { textBox_Solution.Text = "8"; }
            else { textBox_Solution.Text = textBox_Solution.Text + "8"; }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (textBox_Solution.Text == "0") { textBox_Solution.Text = "9"; }
            else { textBox_Solution.Text = textBox_Solution.Text + "9"; }
        }

        private void button_DeleteOne_Click(object sender, EventArgs e)
        {
            if (textBox_Solution.Text.Length == 1) { textBox_Solution.Text = "0"; }
            else { textBox_Solution.Text = textBox_Solution.Text.Remove(textBox_Solution.Text.Length - 1, 1); }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {

            counter++;
            if (counter == 1)
            {
                first = Int32.Parse(textBox_Solution.Text);
                labelComputation.Text = textBox_Solution.Text + "+";
                textBox_Solution.Text = "0";
            }
            else if (counter == 2)
            {
                counter = 0;
                second = Int32.Parse(textBox_Solution.Text);
                textBox_Solution.Text = Calculator.Add.add(first, second).ToString();
                first = Int32.Parse(textBox_Solution.Text);
                labelComputation.Text = first + "+";
            }


        }

        private void button_Subtract_Click(object sender, EventArgs e)
        {

            counter++;
            if (counter == 1)
            {
                first = Int32.Parse(textBox_Solution.Text);
                labelComputation.Text = textBox_Solution.Text + "-";
                textBox_Solution.Text = "0";
            }
            else if (counter == 2)
            {
                counter = 0;
                second = Int32.Parse(textBox_Solution.Text);


                textBox_Solution.Text = Calculator.Subtract.subtract(first, second).ToString();
                first = Int32.Parse(textBox_Solution.Text);
                labelComputation.Text = first + "-";


            }

        }

        private void button_Subdivide_Click(object sender, EventArgs e)
        {


            counter++;
            if (counter == 1)
            {
                first = Int32.Parse(textBox_Solution.Text);
                labelComputation.Text = textBox_Solution.Text + "/";
                textBox_Solution.Text = "0";
            }
            else if (counter == 2)
            {
                counter = 0;
                second = Int32.Parse(textBox_Solution.Text);
                if (second != 0)
                {
                    textBox_Solution.Text = Divide.divide(first, second).ToString();
                    first = Int32.Parse(textBox_Solution.Text);
                    labelComputation.Text = first + "/";
                }
                else
                {
                    MessageBox.Show("Dělíš nulou");
                    first = 0;
                    second = 0;
                    counter = 0;
                }
            }

        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter == 1)
            {
                first = Int32.Parse(textBox_Solution.Text);
                labelComputation.Text = textBox_Solution.Text + "-";
                textBox_Solution.Text = "0";
            }
            else if (counter == 2)
            {
                counter = 0;
                second = Int32.Parse(textBox_Solution.Text);


                textBox_Solution.Text = Calculator.Subtract.subtract(first, second).ToString();
                first = Int32.Parse(textBox_Solution.Text);
                labelComputation.Text = first + "-";


            }
        }

        private void button__0_Click(object sender, EventArgs e)
        {

            textBox_Solution.Text = textBox_Solution.Text + "0";
        }
    }
}
