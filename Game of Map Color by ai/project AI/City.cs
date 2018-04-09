using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;


namespace project_AI
{
   public class City
    {
       public Label id;
      public   Color color;
      public City[] neighbor;


     
      public City(Label id,Color color)
      {
          this.color = color;
          this.id = id;
         
          
      }

     
      public  bool CheckColor(City c1)
      {
          foreach (City item in c1.neighbor)
          {
              if (c1.color == item.color)
              return false;
          }
          return true;
      }

    }
}
