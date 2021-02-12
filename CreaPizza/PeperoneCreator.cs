using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class PeperoneCreator : ICondimentoCreator
    {
        public ICondimento FactoryMethod()
        {
            return new Peperone();
        }

        public string GetInfo()
        {
            return "Peperone ";
        }

        public double GetPrice()
        {
            return 3.00;
        }
    }
}
