using System;
using System.Collections.Generic;
using System.Text;

namespace circlesMath
{
    internal class circle
    {
        public double rad { get; set; }
        public string are { get; set; }
        public string cir { get; set; }

        public circle(double rad, string are, string cir)
        {
            this.rad = rad;
            this.are = are;
            this.cir = cir;
        }
    }
}