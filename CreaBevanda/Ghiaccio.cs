using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class Ghiaccio : IComponente
    {
        public string Name { get => "Ghiaccio "; set => throw new NotImplementedException(); }
        public double Price { get => 0.50; set => throw new NotImplementedException(); }
    }
}
