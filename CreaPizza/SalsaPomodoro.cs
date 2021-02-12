using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class SalsaPomodoro : ICondimento
    {
        public string Name { get => "Salsa di pomodoro "; set => throw new NotImplementedException(); }
        public double Price { get => 1.00; set => throw new NotImplementedException(); }
    }
}
