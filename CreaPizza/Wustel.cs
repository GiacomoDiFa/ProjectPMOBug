using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class Wustel : ICondimento
    {
        public string Name { get => "Wustel "; set => throw new NotImplementedException(); }
        public double Price { get => 1.50; set => throw new NotImplementedException(); }
    }
}
