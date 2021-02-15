using MenuInterattivo.Calculation;
using MenuInterattivo.CreaBevanda;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.Model
{
    class Bevanda : Cibo, IVisitorHost
    {
        private List<IComponente> componenti = new List<IComponente>();
        private string descrizione;
        private double prezzo;
        public override string Name { get; set; }
        public override string Description
        {
            get
            {
                foreach (IComponente item in componenti)
                {
                    descrizione += item.Name;
                }
                return descrizione;
            }
            set => descrizione = value;
        }
        public override double Price
        {
            get
            {
                foreach (IComponente item in componenti)
                {
                    prezzo += item.Price;
                }
                return prezzo;
            }
            set => prezzo = value;
        }
        public void Add(IComponente componente)
        {
            this.componenti.Add(componente);
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}