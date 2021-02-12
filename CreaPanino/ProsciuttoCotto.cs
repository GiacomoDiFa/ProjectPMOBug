using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class ProsciuttoCotto : IIngrediente
    {
        public string Name { get => "Prosciutto Cotto "; set => throw new NotImplementedException(); }
        public double Price { get => 1.50; set => throw new NotImplementedException(); }
    }
}
