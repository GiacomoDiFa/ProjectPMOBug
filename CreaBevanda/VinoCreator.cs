using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    class VinoCreator : IComponenteCreator
    {
        public IComponente FactoryMethod()
        {
            return new Vino();
        }
        public string GetInfo()
        {
            return "Vino ";
        }
        public double GetPrice()
        {
            return 2.50;
        }
    }
}
