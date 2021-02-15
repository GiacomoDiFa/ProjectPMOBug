namespace MenuInterattivo
{
    partial class FormCarrello
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstViewCibo = new System.Windows.Forms.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.columnDescritpion = new System.Windows.Forms.ColumnHeader();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTornaAlMenu = new System.Windows.Forms.Button();
            this.lblCiboOrdinato = new System.Windows.Forms.Label();
            this.lblNumerocibo = new System.Windows.Forms.Label();
            this.lblPrezzoTotale = new System.Windows.Forms.Label();
            this.lblQNumeroCibo = new System.Windows.Forms.Label();
            this.lblQPrezzoTotale = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstViewCibo
            // 
            this.lstViewCibo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPrice,
            this.columnDescritpion});
            this.lstViewCibo.FullRowSelect = true;
            this.lstViewCibo.GridLines = true;
            this.lstViewCibo.HideSelection = false;
            this.lstViewCibo.Location = new System.Drawing.Point(12, 70);
            this.lstViewCibo.Name = "lstViewCibo";
            this.lstViewCibo.Size = new System.Drawing.Size(366, 373);
            this.lstViewCibo.TabIndex = 23;
            this.lstViewCibo.UseCompatibleStateImageBehavior = false;
            this.lstViewCibo.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 300;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            // 
            // columnDescritpion
            // 
            this.columnDescritpion.Text = "Description";
            this.columnDescritpion.Width = 500;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(398, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTornaAlMenu
            // 
            this.btnTornaAlMenu.Location = new System.Drawing.Point(504, 434);
            this.btnTornaAlMenu.Name = "btnTornaAlMenu";
            this.btnTornaAlMenu.Size = new System.Drawing.Size(119, 23);
            this.btnTornaAlMenu.TabIndex = 3;
            this.btnTornaAlMenu.Text = "Torna al Menù";
            this.btnTornaAlMenu.UseVisualStyleBackColor = true;
            this.btnTornaAlMenu.Click += new System.EventHandler(this.btnTornaAlMenu_Click);
            // 
            // lblCiboOrdinato
            // 
            this.lblCiboOrdinato.AutoSize = true;
            this.lblCiboOrdinato.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCiboOrdinato.Location = new System.Drawing.Point(12, 32);
            this.lblCiboOrdinato.Name = "lblCiboOrdinato";
            this.lblCiboOrdinato.Size = new System.Drawing.Size(164, 23);
            this.lblCiboOrdinato.TabIndex = 4;
            this.lblCiboOrdinato.Text = "Cibo Ordinato:";
            // 
            // lblNumerocibo
            // 
            this.lblNumerocibo.AutoSize = true;
            this.lblNumerocibo.Location = new System.Drawing.Point(398, 186);
            this.lblNumerocibo.Name = "lblNumerocibo";
            this.lblNumerocibo.Size = new System.Drawing.Size(158, 15);
            this.lblNumerocibo.TabIndex = 5;
            this.lblNumerocibo.Text = "Numero pietanze e bevande:";
            // 
            // lblPrezzoTotale
            // 
            this.lblPrezzoTotale.AutoSize = true;
            this.lblPrezzoTotale.Location = new System.Drawing.Point(398, 232);
            this.lblPrezzoTotale.Name = "lblPrezzoTotale";
            this.lblPrezzoTotale.Size = new System.Drawing.Size(78, 15);
            this.lblPrezzoTotale.TabIndex = 6;
            this.lblPrezzoTotale.Text = "Prezzo Totale:";
            // 
            // lblQNumeroCibo
            // 
            this.lblQNumeroCibo.AutoSize = true;
            this.lblQNumeroCibo.Location = new System.Drawing.Point(566, 186);
            this.lblQNumeroCibo.Name = "lblQNumeroCibo";
            this.lblQNumeroCibo.Size = new System.Drawing.Size(13, 15);
            this.lblQNumeroCibo.TabIndex = 7;
            this.lblQNumeroCibo.Text = "0";
            // 
            // lblQPrezzoTotale
            // 
            this.lblQPrezzoTotale.AutoSize = true;
            this.lblQPrezzoTotale.Location = new System.Drawing.Point(566, 232);
            this.lblQPrezzoTotale.Name = "lblQPrezzoTotale";
            this.lblQPrezzoTotale.Size = new System.Drawing.Size(13, 15);
            this.lblQPrezzoTotale.TabIndex = 8;
            this.lblQPrezzoTotale.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "€";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(438, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // FormCarrello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQPrezzoTotale);
            this.Controls.Add(this.lblQNumeroCibo);
            this.Controls.Add(this.lblPrezzoTotale);
            this.Controls.Add(this.lblNumerocibo);
            this.Controls.Add(this.lblCiboOrdinato);
            this.Controls.Add(this.btnTornaAlMenu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstViewCibo);
            this.Name = "FormCarrello";
            this.Text = "FormCarrello";
            this.Load += new System.EventHandler(this.FormCarrello_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewCibo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTornaAlMenu;
        private System.Windows.Forms.Label lblCiboOrdinato;
        private System.Windows.Forms.Label lblNumerocibo;
        private System.Windows.Forms.Label lblPrezzoTotale;
        private System.Windows.Forms.Label lblQNumeroCibo;
        private System.Windows.Forms.Label lblQPrezzoTotale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnDescritpion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}