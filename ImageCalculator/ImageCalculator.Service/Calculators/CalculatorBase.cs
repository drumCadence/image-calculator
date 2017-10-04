using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCalculator.Service.Calculators
{
    public abstract class CalculatorBase
    {
        public Pen pen1;
        public Pen pen2;

        public CalculatorBase()
        {
            pen1 = new Pen(Color.Blue, 2);
            pen2 = new Pen(Color.Red, 2);
        }

    }
}
