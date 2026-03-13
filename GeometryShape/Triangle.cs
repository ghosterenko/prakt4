using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Triangle :Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public override double Area ()
        {
            throw new NotImplementedException( );
        }

        public override double Perimeter ()
        {
            throw new NotImplementedException( );
        }

        public override string ToString ()
        {
            throw new NotImplementedException( );
        }
    }
}
