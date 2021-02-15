using MenuInterattivo.Calculation;
using MenuInterattivo.CreaPizza;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.Model
{
    class Pizza : Cibo, IVisitorHost
    {
        private List<ICondimento> condimentos = new List<ICondimento>();
        private string descrizione;
        private double prezzo;
        public override string Name { get; set; }
        public override string Description
        {
            get
            {
                foreach (ICondimento item in condimentos)
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
                foreach (ICondimento item in condimentos)
                {
                    prezzo += item.Price;
                }
                return prezzo;
            }
            set => prezzo = value;
        }
        public void Add(ICondimento condimento)
        {
            this.condimentos.Add(condimento);
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}