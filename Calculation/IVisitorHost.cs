using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.Calculation
{
    interface IVisitorHost
    {
        void Accept(IVisitor visitor);
    }
}
