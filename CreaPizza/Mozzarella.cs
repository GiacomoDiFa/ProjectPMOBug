using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class Mozzarella : ICondimento
    {
        public string Name { get => "Mozzarella "; set => throw new NotImplementedException(); }
        public double Price { get => 0.50; set => throw new NotImplementedException(); }
    }
}
