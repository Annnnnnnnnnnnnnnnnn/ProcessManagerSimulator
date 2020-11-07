using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Lab1
{
    class ProcessGenerator
    {
        private int cur_id = 1;
        private Random random = new Random();

        public Process gen_process(int min_time, int max_time, int tick, Time time)
        {
            cur_id++;
            int rand = random.Next(min_time, max_time);
            return new Process(cur_id - 1, new Time(rand - (rand % tick)), new Time(time));
        }
    }
}
