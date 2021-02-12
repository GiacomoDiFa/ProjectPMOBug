using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class SalsicciaCreator : ICondimentoCreator
    {
        public ICondimento FactoryMethod()
        {
            return new Salsicca();
        }

        public string GetInfo()
        {
            return "Salsiccia ";
        }

        public double GetPrice()
        {
            return 2.00;
        }
    }
}
