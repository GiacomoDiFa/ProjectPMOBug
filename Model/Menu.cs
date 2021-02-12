using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.Model
{
    public class Menu
    {
        private static Menu instance = null;
        private List<Cibo> cibos;
        protected Menu()
        {
            this.cibos = new List<Cibo>();
        }
        public static Menu Instance()
        {
            if(instance == null)
            {
                instance = new Menu();
            }
            return instance;
        }
        public List<Cibo> Cibos
        {
            get
            {
                return cibos;
            }
            set
            {
                this.cibos = value;
            }
        }
    }
}
