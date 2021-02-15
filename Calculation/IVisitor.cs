using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.Calculation
{
    interface IVisitor
    {
        double Result { get; }
        void Visit(Model.Cibo cibo);
        void Reset();
    }
}