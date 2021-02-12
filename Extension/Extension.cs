using MenuInterattivo.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MenuInterattivo.Extension
{
    public static class Extension
    {
        public static ListViewItem ToListViewItem(this Cibo cibo)
        {
            string[] row = { cibo.Name, cibo.Price.ToString(), cibo.Description };
            return new ListViewItem(row);
        }
        public static Cibo ToItem(this ListViewItem cibo)
        {
            return new Cibo
            {
                Name = cibo.SubItems[0].Text.ToString(),
                Price = double.Parse(cibo.SubItems[1].Text.ToString()),
                Description = cibo.SubItems[2].Text.ToString(),
            };
        }
    }
    public static class CheckBoxExtenxions
    {
        public static void EnableCheckBox(this CheckBox checkBox, TextBox textBox)
        {
            textBox.Text = "";
            if (checkBox.Checked == true)
            {
                textBox.Enabled = true;
            }
            else
            {
                textBox.Enabled = false;
            }
        }
    }
}
