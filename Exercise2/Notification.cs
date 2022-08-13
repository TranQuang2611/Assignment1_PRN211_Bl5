using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Notification
    {
        private DateTime time;

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public Notification()
        {

        }

        public override string? ToString()
        {
            return time + "\t" + text;
        }
    }
}
