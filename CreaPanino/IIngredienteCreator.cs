using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    interface IIngredienteCreator
    {
        public IIngrediente FactoryMethod();
        public string GetInfo();
        public double GetPrice();
    }
}
