using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class SalamePiccante : ICondimento
    {
        public string Name { get => "Salame Piccante "; set => throw new NotImplementedException(); }
        public double Price { get => 2.00; set => throw new NotImplementedException(); }
    }
}
