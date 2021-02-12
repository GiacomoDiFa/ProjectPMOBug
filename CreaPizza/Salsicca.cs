using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class Salsicca : ICondimento
    {
        public string Name { get => "Salsiccia "; set => throw new NotImplementedException(); }
        public double Price { get => 2.00; set => throw new NotImplementedException(); }
    }
}
