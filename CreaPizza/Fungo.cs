using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class Fungo : ICondimento
    {
        public string Name { get => "Fungo "; set => throw new NotImplementedException(); }
        public double Price { get => 3.00; set => throw new NotImplementedException(); }
    }
}
