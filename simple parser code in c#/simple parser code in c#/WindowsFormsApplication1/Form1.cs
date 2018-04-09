using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.calitha.commons;
using com.calitha.goldparser;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        MyParser pars;
        public Form1()
        {
            InitializeComponent();
            pars = new MyParser("fun-class.cgt", listBox1,listView1);
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listView1.Items.Clear();
            pars.Parse(richTextBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

      
    }
}
