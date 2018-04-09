using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory_allocation
{
    public partial class Form1 : Form
    {
        List<int> lst = new List<int>();
        List<block> lstblock = new List<block>();
        int[] block;
        string operation;
       // bool target, target2, target3, target4 = false;
        int help=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpro.Text == "")
            {
                MessageBox.Show("PLS enter the process......");
            }
            else
            {
                lst.Add(int.Parse(txtpro.Text));
                txtpro.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtb1.Text == "" || txtb2.Text == "" || txtb3.Text == "" || txtb4.Text == "")
            {
                MessageBox.Show("PLS full your Block Size ");
            }
            else
            {
                block b1 = new block(int.Parse(txtb1.Text), false);
                lstblock.Add(b1);
                block b2 = new block(int.Parse(txtb2.Text), false);
                lstblock.Add(b2);
                block b3 = new block(int.Parse(txtb3.Text), false);
                lstblock.Add(b3);
                block b4 = new block(int.Parse(txtb4.Text), false);
                lstblock.Add(b4);
                MessageBox.Show("Size Update..........");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rfrist_fit.Checked == true || rn.Checked == true )
            {
                 lwait.Text = "";
                switch (operation)
                {
                    case "Frist Fit":

                        for (int i = 0; i < lst.Count; i++)
                        {
                            foreach (block item in lstblock)
                            {
                                if (lst[i] <= item.block_size && item.flag == false)
                                {
                                    item.storage = lst[i];
                                    item.flag = true;
                                    break;
                                }

                            }
                        }

                        break;

                    case "Next Fit":
                        for (int i = 0; i < lst.Count; i++)
                        {
                            for (int j = 0 + help; j < lstblock.Count; j++)
                            {
                                if (lst[i] <= lstblock[j].block_size && lstblock[j].flag == false)
                                {
                                    lstblock[j].storage = lst[i];
                                    lstblock[j].flag = true;
                                    help = j;
                                    break;
                                }
                            }
                        }
                        break;

                    case "Best Fit":
                        for (int i = 0; i < lst.Count; i++)
                        {
                            foreach (block item in lstblock)
                            {
                                if (lst[i] <= item.block_size && item.flag == false)
                                {
                                    item.storage = lst[i];
                                    item.flag = true;
                                    break;
                                }


                            }
                        }
                        break;

                    default:
                        MessageBox.Show("not found");
                        break;

                    
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows.Clear();
                }
            int m=1;
            foreach (block item in lstblock)
            {
                dataGridView1.Rows.Add("Block " + m, item.block_size, item.storage);
                m++;
                
            }
            foreach (block item in lstblock)
            {
                if (item.storage==0)
                {
                    lwait.Text = "There are  process Is Waiting  " ;
                }
            }
            }
            else
            {
                MessageBox.Show("PLS Checked The type of operation...........");

            }
        }

        private void rfrist_fit_CheckedChanged(object sender, EventArgs e)
        {
            operation = rfrist_fit.Text;
        }

        private void rn_CheckedChanged(object sender, EventArgs e)
        {
            operation = rn.Text;
        }

        

        
    }
}
