using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Lab1
{
    public class Time
    {
        private int min;
        private int sec;
        private int msec;

        public Time()
        {
            this.min = 0;
            this.sec = 0;
            this.msec = 0;
        }

        public Time(int m_sec)
        {
            this.msec = m_sec % 1000;
            int all_sec = (m_sec - this.msec) / 1000;
            this.sec = all_sec % 60;
            this.min = (all_sec - this.sec) / 60; 
        }

        public Time(Time t)
        {
            this.min = t.min;
            this.sec = t.sec;
            this.msec = t.msec;
        }

        public void reset()
        {
            min = 0;
            sec = 0;
            msec = 0;
        }

        public void inc_min()
        {
            min += 1;
            if (min >= 60)
            {
                this.reset();
            }
        }

        public void inc_sec()
        {
            sec += 1;
            if (sec >= 60) {
                this.inc_min();
                sec = 0;
            }
        }

        public void inc_msec(int msecs)
        {
            msec += msecs;
            if (msec >= 1000)
            {
                this.inc_sec();
                msec = msec - 1000;
            }
        }

        public override string ToString()
        {
            return min.ToString() + " : " + sec.ToString() + " : " + msec.ToString();
        }

        public int ToMsec()
        {
            return min * 60000 + sec * 1000 + msec;
        }

        public static Time operator -(Time t1, Time t2)
        {
            return new Time(t1.ToMsec() - t2.ToMsec());
        }

        public static Time operator +(Time t1, Time t2)
        {
            return new Time(t1.ToMsec() + t2.ToMsec());
        }

        public static Boolean operator <(Time t1, Time t2)
        {
            return t1.ToMsec() < t2.ToMsec();
        }

        public static Boolean operator >(Time t1, Time t2)
        {
            return t1.ToMsec() > t2.ToMsec();
        }

        public static Boolean operator <=(Time t1, Time t2)
        {
            return t1.ToMsec() <= t2.ToMsec();
        }

        public static Boolean operator >=(Time t1, Time t2)
        {
            return t1.ToMsec() >= t2.ToMsec();
        }
    }
}
