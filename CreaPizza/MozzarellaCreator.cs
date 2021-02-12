using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class MozzarellaCreator : ICondimentoCreator
    {
        public ICondimento FactoryMethod()
        {
            return new Mozzarella();
        }

        public string GetInfo()
        {
            return "Mozzarella";
        }

        public double GetPrice()
        {
            return 0.50;
        }
    }
}
