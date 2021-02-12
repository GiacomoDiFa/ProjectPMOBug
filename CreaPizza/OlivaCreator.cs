using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class OlivaCreator : ICondimentoCreator
    {
        public ICondimento FactoryMethod()
        {
            return new Oliva();
        }

        public string GetInfo()
        {
            return "Oliva ";
        }

        public double GetPrice()
        {
            return 2.50;
        }
    }
}
