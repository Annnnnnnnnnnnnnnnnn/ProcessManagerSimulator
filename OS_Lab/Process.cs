using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Lab1
{
    class Process
    {
        public int id { get; set; }
        public Time complexity { get; set; }
        public Time start { get; set; }
        public Time finish { get; set; }
        public Time time_worked { get; set; }
        public Time deleyed { get; set; }

        public int state;
        

        public Process(int id, Time complexity, Time start)
        {
            this.id = id;
            this.complexity = complexity;
            this.state = 0;
            this.deleyed = new Time();
            this.start = start;
            this.time_worked = new Time();
            this.finish = new Time();
        }

        public void run(Time time)
        {
            state = 1;
        }

        public void pause()
        {
            state = 2;
        }


        public void running(int tick)
        {
            time_worked.inc_msec(tick);
        }

        public void resume(Time time)
        {
            state = 1;
        }

        public void solve(Time time)
        {
            finish = time;
            deleyed = (finish - start) - complexity;
            state = 3;
        }
    }
}
