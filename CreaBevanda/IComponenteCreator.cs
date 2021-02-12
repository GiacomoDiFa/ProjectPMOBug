using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaBevanda
{
    interface IComponenteCreator
    {
        public IComponente FactoryMethod();
        public string GetInfo();
        public double GetPrice();
    }
}
