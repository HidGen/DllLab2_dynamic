using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Class1
    {
      public double Add(double x, double y)
      {
     //   Console.WriteLine( Convert.ToString(x) + Convert.ToString(y));
            return Math.Round(0.05 *( Math.Sin(x*y)), 2);
      }

      public double Sub(double x, double y)
      {
   //     Console.WriteLine(Convert.ToString(x) + Convert.ToString(y));
        return Math.Round(((x-y) / (x*y)), 2);
      }
    }

