using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class CocaColaCreator : IComponenteCreator
    {
        public IComponente FactoryMethod()
        {
            return new CocaCola();
        }
        public string GetInfo()
        {
            return "Coca Cola ";
        }
        public double GetPrice()
        {
            return 3.00;
        }
    }
}
