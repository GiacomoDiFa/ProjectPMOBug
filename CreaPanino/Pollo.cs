using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class Pollo : IIngrediente
    {
        public string Name { get => "Pollo "; set => throw new NotImplementedException(); }
        public double Price { get => 3.00; set => throw new NotImplementedException(); }
    }
}
