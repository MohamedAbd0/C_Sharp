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


namespace balansed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exp = textBox1.Text;
            Stack s = new Stack();
            foreach (char item in exp)
            {
                if (item == '(')
                {
                    s.Push(item);
                }
                else if(item ==')')
                {
                    if (s.Count == 0)
                    {
                        MessageBox.Show("not balanced");
                        return;
                    }
                    s.Pop();
                }
            }
            if(s.Count==0)
            {
                MessageBox.Show("balanced");
            }
            else
            {
                MessageBox.Show("not balanced");
            }
        }
    }
}
