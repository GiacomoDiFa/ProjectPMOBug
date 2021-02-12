using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class HamburgerCreator : IIngredienteCreator
    {
        public IIngrediente FactoryMethod()
        {
            return new Hamburger();
        }
        public string GetInfo()
        {
            return "Hamburger ";
        }
        public double GetPrice()
        {
            return 3.00;
        }
    }
}
