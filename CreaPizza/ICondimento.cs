using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    interface ICondimento
    {
        public String Name { get; set; }
        public double Price { get; set; }
    }
}
