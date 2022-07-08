using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 抽獎
{
    public partial class players : Form
    {


        public players()
        {
            InitializeComponent();
        }





        private void button1_Click_1(object sender, EventArgs e)
        {

            string[] choose = new string[40];

            int i = 0;

            foreach (object x in listBox1.SelectedItems)
            {

                choose[i] = x.ToString();

                i++;

            }

            foreach (string k in choose)
            {
                if (k != null)
                {
                    // MessageBox.Show(k);
                    listBox2.Items.Add(k);
                    listBox1.Items.Remove(k);
                }

            }





        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] choose_1 = new string[40];

            int i = 0;

            foreach (object x in listBox2.SelectedItems)
            {

                choose_1[i] = x.ToString();
                // MessageBox.Show(choose_1[i]);


                i++;

            }

            foreach (string k in choose_1)
            {
                if (k != null)
                {
                    // 
                    listBox1.Items.Add(k);
                    listBox2.Items.Remove(k);
                }

            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            List<string> list_string = new List<string>();

            List<char[]> list_char = new List<char[]>();

            List<char[]> list_char_sort = new List<char[]>();

            //將listbox 的文字 以String 類型 ，存到 list_string 
            foreach (string a in listBox1.Items)
            {

                list_string.Add(a);

            }

            //將list_string 以Char 陣列 類型傳到 list_char
            foreach (string b in list_string)
            {
                list_char.Add(b.ToCharArray());

            }

            int[] q = new int[3];
            int[] s = new int[40];
            int t;

            list_char_sort.Add(list_char[0]);
            if (char.IsDigit(list_char[0][0]))
            {
                q[0] = list_char[0][0] - '0';

            }
            if (char.IsDigit(list_char[0][1]))
            {
                q[1] = list_char[0][1] - '0';

            }
            if (char.IsDigit(list_char[0][2]))
            {
                q[2] = list_char[0][2] - '0';

            }
            MessageBox.Show("q" + q[0].ToString());
            MessageBox.Show("w" + q[1].ToString());
            MessageBox.Show("r" + q[2].ToString());

            s[0] = Int32.Parse(q[0].ToString() + q[1].ToString() + q[2].ToString());

            MessageBox.Show("s" + s[0].ToString());

            for (int c = 1; c < list_char.Count; c++)
            {
                for (int d = 0; d < 3; d++)
                {
                    if (char.IsDigit(list_char[c][d]))
                    {
                        q[d] = list_char[c][d] - '0';
                    }

                }

                s[c] = Int32.Parse(q[0].ToString() + q[1].ToString() + q[2].ToString());

                for (int i = 0; i < c - 1; i++)
                {
                    if (s[c] < s[i])
                    {
                        t = s[i];
                        s[i] = s[c];
                        s[c] = t;
                    }
                }

            }




            //foreach (char c in b)
            //{
            //    if (Char.IsDigit(c))
            //    {
            //       // MessageBox.Show(c.ToString());
            //    }
            //}

            //list_1.Sort();
            foreach (var item in list_string)
            {
                listBox2.Items.Add(item);
            }

        }
    }
}
