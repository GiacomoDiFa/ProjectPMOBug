using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    interface ICondimentoCreator
    {
        public ICondimento FactoryMethod();
        public string GetInfo();
        public double GetPrice();
    }
}
