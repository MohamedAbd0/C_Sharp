using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace project_AI
{
    public partial class Form1 : Form
    {
        bool active = false;
        Color color;
        List<Label> arrcount = new List<Label>();
        List<Label> neighbor = new List<Label>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
   
        }
        private bool checkdrw()
        {
            if(active==false)
            {
                MessageBox.Show("PLS Active Color....");
                arrcount.Remove(arrcount[arrcount.Count - 1]);
                return false;
            }
           for(int i=0;i<arrcount.Count;i++) {
               for (int j = i+1; j <arrcount.Count; j++) {
                   if(arrcount[i]==arrcount[j]){
                       MessageBox.Show("No This Area Are Drowing ");
                       arrcount.Remove(arrcount[i]);
                       return false;
                   }
               }
           }
           checkwin();
           return true;
        }
        private void checkwin()
        {
           if (arrcount.Count == 13)
           {
                MessageBox.Show("OOoow You Win .....");
                clearalldata();
           }
                    
        }
        private void lbl1_Click(object sender, EventArgs e)
        {
            arrcount.Add(lbl1);
            if(checkdrw())
            {
                neighbor.Add(lbl2);
                neighbor.Add(lbl4);
                lbl1.BackColor = color;
                chickneighbors(neighbor, lbl1);
                neighbor.Clear();
            }
            
        }
        private void lbl2_Click(object sender, EventArgs e)
        {
            arrcount.Add( lbl2);
            if (checkdrw())
            {
                neighbor.Add(lbl1);
                neighbor.Add(lbl3);
                neighbor.Add(lbl4);
                lbl2.BackColor = color;
                chickneighbors(neighbor, lbl2);
                neighbor.Clear();

            }
           
        }
        private void lbl3_Click(object sender, EventArgs e)
        {
            arrcount.Add( lbl3);
            if (checkdrw())
            {
                neighbor.Add(lbl2);
                neighbor.Add(lbl5);
                lbl3.BackColor = color;
                chickneighbors(neighbor, lbl3);
                neighbor.Clear();

            }
           
        }
        private void lbl4_Click(object sender, EventArgs e)
        {
            arrcount.Add( lbl4 );
            if (checkdrw())
            {
                neighbor.Add(lbl1);
                neighbor.Add(lbl2);
                neighbor.Add(lbl5);
                neighbor.Add(lbl6);
                neighbor.Add(lbl7);
                neighbor.Add(lbl8);
                lbl4.BackColor = color;
                chickneighbors(neighbor, lbl4);
                   
            }
        }
        private void lbl5_Click(object sender, EventArgs e)
        {
            
            arrcount.Add( lbl5 );
            if (checkdrw())
            {
                neighbor.Add(lbl4);
                neighbor.Add(lbl3);
                neighbor.Add(lbl8);
                lbl5.BackColor = color;
                chickneighbors(neighbor, lbl5);
                neighbor.Clear();

                   
            }
        }
        private void lbl6_Click(object sender, EventArgs e)
        {
            arrcount.Add( lbl6 );
            if (checkdrw())
            {
                neighbor.Add(lbl4);
                neighbor.Add(lbl7);
                neighbor.Add(lbl9);
                neighbor.Add(lbl10);
                lbl6.BackColor = color;
                chickneighbors(neighbor, lbl6);
                neighbor.Clear();

                   
            }
        }
        private void lbl7_Click(object sender, EventArgs e)
        {
           
            arrcount.Add( lbl7 );
            if (checkdrw())
            {
                neighbor.Add(lbl4);
                neighbor.Add(lbl6);
                neighbor.Add(lbl9);
                neighbor.Add(lbl8);
                lbl7.BackColor = color;
                chickneighbors(neighbor, lbl7);
                neighbor.Clear();
                   
            }
        }
        private void lbl8_Click(object sender, EventArgs e)
        { 
            arrcount.Add( lbl8 );
            if (checkdrw())
            {
                neighbor.Add(lbl4);
                neighbor.Add(lbl7);
                neighbor.Add(lbl9);
                neighbor.Add(lbl5);
                lbl8.BackColor = color;
                chickneighbors(neighbor, lbl8);
                neighbor.Clear();
                   
            }
        }
        private void lbl9_Click(object sender, EventArgs e)
        {
           
            arrcount.Add( lbl9 );
            if (checkdrw())
            {
                neighbor.Add(lbl6);
                neighbor.Add(lbl7);
                neighbor.Add(lbl8);
                neighbor.Add(lbl10);
                lbl9.BackColor = color;
                chickneighbors(neighbor,lbl9);
                neighbor.Clear();

                   
            }
        }
        private void lbl10_Click(object sender, EventArgs e)
        {
           
            arrcount.Add( lbl10 );
            if (checkdrw())
            {
                neighbor.Add(lbl6);
                neighbor.Add(lbl9);
                neighbor.Add(lbl12);
                lbl10.BackColor = color;
                chickneighbors(neighbor,lbl10);
                neighbor.Clear();
            }
        }
        private void lbl11_Click(object sender, EventArgs e)
        {
           
            arrcount.Add( lbl11 );
            if (checkdrw())
            {
                neighbor.Add(lbl13);
                lbl11.BackColor = color;
                chickneighbors(neighbor, lbl11);
                neighbor.Clear();
                   
            }
        }
        private void lbl12_Click(object sender, EventArgs e)
        {
            
            arrcount.Add( lbl12 );
            if (checkdrw())
            {
              
                neighbor.Add(lbl10);
                lbl12.BackColor = color;
                chickneighbors(neighbor, lbl12);
                neighbor.Clear();
                   
            }
        }
        private void lbl13_Click(object sender, EventArgs e)
        {
            
            arrcount.Add( lbl13 );
            if (checkdrw())
            {
                neighbor.Add(lbl11);
                lbl13.BackColor = color;
                chickneighbors(neighbor,lbl13);
                neighbor.Clear();
                    
            }
        }
        private void btnred_Click(object sender, EventArgs e)
        {
            color = btnred.BackColor;
            lblactive.BackColor = color;
            active = true;

        }
        private void btnblu_Click(object sender, EventArgs e)
        {
            color = btnblu.BackColor;
            lblactive.BackColor = color;
            active = true;
        }
        private void btnyellow_Click(object sender, EventArgs e)
        {
            color = btnyellow.BackColor;
            lblactive.BackColor = color;
            active = true;
        }
        private void btngreen_Click(object sender, EventArgs e)
        {
            color = btngreen.BackColor;
            lblactive.BackColor = color;
            active = true;
        }
        private bool chickneighbors(List<Label> arr,Label lbl)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                    if (lbl.BackColor == arr[i].BackColor)
                    {
                        MessageBox.Show("You Are Loser ......");
                        clearalldata();
                        return false;
                    }
            }
            return true;
        }
        private void clearalldata()
        {
            foreach (var item in arrcount)
            {
                item.BackColor = Color.Empty;
                color = Color.Empty;
                lblactive.BackColor = Color.Empty;
            }
            arrcount.Clear();
            active = false;
        }
    }
}
