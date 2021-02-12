using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MenuInterattivo.Model;
using System.Linq;
using MenuInterattivo.CreaPizza;
using MenuInterattivo.Extension;

namespace MenuInterattivo
{
    public partial class FormPizza : Form
    {
        private IDatabase db;
        private Menu menu;
        private ConcreteBuilderPizza builder = new ConcreteBuilderPizza();
        private Pizzaiolo pizzaiolo = new Pizzaiolo();
        private Pizza pizza = null;
        public FormPizza(IDatabase database,Menu menu)
        {
            InitializeComponent();
            this.db = database;
            this.menu = menu;
        }

        /* loading of form of program*/
        private void FormPizza_Load(object sender, EventArgs e)
        {
            EnableTextBoxes();
        }

        /* action uf user*/
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
            ResetCheckBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu(db,menu);
            formMenu.Show();
        }
        private void btnConfermaPizze_Click(object sender, EventArgs e)
        {
            pizzaiolo.Builder = builder;
            OrdinePizza(cboxMargherita, tboxQuantitaMargherita);
            OrdinePizza(cboxPepSal, txtboxQPepSal);
            OrdinePizza(cboxOlive, tboxQOlive);
            OrdinePizza(cboxFunghiSalsiccia, tboxQFunghiSalsiccia);
            OrdinePizza(cboxSalamePiccante, tboxQSalamePiccante);
            OrdinePizza(cboxWustelPatatine, tboxQWustelPatatine);
            db.SaveData(menu.Cibos);
            this.Hide();
            FormMenu formMenu = new FormMenu(db,menu);
            formMenu.Show();
        }

        /* managment of creation of order of different kind of pizza */
        private void OrdinePizza(CheckBox checkBox, TextBox textBox)
        {
            if (checkBox.Checked == true)
            {
                switch (checkBox.Text)
                {
                    case "Margherita":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            pizzaiolo.PizzaMargherita();
                            pizza = builder.GetPizza();
                            pizza.Name = checkBox.Text;
                            menu.Cibos.Add(pizza);
                        }
                        break;
                    case "Peperoni Salsiccia":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            pizzaiolo.PizzaPeperoniSalsiccia();
                            pizza = builder.GetPizza();
                            pizza.Name = checkBox.Text;
                            menu.Cibos.Add(pizza);
                        }
                        break;
                    case "Olive":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            pizzaiolo.PizzaOlive();
                            pizza = builder.GetPizza();
                            pizza.Name = checkBox.Text;
                            menu.Cibos.Add(pizza);
                        }
                        break;
                    case "Funghi Salsiccia":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            pizzaiolo.PizzaFunghiSalsiccia();
                            pizza = builder.GetPizza();
                            pizza.Name = checkBox.Text;
                            menu.Cibos.Add(pizza);
                        }
                        break;
                    case "Salame Piccante":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            pizzaiolo.PizzaSalamePiccante();
                            pizza = builder.GetPizza();
                            pizza.Name = checkBox.Text;
                            menu.Cibos.Add(pizza);
                        }
                        break;
                    case "Wustel Patatine":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            pizzaiolo.PizzaWustelPatatine();
                            pizza = builder.GetPizza();
                            pizza.Name = checkBox.Text;
                            menu.Cibos.Add(pizza);
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
        private void cboxpepsal_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(txtboxQPepSal);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQuantitaMargherita);
        }

        private void cboxOlive_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQOlive);
        }

        private void cboxFunghiSalsiccia_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQFunghiSalsiccia);
        }

        private void cboxSalamePiccante_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQSalamePiccante);
        }

        private void cboxWustelPatatine_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQWustelPatatine);
        }

        /* function that allows you to type only numbers from the keyboard*/
        internal void HandleQuantityInput(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); 
        }

        private void tboxQuantitaMargherita_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }

        private void txtboxQPepSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }

        private void tboxQOlive_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }

        private void tboxQFunghiSalsiccia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }

        private void tboxQSalamePiccante_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }

        private void tboxQWustelPatatine_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }
    }
}
