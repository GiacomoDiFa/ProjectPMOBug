using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class Birra : IComponente
    {
        public string Name { get => "Birra "; set => throw new NotImplementedException(); }
        public double Price { get => 3.00; set => throw new NotImplementedException(); }
    }
}
