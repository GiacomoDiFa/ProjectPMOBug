using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    interface IIngrediente
    {
        public String Name { get; set; }
        public double Price { get; set; }
    }
}
