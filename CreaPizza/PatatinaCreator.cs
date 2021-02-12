using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class PatatinaCreator : ICondimentoCreator
    {
        public ICondimento FactoryMethod()
        {
            return new Patatina();
        }

        public string GetInfo()
        {
            return "Patatina ";
        }

        public double GetPrice()
        {
            return 3.00;
        }
    }
}
