using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos
{
    public class MyProcess
    {
        public int iD { get; private set; }
        public String name { get; private set; }
        public long memory;
        public String category;
        public String priority { get; private set; }

        public MyProcess(int iD, String name, long memory, String category, String priority) 
        {
            this.iD = iD;
            this.name = name;
            this.memory = memory;
            this.category = category;
            this.priority = priority;
        }
    }
}
