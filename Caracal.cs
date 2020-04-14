using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Responsi
{
    public class Caracal : Kucing
    {
        public string Tail { get; set; }
        public string Height { get; set; }
        public Caracal(string name, string colour, int age, string tail, string height) : base(name, colour, age)
        {
            this.Tail = tail;
            this.Height = height;
        }
    }
}
