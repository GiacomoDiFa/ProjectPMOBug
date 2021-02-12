using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class HotDog : IIngrediente
    {
        public string Name { get => "Hot Dog "; set => throw new NotImplementedException(); }
        public double Price { get => 3.00; set => throw new NotImplementedException(); }
    }
}
