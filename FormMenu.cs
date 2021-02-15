using MenuInterattivo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuInterattivo
{
    public partial class FormMenu : Form
    {
        private readonly IDatabase db;
        private Menu menu;
        private FormPizza formPizza;
        private FormPanino formPanino;
        private FormBevanda formBevanda;
        private FormCarrello formCarrello;
        private FormPagamento formPagamento;
        public FormMenu(IDatabase database,Menu menu)
        {
            InitializeComponent();
            this.db = database;
            this.menu = menu;
        }
        private void btnPizza_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formPizza = new FormPizza(db,menu);
            this.formPizza.Show();
        }
        private void btnPanino_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formPanino = new FormPanino(db,menu);
            this.formPanino.Show();
        }
        private void btnBevanda_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formBevanda = new FormBevanda(db,menu);
            this.formBevanda.Show();
        }
        private void btnCarrello_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formCarrello = new FormCarrello(db,menu);
            this.formCarrello.Show();
        }
        private void btnSendMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler passare al pagamento?", "Confermi?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                this.formPagamento = new FormPagamento(db,menu);
                this.formPagamento.Show();
            }
            else
            {
                this.Show();
            }
        }
    }
}