using MenuInterattivo.CreaBevanda;
using MenuInterattivo.Extension;
using MenuInterattivo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MenuInterattivo
{
    public partial class FormBevanda : Form
    {
        private IDatabase db;
        private Menu menu;
        private ConcreteBuilderBevanda builder = new ConcreteBuilderBevanda();
        private Barman barman = new Barman();
        private Bevanda bevanda = null;
        public FormBevanda(IDatabase database,Menu menu)
        {
            InitializeComponent();
            this.db = database;
            this.menu = menu;
        }
        /* loading of form Bevanda */
        private void FormBevanda_Load(object sender, EventArgs e)
        {
            EnableTextBoxes();
        }

        /* action of user */
        private void btnBevandaMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu(db,menu);
            formMenu.Show();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
            ResetCheckBoxes();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            db.GetData();
            barman.Builder = builder;
            OrdineBevanda(cboxAcqua, tboxQAcqua);
            OrdineBevanda(cboxVino, tboxQVino);
            OrdineBevanda(cboxBirra, tboxQBirra);
            OrdineBevanda(cboxCocaCola, tboxQCocaCola);
            OrdineBevanda(cboxFanta, tboxQFanta);
            OrdineBevanda(cboxSprite, tboxQSprite);
            db.SaveData(menu.Cibos);
            this.Hide();
            FormMenu formMenu = new FormMenu(db,menu);
            formMenu.Show();
        }
        /* managment of creation of order of different kind of pizza */
        private void OrdineBevanda(CheckBox checkBox, TextBox textBox)
        {
            if (checkBox.Checked == true)
            {
                switch (checkBox.Text)
                {
                    case "Acqua":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            barman.Acqua();
                            bevanda = builder.GetBevanda();
                            bevanda.Name = checkBox.Text;
                            menu.Cibos.Add(bevanda);
                        }
                        break;
                    case "Vino":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            barman.Vino();
                            bevanda = builder.GetBevanda();
                            bevanda.Name = checkBox.Text;
                            menu.Cibos.Add(bevanda);
                        }
                        break;
                    case "Birra":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            barman.Birra();
                            bevanda = builder.GetBevanda();
                            bevanda.Name = checkBox.Text;
                            menu.Cibos.Add(bevanda);
                        }
                        break;
                    case "Coca Cola":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            barman.CocaCola();
                            bevanda = builder.GetBevanda();
                            bevanda.Name = checkBox.Text;
                            menu.Cibos.Add(bevanda);
                        }
                        break;
                    case "Fanta":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            barman.Fanta();
                            bevanda = builder.GetBevanda();
                            bevanda.Name = checkBox.Text;
                            menu.Cibos.Add(bevanda);
                        }
                        break;
                    case "Sprite":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            barman.Sprite();
                            bevanda = builder.GetBevanda();
                            bevanda.Name = checkBox.Text;
                            menu.Cibos.Add(bevanda);
                        }
                        break;
                    default:
                        throw new Exception();
                }
            }
        }
        
        /* managment of checkbox and textbox*/
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
        private void ResetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                    {
                        (control as CheckBox).Checked = false;
                    }
                    else
                    {
                        func(control.Controls);
                    }
            };
            func(Controls);
        }
        private void ResetTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Text = "";
                    }
                    else
                    {
                        func(control.Controls);
                    }
            };
            func(Controls);
        }

        private void cboxAcqua_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQAcqua);
        }

        private void cboxVino_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQVino);
        }

        private void cboxBirra_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQBirra);
        }

        private void cboxCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQCocaCola);
        }

        private void cboxFanta_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQFanta);
        }

        private void cboxSprite_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQSprite);
        }

        /* function that allows you to type only numbers from the keyboard*/
        internal void HandleQuantityInput(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tboxQAcqua_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }

        private void tboxQVino_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }

        private void tboxQBirra_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }

        private void tboxQCocaCola_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }

        private void tboxQFanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }

        private void tboxQSprite_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }
    }
}
