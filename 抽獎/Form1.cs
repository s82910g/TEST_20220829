using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 抽獎
{
    public partial class Form1 : Form
    {
        string[] gift = new string[100];
        int count_gift=0;
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arr = new string[1];
            arr[0] = "12";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            players pl = new players();
            pl.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "";

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //string gift_name = "";
           
            gift[count_gift] =textBox1.Text ;
            string gift_name = gift[0];
           
            for (int i=1;i<=count_gift; i++)
            {

                gift_name +="、"+ gift[i];
            }
            label3.Text = gift_name;
            count_gift++;

         //   MessageBox.Show(count_gift.ToString());
            
            textBox1.Text = "";
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        
    }
}
