using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJF_Premetive_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int n; //??????
        public ClassProcess[] arr; //?????


        private void butenter_Click(object sender, EventArgs e)
        {
            if (butenter.BackColor == Color.LightCyan)
            {
                if (numericUpDown1.Value.ToString() == "0")
                {
                    MessageBox.Show("Pleas Enter Process  Number ... !!");
                }
                else
                {
                    n = int.Parse(numericUpDown1.Value.ToString()); //?????
                    arr = new ClassProcess[n];
                    butenter.Text = "Enter Success";
                    butenter.BackColor = Color.Tomato;
                    numericUpDown1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Note: Process Number Had Entered >>>>" + n + "Process"); //?????
            }
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                MessageBox.Show("First You Must Enter The Process Number ...");
                textBox1.Text = "   ";
                textBox2.Text = "   ";
                textBox3.Text = "   ";
            }
            else
            {
                if (n != 0)
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Firt You Must Enter >>>> Process ID, Arrival Time, Burst Time");
                    }
                    else
                    {
                        if (int.Parse(textBox1.Text) >= 1 && int.Parse(textBox1.Text) <= n)
                        {
                            ///////////////////////
                            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                            {
                                ClassProcess a = new ClassProcess(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                                arr[int.Parse(textBox1.Text) - 1] = a; //????
                                textBox1.Text = "   ";
                                textBox2.Text = "   ";
                                textBox3.Text = "   ";
                                MessageBox.Show("Process Add Successfuly");

                            }
                            else
                            {
                                MessageBox.Show("You Must Enter >>>> Process ID, Arrival Time, Burst Time");
                            }
                            //////////////////////////
                        }

                        else
                        {
                            MessageBox.Show("There Is Error >>>> You Must Enter The Process ID , Must Be From 1 to " + n);
                        }
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                MessageBox.Show("First You Must Enter The Process Number ...");
                textBox1.Text = "   ";
                textBox2.Text = "   ";
                textBox3.Text = "   ";
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("You Must Enter The Process ID To Can Remove It ...");
                }
                else
                {
                    if (int.Parse(textBox1.Text) >= 1 && int.Parse(textBox1.Text) <= n)
                    {
                        arr[int.Parse(textBox1.Text) - 1] = null; //?????
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        MessageBox.Show("The Process Removed Successfully");
                    }
                    else
                    {
                        MessageBox.Show("The Number You Had Entered Not Found" + int.Parse(textBox1.Text));
                        textBox1.Clear();//?????????
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < arr.Length; c++)
            {
                arr[c].size_burst = arr[c].burst;
            }
            ///////////////////////////////////////////////////////
            /*----------------------------------------------------*/
            SJF_Preemptive_ x = new SJF_Preemptive_();
            int y = x.sjf_pree(arr); //بتحسب كل حاجه  && السالب واحد بيرجع وبيتحط فى الواى هنا
            for (int i = 0; i < arr.Length; i++) //هنعمل لوب يلف على عناصر الارراى كلها ويطبعها فى الجريد فيوو
            {
                dataGridView1.Rows.Add(arr[i].id, arr[i].arrival, arr[i].size_burst, arr[i].start, arr[i].wait, arr[i].finish, arr[i].TA);
            }//عشان اضيف صف جديد فى الجدريد فيو واطبعه
        }
    }
}
