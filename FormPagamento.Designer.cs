namespace MenuInterattivo
{
    partial class FormPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagamento));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotale = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.cboxMastercard = new System.Windows.Forms.CheckBox();
            this.cboxVisa = new System.Windows.Forms.CheckBox();
            this.cboxPagaCassa = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tboxNome = new System.Windows.Forms.TextBox();
            this.tboxScadenza = new System.Windows.Forms.TextBox();
            this.tboxNumeroCarta = new System.Windows.Forms.TextBox();
            this.tboxCVC = new System.Windows.Forms.TextBox();
            this.lblNomeProprietario = new System.Windows.Forms.Label();
            this.lblNumeroCarta = new System.Windows.Forms.Label();
            this.lblScadenza = new System.Windows.Forms.Label();
            this.lblCVC = new System.Windows.Forms.Label();
            this.tboxNomeCassa = new System.Windows.Forms.TextBox();
            this.lblNomeCassa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTALE:";
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Location = new System.Drawing.Point(204, 47);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(17, 15);
            this.lblTotale.TabIndex = 1;
            this.lblTotale.Text = "\"\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Metodo Di Pagamento";
            // 
            // btnIndietro
            // 
            this.btnIndietro.Location = new System.Drawing.Point(423, 465);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(75, 23);
            this.btnIndietro.TabIndex = 4;
            this.btnIndietro.Text = "Indietro";
            this.btnIndietro.UseVisualStyleBackColor = true;
            this.btnIndietro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(504, 465);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(110, 23);
            this.btnConferma.TabIndex = 5;
            this.btnConferma.Text = "Conferma Ordine";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // cboxMastercard
            // 
            this.cboxMastercard.AutoSize = true;
            this.cboxMastercard.Location = new System.Drawing.Point(35, 170);
            this.cboxMastercard.Name = "cboxMastercard";
            this.cboxMastercard.Size = new System.Drawing.Size(15, 14);
            this.cboxMastercard.TabIndex = 6;
            this.cboxMastercard.UseVisualStyleBackColor = true;
            this.cboxMastercard.CheckedChanged += new System.EventHandler(this.cboxMastercard_CheckedChanged);
            // 
            // cboxVisa
            // 
            this.cboxVisa.AutoSize = true;
            this.cboxVisa.Location = new System.Drawing.Point(191, 170);
            this.cboxVisa.Name = "cboxVisa";
            this.cboxVisa.Size = new System.Drawing.Size(15, 14);
            this.cboxVisa.TabIndex = 7;
            this.cboxVisa.UseVisualStyleBackColor = true;
            this.cboxVisa.CheckedChanged += new System.EventHandler(this.cboxVisa_CheckedChanged);
            // 
            // cboxPagaCassa
            // 
            this.cboxPagaCassa.AutoSize = true;
            this.cboxPagaCassa.Location = new System.Drawing.Point(339, 170);
            this.cboxPagaCassa.Name = "cboxPagaCassa";
            this.cboxPagaCassa.Size = new System.Drawing.Size(15, 14);
            this.cboxPagaCassa.TabIndex = 9;
            this.cboxPagaCassa.UseVisualStyleBackColor = true;
            this.cboxPagaCassa.CheckedChanged += new System.EventHandler(this.cboxPagaCassa_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(191, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(339, 200);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // tboxNome
            // 
            this.tboxNome.Location = new System.Drawing.Point(35, 354);
            this.tboxNome.Name = "tboxNome";
            this.tboxNome.Size = new System.Drawing.Size(275, 23);
            this.tboxNome.TabIndex = 11;
            // 
            // tboxScadenza
            // 
            this.tboxScadenza.Location = new System.Drawing.Point(400, 354);
            this.tboxScadenza.Name = "tboxScadenza";
            this.tboxScadenza.Size = new System.Drawing.Size(124, 23);
            this.tboxScadenza.TabIndex = 11;
            this.tboxScadenza.Text = "MM/AAAA";
            this.tboxScadenza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboxNumeroCarta
            // 
            this.tboxNumeroCarta.Location = new System.Drawing.Point(35, 422);
            this.tboxNumeroCarta.Name = "tboxNumeroCarta";
            this.tboxNumeroCarta.Size = new System.Drawing.Size(275, 23);
            this.tboxNumeroCarta.TabIndex = 11;
            // 
            // tboxCVC
            // 
            this.tboxCVC.Location = new System.Drawing.Point(400, 422);
            this.tboxCVC.Name = "tboxCVC";
            this.tboxCVC.Size = new System.Drawing.Size(70, 23);
            this.tboxCVC.TabIndex = 11;
            this.tboxCVC.Text = "000";
            this.tboxCVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNomeProprietario
            // 
            this.lblNomeProprietario.AutoSize = true;
            this.lblNomeProprietario.Location = new System.Drawing.Point(35, 325);
            this.lblNomeProprietario.Name = "lblNomeProprietario";
            this.lblNomeProprietario.Size = new System.Drawing.Size(105, 15);
            this.lblNomeProprietario.TabIndex = 12;
            this.lblNomeProprietario.Text = "Nome Proprietario";
            // 
            // lblNumeroCarta
            // 
            this.lblNumeroCarta.AutoSize = true;
            this.lblNumeroCarta.Location = new System.Drawing.Point(30, 395);
            this.lblNumeroCarta.Name = "lblNumeroCarta";
            this.lblNumeroCarta.Size = new System.Drawing.Size(82, 15);
            this.lblNumeroCarta.TabIndex = 12;
            this.lblNumeroCarta.Text = "Numero Carta";
            // 
            // lblScadenza
            // 
            this.lblScadenza.AutoSize = true;
            this.lblScadenza.Location = new System.Drawing.Point(400, 325);
            this.lblScadenza.Name = "lblScadenza";
            this.lblScadenza.Size = new System.Drawing.Size(56, 15);
            this.lblScadenza.TabIndex = 12;
            this.lblScadenza.Text = "Scadenza";
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Location = new System.Drawing.Point(400, 395);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(70, 15);
            this.lblCVC.TabIndex = 12;
            this.lblCVC.Text = "Codice CVC";
            // 
            // tboxNomeCassa
            // 
            this.tboxNomeCassa.Location = new System.Drawing.Point(339, 280);
            this.tboxNomeCassa.Name = "tboxNomeCassa";
            this.tboxNomeCassa.Size = new System.Drawing.Size(224, 23);
            this.tboxNomeCassa.TabIndex = 13;
            // 
            // lblNomeCassa
            // 
            this.lblNomeCassa.AutoSize = true;
            this.lblNomeCassa.Location = new System.Drawing.Point(339, 262);
            this.lblNomeCassa.Name = "lblNomeCassa";
            this.lblNomeCassa.Size = new System.Drawing.Size(231, 15);
            this.lblNomeCassa.TabIndex = 14;
            this.lblNomeCassa.Text = "Nome con cui vieni riconosciuto alla cassa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "€";
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeCassa);
            this.Controls.Add(this.tboxNomeCassa);
            this.Controls.Add(this.lblCVC);
            this.Controls.Add(this.lblScadenza);
            this.Controls.Add(this.lblNumeroCarta);
            this.Controls.Add(this.lblNomeProprietario);
            this.Controls.Add(this.tboxCVC);
            this.Controls.Add(this.tboxNumeroCarta);
            this.Controls.Add(this.tboxScadenza);
            this.Controls.Add(this.tboxNome);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboxPagaCassa);
            this.Controls.Add(this.cboxVisa);
            this.Controls.Add(this.cboxMastercard);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotale);
            this.Controls.Add(this.label1);
            this.Name = "FormPagamento";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.CheckBox cboxMastercard;
        private System.Windows.Forms.CheckBox cboxVisa;
        private System.Windows.Forms.CheckBox cboxPagaCassa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tboxNome;
        private System.Windows.Forms.TextBox tboxScadenza;
        private System.Windows.Forms.TextBox tboxNumeroCarta;
        private System.Windows.Forms.TextBox tboxCVC;
        private System.Windows.Forms.Label lblNomeProprietario;
        private System.Windows.Forms.Label lblNumeroCarta;
        private System.Windows.Forms.Label lblScadenza;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.TextBox tboxNomeCassa;
        private System.Windows.Forms.Label lblNomeCassa;
        private System.Windows.Forms.Label label2;
    }
}