using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

//Alireza Gholami 
//2020-7-7

namespace WindowsFormsAppRedux1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit now?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }
            else
            {
                textBox1.Text = " ";
                button1.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Regex letter = new Regex(@"([a-d]|[m-p])");
            if (letter.IsMatch(textBox1.Text.Trim()))
            {
                string test;
                test = letter.Replace(textBox1.Text, "");
                MessageBox.Show("The text after removal  contains a,b,c,d, m,n,o,p :\n" + test);

            }
            else
            {
                MessageBox.Show("The text doesn't have targeted letters.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                Regex email = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");

                if (email.IsMatch(textBox1.Text))
                {
                     MessageBox.Show("The Email address is correct","Validation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                else
                {
                MessageBox.Show("The Email address is not correct", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                     textBox1.Clear();
                }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string withexspace = textBox1.Text;
            string singlespase = Regex.Replace(withexspace, " {2,}", " ");
            MessageBox.Show("Your phrase without extera spases :\n\n" + singlespase , "Removing Spases");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string test ;
            Regex postalcode = new Regex(@"^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$");

            
           test = postalcode.Replace(textBox1.Text.Trim(), " ");

            if (postalcode.IsMatch(test.ToUpper()))
            {
                MessageBox.Show("This "+ test +" Canadian postalcode is Valid", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Your postal code is not in correct format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox1.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {


            


           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Match match = Regex.Match(textBox1.Text, @"^\(\d{3}\) \d{3}-\d{4}$");                



            if (match.Success)
            {
                MessageBox.Show("Your Phone number is correct.\n" + match, "Phone Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Your Phone number is not in the correct format.\n Valid format: (XXX) XXX-XXXX", "Phone Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string input;
            Regex createarry = new Regex(@"\s+");
            string[] create = createarry.Split(textBox1.Text);
            input = create[0];
            for (int i = 0; i < create.Length; i++)
            {
                input += "\n" + create[i];

            }
            if (create.Length == 1 && create[0] == "")
            {
                MessageBox.Show("Your Array does't include any word :\n\n", "Spliter");
            }
            else {

                MessageBox.Show("Your Arry : \n" + input);
            }
        }
    }               
}
