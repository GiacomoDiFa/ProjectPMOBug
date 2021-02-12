using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class Oliva : ICondimento
    {
        public string Name { get => "Oliva "; set => throw new NotImplementedException(); }
        public double Price { get => 2.50; set => throw new NotImplementedException(); }
    }
}
