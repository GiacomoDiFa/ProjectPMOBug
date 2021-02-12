using MenuInterattivo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.Calculation
{
    class ItemCounter : IVisitor
    {
        private int count = 0;
        public double Result { get => count;}

        public void Reset() => count = 0;

        public void Visit(Cibo cibo) => count++;
    }
}
