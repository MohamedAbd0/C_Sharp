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





    public partial class Form2 : Form
    {
       

        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<Label> neighbor = new List<Label>();
            List<City> cities = new List<City>();
            List<City> assignment = new List<City>();
            Color[] Domain = new Color[4] { Color.Red, Color.Blue, Color.Green, Color.Yellow };

            City c1 = new City(lbl1, Color.Empty);
            City c2 = new City(lbl2, Color.Empty);
            City c3 = new City(lbl3, Color.Empty);
            City c4 = new City(lbl4, Color.Empty);
            City c5 = new City(lbl5, Color.Empty);
            City c6 = new City(lbl6, Color.Empty);
            City c8 = new City(lbl8, Color.Empty);
            City c10 = new City(lbl10, Color.Empty);
            City c11 = new City(lbl11, Color.Empty);
            City c12 = new City(lbl12, Color.Empty);
            City c13 = new City(lbl13, Color.Empty);

            c1.neighbor = new City[] { c2 };
            c2.neighbor = new City[] { c3, c4, c1 };
            c3.neighbor = new City[] { c2, c5 };
            c4.neighbor = new City[] { c2, c5, c8 };
            c5.neighbor = new City[] { c3, c4, c8 };
            c6.neighbor = new City[] { c8, c10 };
            c8.neighbor = new City[] { c4, c5, c6 };
            c10.neighbor = new City[] { c6, c12,c11 };
            c11.neighbor = new City[] { c13,c10 };
            c12.neighbor = new City[] { c10,c13 };
            c13.neighbor = new City[] { c11,c12 };
            cities.Add(c1);
            cities.Add(c2);
            cities.Add(c3);
            cities.Add(c4);
            cities.Add(c5);
            cities.Add(c6);
            cities.Add(c8);
            cities.Add(c10);
            cities.Add(c11);
            cities.Add(c12);
            cities.Add(c13);

            //---------------------------------Dfs----------------------------//
           
    /*
            Stack BfsFringe = new Stack();

            //1. Add initial node to fringe
            BfsFringe.Push(c1);

            //2. Repeat until fringe.count==0
            while (BfsFringe.Count != 0)
            {
                //2.1 Extract current node from fringe
                City currentNode = (City)BfsFringe.Pop();
                //2.2. check if current node color
                if (currentNode.color == Color.Empty)
                {

                    while (!currentNode.CheckColor(currentNode))
                    {
                        int h = rnd.Next(0, Domain.Length);
                        currentNode.color = Domain[h];
                    }

                    currentNode.id.BackColor = currentNode.color;
                     MessageBox.Show(assignment.Count+"   ---  "+currentNode.id.Text+"  ---   "+BfsFringe.Count);
                }

                //2.3 add its child to fringe
                City[] child = currentNode.neighbor;
                //Add child to fringe
                for (int i = child.Length-1 ; i >= 0; i--)
                {
                    BfsFringe.Push(child[i]);
                }
            }     

           
            */

            //------------------------------ BFS-----------------------------------//


            /*
           
            Queue BfsFringe = new Queue();
            //1. Add initial node to fringe
            BfsFringe.Enqueue(c1);
            while (BfsFringe.Count != 0)
            {
                //2.1 Extract current node from fringe
                City currentNode = (City)BfsFringe.Dequeue();
                if (currentNode.color == Color.Empty)
                {
                    //2.2. check  current node color
                    while (!currentNode.CheckColor(currentNode))
                    {
                        int h = rnd.Next(0, Domain.Length);
                        currentNode.color = Domain[h];
                    }
                    assignment.Add(currentNode);
                    currentNode.id.BackColor = currentNode.color;
                 //  MessageBox.Show("   ---  "+currentNode.id.Text+"  ---   "+BfsFringe.Count);
                    City[] child = currentNode.neighbor;
                    //Add child to fringe
                    for (int i = 0; i < child.Length; i++)
                    {
                        BfsFringe.Enqueue(child[i]);
                    }
                  //  lbl13.BackColor = Color.Yellow;
                }
            }
            
           */


            //------------------------ csp --------------------//


          
            

            for (int g = 0; g < cities.Count; g++)
            {
                while (assignment.Count<=g)
                {
                    int h = rnd.Next(0, Domain.Length);
                     cities[g].color = Domain[h];
                     if (cities[g].CheckColor(cities[g]))
                     {
                         cities[g].id.BackColor = Domain[h];
                         assignment.Add(cities[g]);
                     }
                }
            }

        
        }














    }


}

