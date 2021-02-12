using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class FantaCreator : IComponenteCreator
    {
        public IComponente FactoryMethod()
        {
            return new Fanta();
        }

        public string GetInfo()
        {
            return "Fanta ";
        }

        public double GetPrice()
        {
            return 3.00;
        }
    }
}
