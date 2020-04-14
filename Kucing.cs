using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Responsi
{
    public class Kucing
        {
            public string Name { get; set; }
            public string Colour { get; set; }
            public int Age { get; set; }
            public string Tail { get; set; }
            public string Height { get; set; }

            public Kucing(string name, string colour, int age, string tail, string height)
            {
                this.Name = name;
                this.Colour = colour;
                this.Age = age;
                this.Tail = tail;
                this.Height = height;
            }
        public void GetNameandColourandAgeandTailandHeight()
          {
            Console.WriteLine("The Kucing has name: {0} {1} {2} {3} {4}", Name, Colour, Age, Tail, Height);
          }
       }

    }
