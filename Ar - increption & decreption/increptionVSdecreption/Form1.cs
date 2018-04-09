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
namespace increptionVSdecreption
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operation;
            if (CmbOper.SelectedItem == "Traditional")
                if (cmbInc_Dec.SelectedItem == "increption")
                    operation = Traditional(rtxtsourse, "Monoalphabetic", "increption");
                else
                    operation = Traditional(rtxtsourse, "Monoalphabetic", "decreption");
            else
                if (cmbInc_Dec.SelectedItem == "increption")
                    operation=shifting(rtxtsourse, txtshcount, "inc");
                else
                    operation=shifting(rtxtsourse, txtshcount, "dec");

            lblres.Text = operation;
            

            


        } 
        public static string shifting(RichTextBox sourse, TextBox shiftCount, string type)
        {
            char[] letter = new char[sourse.TextLength];
            letter = sourse.Text.ToCharArray();
            int shift = int.Parse(shiftCount.Text);
            string res = "";
            for (int i = 0; i < letter.Length; i++)
            {
                char len;
                if (type == "inc")
                {
                    int g = ((int)letter[i] + shift);
                    if (g <= (int)'ي')
                    {
                        len = (char)((int)letter[i] + shift);
                        res += len;
                    }
                    else if (g > (int)'ي')
                    {
                        int n = g - (int)'ي';
                        len = (char)((int)'أ' + n - 1);
                        res += len;
                    }
                }
                else if (type == "dec")
                {
                    int g = ((int)letter[i] - shift);
                    if (g >= (int)'أ')
                    {
                        len = (char)((int)letter[i] - shift);
                        res += len;
                    }
                    else if (g < (int)'أ')
                    {
                        int n = (int)'أ' - g;
                        len = (char)((int)'ي' - n + 1);
                        res += len;
                    }
                }
            }
            return res;
        }

        public static string Traditional(RichTextBox sourse, string name , string type)
        {
            char[] letter = new char[sourse.TextLength];
            letter = sourse.Text.ToCharArray();
            string res = "";

            if (name == "Monoalphabetic")
            {

                Hashtable table = new Hashtable();
                table.Add('أ', 'ث');
                table.Add('ب', 'ر');
                table.Add('ت', 'س');
                table.Add('ث', 'د');
                table.Add('ج', 'ض');
                table.Add('ح', 'ق');
                table.Add('خ', 'ج');
                table.Add('د', 'ف');
                table.Add('ذ', 'ع');
                table.Add('ر', 'ص');
                table.Add('ز', 'ح');
                table.Add('س', 'غ');
                table.Add('ش', 'خ');
                table.Add('ص', 'ه');
                table.Add('ض', 'ط');
                table.Add('ط', 'ب');
                table.Add('ظ', 'ض');
                table.Add('ع', 'ك');
                table.Add('غ', 'ر');
                table.Add('ف', 'و');
                table.Add('ق', 'ش');
                table.Add('ك', 'ل');
                table.Add('ل', 'ن');
                table.Add('م', 'ظ');
                table.Add('ن', 'ز');
                table.Add('ه', 'أ');
                table.Add('و', 'ت');
                table.Add('ي', 'م');
                table.Add(' ', '$');

                if (type == "increption")
                {
                    for (int i = 0; i < letter.Length; i++)
                    {
                        char let = letter[i];
                        res += table[let];
                    }
                    return res;
                }
                else //if (type == "decreption")
                {
                    for (int i = 0; i < letter.Length; i++)
                    {
                        char let = letter[i];
                        foreach (char item in table.Keys)
                        {
                            if (table[item] == table[let])
                                res += item;
                        }
                    }
                    return res;
                }                
            }
            else
            {
                return res;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CmbOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbOper.SelectedItem == "shifting")
            {
                txtshcount.Visible = true;
                label5.Visible = true;


            }
        }

        private void cmbInc_Dec_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOperation.Text = cmbInc_Dec.SelectedItem.ToString();
            
        }
        
    }
}
