using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class Pomodoro : IIngrediente
    {
        public string Name { get => "Pomodoro "; set => throw new NotImplementedException(); }
        public double Price { get => 2.00; set => throw new NotImplementedException(); }
    }
}
