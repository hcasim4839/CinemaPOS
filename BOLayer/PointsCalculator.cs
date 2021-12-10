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
            int points = (int)(amtPaid / 100);
            return points;
        }
    }
}
