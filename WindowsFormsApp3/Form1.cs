using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string username { get; set; }
        float age { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void NAME_TextChanged(object sender, EventArgs e)
        {

            submit.Enabled = (NAME.Text.Length >= 2) ? true : false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(textBox1.Text);
                submit.Enabled = true;
            }
            catch 
            {
                submit.Enabled = false;
            }


            

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            submit.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            username = NAME.Text;

            //OPTION1
            //age = Convert.ToSingle(textBox1.Text);

            //OPTION2
            age = float.Parse(textBox1.Text);

            ////option3
            //float tempfloat;
            //bool result = float.TryParse(textBox1.Text, out tempfloat);
            //age = tempfloat;


            outputlabel.Text = NAME.Text + " " + textBox1.Text;

            clearform();
        }

        private void clearform()
        {
            NAME.Clear();
            textBox1.Clear();

        }

        private void outputlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
