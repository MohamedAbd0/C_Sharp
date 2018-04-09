using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memory_allocation
{
    class block
    {
       public int block_size;
       public bool flag;
       public int storage,Wait_process;

        public block(int block_size , bool flag)
       {
           this.block_size = block_size;
           this.flag = flag;
       }

        public int Block_Size
        {
            set { block_size = value; }
            get { return block_size; }
        }
        public bool Flag
        {
            set { flag = value; }
            get { return flag; }
        }
        public int Storage
        {
            set { storage = value; }
            get { return storage; }
        }
        public int Wait
        {
            set { Wait_process = value; }
            get { return Wait_process; }
        }
    }
}
