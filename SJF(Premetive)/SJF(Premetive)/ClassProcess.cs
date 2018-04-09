using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJF_Premetive_
{
   
        public class ClassProcess
        {
            public int id;
            public int arrival;
            public int burst;
            public int start;
            public int wait;
            public int finish;
            public int TA;
            public bool end;

            public int worked;
            public bool opened = false;
            public int last_see = 0;           //use to find the wait time in Preemptive 
            public int size_burst;          //use with the preemptive

            public ClassProcess(int id, int arrival, int burst)
            {
                this.id = id;
                this.arrival = arrival;
                this.burst = burst;

            }
        }
    
}
