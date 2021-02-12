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
    public partial class FormCarrello : Form
    {
        private readonly IDatabase db;
        private Menu menu;
        private Dictionary<IVisitor, Label> visitor;
        private FormMenu formMenu;
        public FormCarrello(IDatabase database,Menu menu)
        {
            InitializeComponent();
            InitializeCalculation();
            db = database;
            this.menu = menu;
            LoadStorage();
        }
        private void InitializeCalculation()
        {
            visitor = new Dictionary<IVisitor, Label> {
                { new ItemCounter(), this.lblQNumeroCibo },
                { new ItemTotalValue(), this.lblQPrezzoTotale }
            };
        }
        private void LoadStorage()
        {
            try
            {
                menu.Cibos = db.GetData();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Can't connect " +ex.Message );
                Console.Error.WriteLine(ex.StackTrace);
                return;
            }

            this.lstViewCibo.Items.Clear();
            this.lstViewCibo.Items.AddRange(menu.Cibos.Select(i => i.ToListViewItem()).ToArray());
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

        private void FormCarrello_Load(object sender, EventArgs e)
        {
            LoadStorage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listItem in this.lstViewCibo.SelectedItems)
            {
                var itemRemove = listItem.ToItem();
                menu.Cibos.Remove(itemRemove);
                break;
            }
            SaveCurrentStorage();
            LoadStorage();
        }

        private void btnTornaAlMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formMenu = new FormMenu(db,menu);
            this.formMenu.Show();
        }
        private void SaveCurrentStorage()
        {
            this.db.SaveData(menu.Cibos);
        }
    }
}
