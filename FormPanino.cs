using MenuInterattivo.CreaPanino;
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
    public partial class FormPanino : Form
    {
        private IDatabase db;
        private Menu menu;
        private ConcreteBuilderPanino builder = new ConcreteBuilderPanino();
        private Paninaro paninaro = new Paninaro();
        private Panino panino = null;
        public FormPanino(IDatabase database,Menu menu)
        {
            this.FormClosing += this.FormPanino_FormClosing;
            InitializeComponent();
            this.db = database;
            this.menu = menu;
        }
        /* loading of form of program */
        private void FormPanino_Load(object sender, EventArgs e)
        {
            EnableTextBoxes();
        }
        /* closing of form */
        private void FormPanino_FormClosing(Object sender, FormClosingEventArgs e)
        {
            menu.Cibos.Clear();
            this.db.SaveData(menu.Cibos);
            Application.Exit();
        }
        /* action of user */
        private void btnMenuPanino_Click(object sender, EventArgs e)
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
        private void btnConfermaPanino_Click(object sender, EventArgs e)
        {
            menu.Cibos = db.GetData();
            paninaro.Builder = builder;
            OrdinePanino(cboxHamburger, tboxQHamburger);
            OrdinePanino(cboxHotDog, tboxQHotDog);
            OrdinePanino(cboxCheeseburger, tboxQCheeseburger);
            OrdinePanino(cboxChickenBurger, tboxQChickenBurger);
            OrdinePanino(cboxToast, tboxQToast);
            db.SaveData(menu.Cibos);
            this.Hide();
            FormMenu formMenu = new FormMenu(db,menu);
            formMenu.Show();
        }
        /* managment of creation of order of different kind of pizza */
        private void OrdinePanino(CheckBox checkBox, TextBox textBox)
        {
            if (checkBox.Checked == true)
            {
                switch (checkBox.Text)
                {
                    case "Hamburger":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            paninaro.Hamburger();
                            panino = builder.GetPanino();
                            panino.Name = checkBox.Text;
                            menu.Cibos.Add(panino);
                        }
                        break;
                    case "Hot Dog":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            paninaro.HotDog();
                            panino = builder.GetPanino();
                            panino.Name = checkBox.Text;
                            menu.Cibos.Add(panino);
                        }
                        break;
                    case "Cheeseburger":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            paninaro.Cheeseburger();
                            panino = builder.GetPanino();
                            panino.Name = checkBox.Text;
                            menu.Cibos.Add(panino);
                        }
                        break;
                    case "Chicken Burger":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            paninaro.ChickenBurger();
                            panino = builder.GetPanino();
                            panino.Name = checkBox.Text;
                            menu.Cibos.Add(panino);
                        }
                        break;
                    case "Toast":
                        for (int i = 0; i < (int.TryParse(textBox.Text, out int intvalue) ? intvalue : 0); i++)
                        {
                            paninaro.Toast();
                            panino = builder.GetPanino();
                            panino.Name = checkBox.Text;
                            menu.Cibos.Add(panino);
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
        private void cboxHamburger_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQHamburger);
        }
        private void cboxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQHotDog);
        }
        private void cboxCheeseburger_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQCheeseburger);
        }
        private void cboxChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQChickenBurger);
        }
        private void cboxToast_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).EnableCheckBox(tboxQToast);
        }
        /* function that allows you to type only numbers from the keyboard*/
        internal void HandleQuantityInput(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tboxQHamburger_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }
        private void tboxQHotDog_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }
        private void tboxQCheeseburger_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }
        private void tboxQChickenBurger_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }
        private void tboxQToast_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleQuantityInput(e);
        }
    }
}