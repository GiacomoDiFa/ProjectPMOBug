using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class Acqua : IComponente
    {
        public string Name { get => "Acqua "; set => throw new NotImplementedException(); }
        public double Price { get => 2.00; set => throw new NotImplementedException(); }
    }
}
