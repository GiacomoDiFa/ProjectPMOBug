using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class WustelCreator : ICondimentoCreator
    {
        public ICondimento FactoryMethod()
        {
            return new Wustel();
        }

        public string GetInfo()
        {
            return "Wustel ";
        }

        public double GetPrice()
        {
            return 1.50;
        }
    }
}
