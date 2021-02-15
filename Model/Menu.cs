using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.Model
{
    public class Menu
    {
        private static Menu instance = null;
        public List<Cibo> Cibos { get; set; }
        protected Menu()
        {
            this.Cibos = new List<Cibo>();
        }
        public static Menu Instance()
        {
            if(instance == null)
            {
                instance = new Menu();
            }
            return instance;
        }
    }
}