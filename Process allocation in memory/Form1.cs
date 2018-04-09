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

namespace os_project
{
    public partial class Form1 : Form
    {

        List<Process> lst = new List<Process>();
        List<Process> ready = new List<Process>();
        List<Process> Ring = new List<Process>();
        int Start, Finish, WaitingTime, Ta, d;
        double sumta, sumwait;
        string g = "";

        string alogreism;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtburst.Text != "" && txtid.Text != "" && radioButton1.Checked == true || rdnon_pre.Checked == true || rd_pre.Checked == true)
            {
                fulllist();
            }
            else
                MessageBox.Show("Fell the textbox by data or  ch rd bt ?............ ");
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            fillgred();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                if (rdnon_pre.Checked == true || radioButton1.Checked == true)
                {
                    foreach (Process item in lst)
                    {
                        if (txtid.Text == item.Process_id)
                        {
                            lst.Remove(item);
                            fillgred();
                            clear();
                            MessageBox.Show("your process Done Remove..........");
                            break;
                        }
                    }

                }
                if (rd_pre.Checked == true)
                {
                    foreach (Process item in Ring)
                    {
                        if (txtid.Text == item.Process_id)
                        {
                            lst.Remove(item);
                            fillgred();
                            clear();
                            MessageBox.Show("your process Done Remove..........");
                            break;
                        }
                    }

                }


            }
            else
            {
                MessageBox.Show("PLS enter id .......?");
            }




        }

        private void rdnon_pre_CheckedChanged(object sender, EventArgs e)
        {
            alogreism = rdnon_pre.Text;
            txtarrival.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            alogreism = radioButton1.Text;
            txtarrival.Visible = false;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;

        }

        public void clear()
        {
            txtid.Text = txtburst.Text = txtarrival.Text = "";
        }

        public void fulllist()
        {
            if (radioButton1.Checked == true)
            {
                Process p = new Process(txtid.Text, "0", txtburst.Text);
                lst.Add(p);
                clear();
            }
            else if (rdnon_pre.Checked == true)
            {
                Process p = new Process(txtid.Text, txtarrival.Text, txtburst.Text);
                lst.Add(p);
                clear();
            }
            else
            {
                Process p = new Process(txtid.Text, txtarrival.Text, txtburst.Text);
                lst.Add(p);
                clear();
            }
        }

        public void fillgred()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows.Clear();
                Start = Finish = WaitingTime = Ta = d = 0;
                sumta = sumwait = 0;
            }

            switch (alogreism)
            {
                case "Non-Pre(Arr=0)":
                    Process.sortarray(lst);
                    foreach (Process item in lst)
                    {
                        Start = int.Parse(item.Arrival_Time) + d;
                        Finish = int.Parse(item.Burst_Time) + Start;
                        WaitingTime = Start;
                        Ta = Finish;
                        dataGridView1.Rows.Add(item.Process_id, item.Arrival_Time, item.Burst_Time, Start, Finish, WaitingTime, Ta);
                        d = Finish;
                        sumta += Ta;
                        sumwait += WaitingTime;
                        g += item.Process_id + " :: ";

                    }
                    lblavgta.Text = "THE AVG TA = " + (sumta / lst.Count);

                    lblavgwait.Text = "THE AVG Wait Time  = " + (sumwait / lst.Count);
                    label4.Text = g.Substring(0, g.Length - 3);



                    break;

                case "Non-Pre(Dif-Arr)":
                    Process.sortarray(lst);
                    Process.sortarray_ar(lst);
                    d = int.Parse(lst[0].Arrival_Time);
                    foreach (Process item in lst)
                    {
                        Start = d;
                        Finish = int.Parse(item.Burst_Time) + Start;
                        WaitingTime = Start - int.Parse(item.Arrival_Time);

                        if (WaitingTime < 0)
                        {
                            Start = int.Parse(item.Arrival_Time);
                            Finish = int.Parse(item.Burst_Time) + Start;
                            WaitingTime = Start - int.Parse(item.Arrival_Time);

                            Ta = WaitingTime + int.Parse(item.Burst_Time);

                        }

                        Ta = WaitingTime + int.Parse(item.Burst_Time);
                        dataGridView1.Rows.Add(item.Process_id, item.Arrival_Time, item.Burst_Time, Start, Finish, WaitingTime, Ta);
                        d = Finish;
                        sumta += Ta;
                        sumwait += WaitingTime;
                        g += item.Process_id + " :: ";
                    }
                    lblavgta.Text = "THE AVG TA = " + (sumta / lst.Count);
                    lblavgwait.Text = "THE AVG Wait Time  = " + (sumwait / lst.Count);
                    label4.Text = g.Substring(0, g.Length - 3);

                    break;

                case "Pre":
                    pr(lst);
                    break;
                default:
                    MessageBox.Show("ather checked ......");
                    break;
            }
        }

        private void rd_pre_CheckedChanged(object sender, EventArgs e)
        {
            alogreism = rd_pre.Text;
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
        }

        private void pr(List<Process> li)
        {
            Process current = li[0];
            g = current.Process_id+" :: ";
            bool flag = false;
            Process.Sort_arrival(li);
           
            for (int pt = int.Parse(li[0].Arrival_Time); pt <= Process.ProcessorTime(li) + int.Parse(li[0].Arrival_Time); pt++)
            {
                
                for (int i = 0; i < ready.Count; i++)
                {
                   
                    if (ready[i].Remaind == 0)
                    {
                        ready.RemoveAt(i);
                    }
                }
                if (ready.Count == 0)
                {
                    flag = false;
                }
                foreach (Process item in li)
                {
                    if (int.Parse(item.Arrival_Time) == pt)
                    {
                        ready.Add(item);
                        flag = true;
                    }
                }
                if (flag)
                {
                    Process.sortarrR(ready);
                    if (int.Parse(current.Burst_Time) == current.Remaind)
                    {
                        current.StartTime = pt;

                    }
                    if (current == ready[0])
                    {
                    }
                    else
                    {
                        current = ready[0];
                        g += current.Process_id + " :: ";
                    }
                    current.Remaind--;
                    if (current.Remaind == 0)
                    {
                        current.finishTime = pt + 1;
                        Ring.Add(current);
                    }
                }
            }
            
            double avgwait = 0;
            double avgta = 0;
            foreach (Process item in Ring)
            {
                avgwait += item.Wt;
                avgta += item.Ta;
                dataGridView2.Rows.Add(item.Process_id, item.Wt, item.Ta);
               
            }
            lblavgta.Text = "turnRoundtime Avg:" + avgta / li.Count;
            lblavgwait.Text = "waiting time Avg:" + avgwait / li.Count;
            label4.Text = g.Substring(0, g.Length - 3);
        }
    }
}



