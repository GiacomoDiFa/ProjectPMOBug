using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class FungoCreator : ICondimentoCreator
    {
        public ICondimento FactoryMethod()
        {
            return new Fungo();
        }

        public string GetInfo()
        {
            return "Fungo ";
        }

        public double GetPrice()
        {
            return 3.00;
        }
    }
}
