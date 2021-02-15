using MenuInterattivo.Calculation;
using MenuInterattivo.Extension;
using MenuInterattivo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuInterattivo
{
    public partial class FormPagamento : Form
    {
        private FormMenu formMenu;
        private Menu menu;
        private IDatabase db;
        private Dictionary<IVisitor, Label> visitor;
        public FormPagamento(IDatabase database,Menu menu)
        {
            this.FormClosing += this.FormPagamento_FormClosing;
            InitializeComponent();
            InitializeCalculation();
            this.db = database;
            this.menu = menu;
        }
        /* closing of form */
        private void FormPagamento_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /* loading of form */
        private void FormPagamento_Load(object sender, EventArgs e)
        {
            EnableTextBoxes();
            LoadValue();
        }
        private void InitializeCalculation()
        {
            visitor = new Dictionary<IVisitor, Label> {
                { new ItemTotalValue(), this.lblTotale }
            };
        }
        private void LoadValue()
        {
            try
            {
                menu.Cibos = db.GetData();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Can't connect " + ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
                return;
            }
            UpdateCalculations();
        }
        private void UpdateCalculations()
        {
            foreach (var pair in visitor)
            {
                var visitor = pair.Key;
                var label = pair.Value;
                visitor.Reset();

                menu.Cibos.ToList().ForEach(i => visitor.Visit(i));
                label.Text = visitor.Result.ToString();
            }
        }
        /* action uf user */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formMenu = new FormMenu(db,menu);
            this.formMenu.Show();
        }
        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (CheckValueInTextBoxCard() || CheckValueInTextBoxName() == true)
            {
                if (MessageBox.Show("Sei sicuro di voler confermare?", "Confermi?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    menu.Cibos.Clear();
                    this.db.SaveData(menu.Cibos);
                    Application.Exit();
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Controlla che i valori inseriti siano corretti.\nSe paghi alla cassa verifica di aver scritto un nome con cui venir identificato.\nSe paghi con carta verifica che\nSia inserito il nome del proprietario della carta\nNumero carta:16 cifre\nCVC:3 cifre\nScadenza:6 cifre", "Errore!", MessageBoxButtons.OK);
                this.Show();
            }
        }
        /* control */
        private bool CheckValueInTextBoxCard()
        {
            bool verifica;
            if (tboxNome.Enabled == true && tboxCVC.Enabled == true && tboxNumeroCarta.Enabled == true && tboxScadenza.Enabled == true)
            {
                if (tboxNome.Text.Length > 0 && tboxCVC.Text.Length == 3 && tboxNumeroCarta.Text.Length == 16 && tboxScadenza.Text.Length == 7)
                {
                    verifica = true;
                }
                else
                {
                    verifica = false;
                }
            }
            else
            {
                verifica = false;
            }
            return verifica;
        }
        private bool CheckValueInTextBoxName()
        {
            bool verifica;
            if (tboxNomeCassa.Enabled == true)
            {
                if (tboxNomeCassa.Text.Length > 0)
                {
                    verifica = true;
                }
                else
                {
                    verifica = false;
                }
            }
            else
            {
                verifica = false;
            }
            return verifica;
        }
        private void cboxMastercard_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxMastercard.Checked == true)
            {
                this.cboxPagaCassa.Checked = false;
                this.cboxVisa.Checked = false;
                tboxNumeroCarta.Enabled = true;
                tboxNome.Enabled = true;
                tboxCVC.Enabled = true;
                tboxScadenza.Enabled = true;
                tboxNomeCassa.Enabled = false;
            }
            else
            {
                tboxNumeroCarta.Enabled = false;
                tboxNome.Enabled = false;
                tboxCVC.Enabled = false;
                tboxScadenza.Enabled = false;
            }
        }
        private void cboxVisa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxVisa.Checked == true)
            {
                this.cboxMastercard.Checked = false;
                this.cboxPagaCassa.Checked = false;
                tboxNumeroCarta.Enabled = true;
                tboxNome.Enabled = true;
                tboxCVC.Enabled = true;
                tboxScadenza.Enabled = true;
                tboxNomeCassa.Enabled = false;
            }
            else
            {
                tboxNumeroCarta.Enabled = false;
                tboxNome.Enabled = false;
                tboxCVC.Enabled = false;
                tboxScadenza.Enabled = false;
            }
        }
        private void cboxPagaCassa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxPagaCassa.Checked == true)
            {
                this.cboxMastercard.Checked = false;
                this.cboxVisa.Checked = false;
                tboxNumeroCarta.Enabled = false;
                tboxNome.Enabled = false;
                tboxCVC.Enabled = false;
                tboxScadenza.Enabled = false;
                tboxNomeCassa.Enabled = true;
            }
            else
            {
                tboxNomeCassa.Enabled = false;
            }
        }
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Enabled = false;
                    }
                    else
                    {
                        func(control.Controls);
                    }
            };
            func(Controls);
        }
    }
}