using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kucing kucing = new Kucing("Lulu", "Brown", 5);
            kucing.GetNameandColourandAgeandTailandHeight();

            Caracal caracal = new Caracal("Dundun", "White", 3, "long tail", "110 cm");
            caracal.GetNameandColourandAgeandTailandHeight();

            Bobtail bobtail = new Bobtail("Momo", "Orange", 4, "short tail", "60 cm");
            bobtail.GetNameandColourandAgeandTailandHeight();

            Console.ReadKey();
        }
    }
    
}
