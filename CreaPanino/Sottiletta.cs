using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class Sottiletta : IIngrediente
    {
        public string Name { get => "Sottiletta "; set => throw new NotImplementedException(); }
        public double Price { get => 1.00; set => throw new NotImplementedException(); }
    }
}
