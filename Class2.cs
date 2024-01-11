using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Methods
    {
        public abstract double Perimeter();
        public abstract double Area();
        public abstract void Move(double deltaX, double deltaY);
        public abstract bool IsValid();
    }
}
