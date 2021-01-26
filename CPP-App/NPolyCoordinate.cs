using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App
{
    public class NPolyCoordinate
    {
        private double x;
        private double y;
        
        public double X()
        {
            return x;
        }
        public double Y()
        {
            return y;
        }
        public NPolyCoordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
