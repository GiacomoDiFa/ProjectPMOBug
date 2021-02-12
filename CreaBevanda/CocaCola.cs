using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class CocaCola : IComponente
    {
        public string Name { get => "Coca Cola "; set => throw new NotImplementedException(); }
        public double Price { get => 3.00; set => throw new NotImplementedException(); }
    }
}
