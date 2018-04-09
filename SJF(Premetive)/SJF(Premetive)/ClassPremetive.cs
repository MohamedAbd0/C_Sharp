using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJF_Premetive_
{
    class ClassPremetive
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

            public ClassProcess(int id, int arrival, int burst)
            {
                this.id = id;
                this.arrival = arrival;
                this.burst = burst;

            }
        }
    }
}
