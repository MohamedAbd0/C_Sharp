using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project__ai_3rd
{
    public partial class Form1 : Form
    {
        int RO, CO;
        int Score = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(8);
            dataGridView1.CurrentCell.Style.BackColor = Color.Red;
            dataGridView1.CurrentCell.Style.ForeColor = Color.Black;
            dataGridView1.CurrentCell.Value = "Init";

            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cc, cr;
            cc = dataGridView1.CurrentCell.RowIndex;
            cr = dataGridView1.CurrentCell.ColumnIndex;
           
            if (((cc == CO - 1) & (cr == RO - 2)) | ((cc == CO - 2) & (cr == RO - 1)) | ((cc == CO + 1) & (cr == RO - 2)) | ((cc == CO + 2) & (cr == RO - 1)) | ((cc == CO - 2) & (cr == RO + 1)) | ((cc == CO - 1) & (cr == RO + 2)) | ((cc == CO + 2) & (cr == RO + 1)) | ((cc == CO + 1) & (cr == RO + 2)))
            {
                dataGridView1.CurrentCell.Style.BackColor = Color.Red;
                dataGridView1.CurrentCell.Style.ForeColor = Color.Red;
                dataGridView1.CurrentCell.Value = "Done";
                label2.Text = "Active cell is : " + (cc+1) + " #num Colum - " + (cr+1) + " #num Row ";
                CO = cc;
                RO = cr;
                Score++;     
            }
            label1.Text = null;
            label1.Text = "Your Moves IS : " + Score;
            if (gool())
            {
                MessageBox.Show("Congraulation You are Win  Your Score Is : "+Score);
            }
        }

        private bool gool()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Style.BackColor != Color.Red)
                        return false;
                }
            }
            return true;
        }
    }
}
