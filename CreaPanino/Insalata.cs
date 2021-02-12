using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class Insalata : IIngrediente
    {
        public string Name { get => "Insalata "; set => throw new NotImplementedException(); }
        public double Price { get => 0.50; set => throw new NotImplementedException(); }
    }
}
