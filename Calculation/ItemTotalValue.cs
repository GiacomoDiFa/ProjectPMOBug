using MenuInterattivo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.Calculation
{
    class ItemTotalValue : IVisitor
    {
        private double value = 0;
        public double Result => value;
        public void Reset() => value = 0;
        public void Visit(Cibo cibo) => value += cibo.Price; 
    }
}