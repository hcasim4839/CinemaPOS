using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class PointsCalculator
    {
        public static int PointsGained(decimal amtPaid)
        {
            Console.WriteLine("In points calc the decimal amtPaid is: " + amtPaid);
            int points = (int)(amtPaid / 1);
            Console.WriteLine("The points are: " + points);
            return points;
        }
    }  
}
