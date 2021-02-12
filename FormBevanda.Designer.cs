namespace MenuInterattivo
{
    partial class FormBevanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBevanda));
            this.btnBevandaMenu = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboxAcqua = new System.Windows.Forms.CheckBox();
            this.cboxVino = new System.Windows.Forms.CheckBox();
            this.cboxBirra = new System.Windows.Forms.CheckBox();
            this.cboxCocaCola = new System.Windows.Forms.CheckBox();
            this.cboxFanta = new System.Windows.Forms.CheckBox();
            this.cboxSprite = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxQAcqua = new System.Windows.Forms.TextBox();
            this.tboxQSprite = new System.Windows.Forms.TextBox();
            this.tboxQFanta = new System.Windows.Forms.TextBox();
            this.tboxQCocaCola = new System.Windows.Forms.TextBox();
            this.tboxQBirra = new System.Windows.Forms.TextBox();
            this.tboxQVino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBevandaMenu
            // 
            this.btnBevandaMenu.Location = new System.Drawing.Point(531, 398);
            this.btnBevandaMenu.Name = "btnBevandaMenu";
            this.btnBevandaMenu.Size = new System.Drawing.Size(92, 29);
            this.btnBevandaMenu.TabIndex = 0;
            this.btnBevandaMenu.Text = "Torna al menù";
            this.btnBevandaMenu.UseVisualStyleBackColor = true;
            this.btnBevandaMenu.Click += new System.EventHandler(this.btnBevandaMenu_Click);
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(450, 404);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 1;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(369, 404);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cboxAcqua
            // 
            this.cboxAcqua.AutoSize = true;
            this.cboxAcqua.Location = new System.Drawing.Point(60, 132);
            this.cboxAcqua.Name = "cboxAcqua";
            this.cboxAcqua.Size = new System.Drawing.Size(60, 19);
            this.cboxAcqua.TabIndex = 3;
            this.cboxAcqua.Text = "Acqua";
            this.cboxAcqua.UseVisualStyleBackColor = true;
            this.cboxAcqua.CheckedChanged += new System.EventHandler(this.cboxAcqua_CheckedChanged);
            // 
            // cboxVino
            // 
            this.cboxVino.AutoSize = true;
            this.cboxVino.Location = new System.Drawing.Point(60, 168);
            this.cboxVino.Name = "cboxVino";
            this.cboxVino.Size = new System.Drawing.Size(50, 19);
            this.cboxVino.TabIndex = 3;
            this.cboxVino.Text = "Vino";
            this.cboxVino.UseVisualStyleBackColor = true;
            this.cboxVino.CheckedChanged += new System.EventHandler(this.cboxVino_CheckedChanged);
            // 
            // cboxBirra
            // 
            this.cboxBirra.AutoSize = true;
            this.cboxBirra.Location = new System.Drawing.Point(60, 207);
            this.cboxBirra.Name = "cboxBirra";
            this.cboxBirra.Size = new System.Drawing.Size(50, 19);
            this.cboxBirra.TabIndex = 3;
            this.cboxBirra.Text = "Birra";
            this.cboxBirra.UseVisualStyleBackColor = true;
            this.cboxBirra.CheckedChanged += new System.EventHandler(this.cboxBirra_CheckedChanged);
            // 
            // cboxCocaCola
            // 
            this.cboxCocaCola.AutoSize = true;
            this.cboxCocaCola.Location = new System.Drawing.Point(60, 243);
            this.cboxCocaCola.Name = "cboxCocaCola";
            this.cboxCocaCola.Size = new System.Drawing.Size(80, 19);
            this.cboxCocaCola.TabIndex = 3;
            this.cboxCocaCola.Text = "Coca Cola";
            this.cboxCocaCola.UseVisualStyleBackColor = true;
            this.cboxCocaCola.CheckedChanged += new System.EventHandler(this.cboxCocaCola_CheckedChanged);
            // 
            // cboxFanta
            // 
            this.cboxFanta.AutoSize = true;
            this.cboxFanta.Location = new System.Drawing.Point(60, 279);
            this.cboxFanta.Name = "cboxFanta";
            this.cboxFanta.Size = new System.Drawing.Size(55, 19);
            this.cboxFanta.TabIndex = 3;
            this.cboxFanta.Text = "Fanta";
            this.cboxFanta.UseVisualStyleBackColor = true;
            this.cboxFanta.CheckedChanged += new System.EventHandler(this.cboxFanta_CheckedChanged);
            // 
            // cboxSprite
            // 
            this.cboxSprite.AutoSize = true;
            this.cboxSprite.Location = new System.Drawing.Point(60, 316);
            this.cboxSprite.Name = "cboxSprite";
            this.cboxSprite.Size = new System.Drawing.Size(56, 19);
            this.cboxSprite.TabIndex = 3;
            this.cboxSprite.Text = "Sprite";
            this.cboxSprite.UseVisualStyleBackColor = true;
            this.cboxSprite.CheckedChanged += new System.EventHandler(this.cboxSprite_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantità";
            // 
            // tboxQAcqua
            // 
            this.tboxQAcqua.Location = new System.Drawing.Point(453, 128);
            this.tboxQAcqua.Name = "tboxQAcqua";
            this.tboxQAcqua.Size = new System.Drawing.Size(100, 23);
            this.tboxQAcqua.TabIndex = 5;
            this.tboxQAcqua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQAcqua_KeyPress);
            // 
            // tboxQSprite
            // 
            this.tboxQSprite.Location = new System.Drawing.Point(453, 316);
            this.tboxQSprite.Name = "tboxQSprite";
            this.tboxQSprite.Size = new System.Drawing.Size(100, 23);
            this.tboxQSprite.TabIndex = 5;
            this.tboxQSprite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQSprite_KeyPress);
            // 
            // tboxQFanta
            // 
            this.tboxQFanta.Location = new System.Drawing.Point(453, 275);
            this.tboxQFanta.Name = "tboxQFanta";
            this.tboxQFanta.Size = new System.Drawing.Size(100, 23);
            this.tboxQFanta.TabIndex = 5;
            this.tboxQFanta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQFanta_KeyPress);
            // 
            // tboxQCocaCola
            // 
            this.tboxQCocaCola.Location = new System.Drawing.Point(453, 236);
            this.tboxQCocaCola.Name = "tboxQCocaCola";
            this.tboxQCocaCola.Size = new System.Drawing.Size(100, 23);
            this.tboxQCocaCola.TabIndex = 5;
            this.tboxQCocaCola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQCocaCola_KeyPress);
            // 
            // tboxQBirra
            // 
            this.tboxQBirra.Location = new System.Drawing.Point(453, 203);
            this.tboxQBirra.Name = "tboxQBirra";
            this.tboxQBirra.Size = new System.Drawing.Size(100, 23);
            this.tboxQBirra.TabIndex = 5;
            this.tboxQBirra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQBirra_KeyPress);
            // 
            // tboxQVino
            // 
            this.tboxQVino.Location = new System.Drawing.Point(453, 166);
            this.tboxQVino.Name = "tboxQVino";
            this.tboxQVino.Size = new System.Drawing.Size(100, 23);
            this.tboxQVino.TabIndex = 5;
            this.tboxQVino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQVino_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(220, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Scegli bevanda";
            // 
            // FormBevanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(635, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxQVino);
            this.Controls.Add(this.tboxQBirra);
            this.Controls.Add(this.tboxQCocaCola);
            this.Controls.Add(this.tboxQFanta);
            this.Controls.Add(this.tboxQSprite);
            this.Controls.Add(this.tboxQAcqua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxSprite);
            this.Controls.Add(this.cboxFanta);
            this.Controls.Add(this.cboxCocaCola);
            this.Controls.Add(this.cboxBirra);
            this.Controls.Add(this.cboxVino);
            this.Controls.Add(this.cboxAcqua);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.btnBevandaMenu);
            this.Name = "FormBevanda";
            this.Text = "Scegli Bevanda";
            this.Load += new System.EventHandler(this.FormBevanda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBevandaMenu;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox cboxAcqua;
        private System.Windows.Forms.CheckBox cboxVino;
        private System.Windows.Forms.CheckBox cboxBirra;
        private System.Windows.Forms.CheckBox cboxCocaCola;
        private System.Windows.Forms.CheckBox cboxFanta;
        private System.Windows.Forms.CheckBox cboxSprite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxQAcqua;
        private System.Windows.Forms.TextBox tboxQSprite;
        private System.Windows.Forms.TextBox tboxQFanta;
        private System.Windows.Forms.TextBox tboxQCocaCola;
        private System.Windows.Forms.TextBox tboxQBirra;
        private System.Windows.Forms.TextBox tboxQVino;
        private System.Windows.Forms.Label label2;
    }
}