using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class Vino : IComponente
    {
        public string Name { get => "Vino "; set => throw new NotImplementedException(); }
        public double Price { get => 2.50; set => throw new NotImplementedException(); }
    }
}
