using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingExercises
{
    class Square
    {
        private double side;
        private double area;

        public Square(double side)
        {
            this.side = side;
            makeArea();
        }

        private void makeArea()
        {
            area = side * side;
        }

        public double Side
        {
            get
            {
                return side;
            }
        }
        public double Area
        {
            get
            {
                return area;
            }
        }

    }
}
