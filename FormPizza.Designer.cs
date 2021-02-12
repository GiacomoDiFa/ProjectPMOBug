namespace MenuInterattivo
{
    partial class FormPizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPizza));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrezzoPizzaw = new System.Windows.Forms.Label();
            this.tboxQuantitaMargherita = new System.Windows.Forms.TextBox();
            this.txtboxQPepSal = new System.Windows.Forms.TextBox();
            this.lblQuantita = new System.Windows.Forms.Label();
            this.cboxMargherita = new System.Windows.Forms.CheckBox();
            this.cboxPepSal = new System.Windows.Forms.CheckBox();
            this.cboxWustelPatatine = new System.Windows.Forms.CheckBox();
            this.cboxSalamePiccante = new System.Windows.Forms.CheckBox();
            this.cboxFunghiSalsiccia = new System.Windows.Forms.CheckBox();
            this.cboxOlive = new System.Windows.Forms.CheckBox();
            this.btnConfermaPizze = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tboxQOlive = new System.Windows.Forms.TextBox();
            this.tboxQWustelPatatine = new System.Windows.Forms.TextBox();
            this.tboxQSalamePiccante = new System.Windows.Forms.TextBox();
            this.tboxQFunghiSalsiccia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(222, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = " Scegli la pizza";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(532, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Torna al menù";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrezzoPizzaw
            // 
            this.lblPrezzoPizzaw.AutoSize = true;
            this.lblPrezzoPizzaw.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrezzoPizzaw.Location = new System.Drawing.Point(235, 424);
            this.lblPrezzoPizzaw.Name = "lblPrezzoPizzaw";
            this.lblPrezzoPizzaw.Size = new System.Drawing.Size(0, 28);
            this.lblPrezzoPizzaw.TabIndex = 3;
            // 
            // tboxQuantitaMargherita
            // 
            this.tboxQuantitaMargherita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxQuantitaMargherita.Location = new System.Drawing.Point(442, 107);
            this.tboxQuantitaMargherita.Name = "tboxQuantitaMargherita";
            this.tboxQuantitaMargherita.Size = new System.Drawing.Size(100, 23);
            this.tboxQuantitaMargherita.TabIndex = 5;
            this.tboxQuantitaMargherita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQuantitaMargherita_KeyPress);
            // 
            // txtboxQPepSal
            // 
            this.txtboxQPepSal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxQPepSal.Location = new System.Drawing.Point(442, 145);
            this.txtboxQPepSal.Name = "txtboxQPepSal";
            this.txtboxQPepSal.Size = new System.Drawing.Size(100, 23);
            this.txtboxQPepSal.TabIndex = 6;
            this.txtboxQPepSal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxQPepSal_KeyPress);
            // 
            // lblQuantita
            // 
            this.lblQuantita.AutoSize = true;
            this.lblQuantita.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantita.Location = new System.Drawing.Point(457, 76);
            this.lblQuantita.Name = "lblQuantita";
            this.lblQuantita.Size = new System.Drawing.Size(76, 28);
            this.lblQuantita.TabIndex = 7;
            this.lblQuantita.Text = "Quantità";
            // 
            // cboxMargherita
            // 
            this.cboxMargherita.AutoSize = true;
            this.cboxMargherita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxMargherita.Location = new System.Drawing.Point(31, 111);
            this.cboxMargherita.Name = "cboxMargherita";
            this.cboxMargherita.Size = new System.Drawing.Size(84, 19);
            this.cboxMargherita.TabIndex = 8;
            this.cboxMargherita.Text = "Margherita";
            this.cboxMargherita.UseVisualStyleBackColor = true;
            this.cboxMargherita.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cboxPepSal
            // 
            this.cboxPepSal.AutoSize = true;
            this.cboxPepSal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxPepSal.Location = new System.Drawing.Point(31, 150);
            this.cboxPepSal.Name = "cboxPepSal";
            this.cboxPepSal.Size = new System.Drawing.Size(120, 19);
            this.cboxPepSal.TabIndex = 9;
            this.cboxPepSal.Text = "Peperoni Salsiccia";
            this.cboxPepSal.UseVisualStyleBackColor = true;
            this.cboxPepSal.CheckedChanged += new System.EventHandler(this.cboxpepsal_CheckedChanged);
            // 
            // cboxWustelPatatine
            // 
            this.cboxWustelPatatine.AutoSize = true;
            this.cboxWustelPatatine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxWustelPatatine.Location = new System.Drawing.Point(31, 303);
            this.cboxWustelPatatine.Name = "cboxWustelPatatine";
            this.cboxWustelPatatine.Size = new System.Drawing.Size(108, 19);
            this.cboxWustelPatatine.TabIndex = 9;
            this.cboxWustelPatatine.Text = "Wustel Patatine";
            this.cboxWustelPatatine.UseVisualStyleBackColor = true;
            this.cboxWustelPatatine.CheckedChanged += new System.EventHandler(this.cboxWustelPatatine_CheckedChanged);
            // 
            // cboxSalamePiccante
            // 
            this.cboxSalamePiccante.AutoSize = true;
            this.cboxSalamePiccante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxSalamePiccante.Location = new System.Drawing.Point(31, 265);
            this.cboxSalamePiccante.Name = "cboxSalamePiccante";
            this.cboxSalamePiccante.Size = new System.Drawing.Size(112, 19);
            this.cboxSalamePiccante.TabIndex = 9;
            this.cboxSalamePiccante.Text = "Salame Piccante";
            this.cboxSalamePiccante.UseVisualStyleBackColor = true;
            this.cboxSalamePiccante.CheckedChanged += new System.EventHandler(this.cboxSalamePiccante_CheckedChanged);
            // 
            // cboxFunghiSalsiccia
            // 
            this.cboxFunghiSalsiccia.AutoSize = true;
            this.cboxFunghiSalsiccia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxFunghiSalsiccia.Location = new System.Drawing.Point(31, 228);
            this.cboxFunghiSalsiccia.Name = "cboxFunghiSalsiccia";
            this.cboxFunghiSalsiccia.Size = new System.Drawing.Size(110, 19);
            this.cboxFunghiSalsiccia.TabIndex = 9;
            this.cboxFunghiSalsiccia.Text = "Funghi Salsiccia";
            this.cboxFunghiSalsiccia.UseVisualStyleBackColor = true;
            this.cboxFunghiSalsiccia.CheckedChanged += new System.EventHandler(this.cboxFunghiSalsiccia_CheckedChanged);
            // 
            // cboxOlive
            // 
            this.cboxOlive.AutoSize = true;
            this.cboxOlive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxOlive.Location = new System.Drawing.Point(31, 186);
            this.cboxOlive.Name = "cboxOlive";
            this.cboxOlive.Size = new System.Drawing.Size(53, 19);
            this.cboxOlive.TabIndex = 9;
            this.cboxOlive.Text = "Olive";
            this.cboxOlive.UseVisualStyleBackColor = true;
            this.cboxOlive.CheckedChanged += new System.EventHandler(this.cboxOlive_CheckedChanged);
            // 
            // btnConfermaPizze
            // 
            this.btnConfermaPizze.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfermaPizze.Location = new System.Drawing.Point(416, 370);
            this.btnConfermaPizze.Name = "btnConfermaPizze";
            this.btnConfermaPizze.Size = new System.Drawing.Size(97, 27);
            this.btnConfermaPizze.TabIndex = 10;
            this.btnConfermaPizze.Text = "Conferma";
            this.btnConfermaPizze.UseVisualStyleBackColor = true;
            this.btnConfermaPizze.Click += new System.EventHandler(this.btnConfermaPizze_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(303, 370);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 27);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tboxQOlive
            // 
            this.tboxQOlive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxQOlive.Location = new System.Drawing.Point(442, 182);
            this.tboxQOlive.Name = "tboxQOlive";
            this.tboxQOlive.Size = new System.Drawing.Size(100, 23);
            this.tboxQOlive.TabIndex = 12;
            this.tboxQOlive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQOlive_KeyPress);
            // 
            // tboxQWustelPatatine
            // 
            this.tboxQWustelPatatine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxQWustelPatatine.Location = new System.Drawing.Point(442, 294);
            this.tboxQWustelPatatine.Name = "tboxQWustelPatatine";
            this.tboxQWustelPatatine.Size = new System.Drawing.Size(100, 23);
            this.tboxQWustelPatatine.TabIndex = 12;
            this.tboxQWustelPatatine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQWustelPatatine_KeyPress);
            // 
            // tboxQSalamePiccante
            // 
            this.tboxQSalamePiccante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxQSalamePiccante.Location = new System.Drawing.Point(442, 256);
            this.tboxQSalamePiccante.Name = "tboxQSalamePiccante";
            this.tboxQSalamePiccante.Size = new System.Drawing.Size(100, 23);
            this.tboxQSalamePiccante.TabIndex = 12;
            this.tboxQSalamePiccante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQSalamePiccante_KeyPress);
            // 
            // tboxQFunghiSalsiccia
            // 
            this.tboxQFunghiSalsiccia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxQFunghiSalsiccia.Location = new System.Drawing.Point(442, 219);
            this.tboxQFunghiSalsiccia.Name = "tboxQFunghiSalsiccia";
            this.tboxQFunghiSalsiccia.Size = new System.Drawing.Size(100, 23);
            this.tboxQFunghiSalsiccia.TabIndex = 12;
            this.tboxQFunghiSalsiccia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQFunghiSalsiccia_KeyPress);
            // 
            // FormPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(635, 500);
            this.Controls.Add(this.tboxQFunghiSalsiccia);
            this.Controls.Add(this.tboxQSalamePiccante);
            this.Controls.Add(this.tboxQWustelPatatine);
            this.Controls.Add(this.tboxQOlive);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfermaPizze);
            this.Controls.Add(this.cboxOlive);
            this.Controls.Add(this.cboxFunghiSalsiccia);
            this.Controls.Add(this.cboxSalamePiccante);
            this.Controls.Add(this.cboxWustelPatatine);
            this.Controls.Add(this.cboxPepSal);
            this.Controls.Add(this.cboxMargherita);
            this.Controls.Add(this.lblQuantita);
            this.Controls.Add(this.txtboxQPepSal);
            this.Controls.Add(this.tboxQuantitaMargherita);
            this.Controls.Add(this.lblPrezzoPizzaw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormPizza";
            this.Text = "Choise Your Pizza";
            this.Load += new System.EventHandler(this.FormPizza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrezzoPizzaw;
        private System.Windows.Forms.TextBox tboxQuantitaMargherita;
        private System.Windows.Forms.TextBox txtboxQPepSal;
        private System.Windows.Forms.Label lblQuantita;
        private System.Windows.Forms.CheckBox cboxMargherita;
        private System.Windows.Forms.CheckBox cboxPepSal;
        private System.Windows.Forms.CheckBox cboxWustelPatatine;
        private System.Windows.Forms.CheckBox cboxSalamePiccante;
        private System.Windows.Forms.CheckBox cboxFunghiSalsiccia;
        private System.Windows.Forms.CheckBox cboxOlive;
        private System.Windows.Forms.Button btnConfermaPizze;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tboxQOlive;
        private System.Windows.Forms.TextBox tboxQWustelPatatine;
        private System.Windows.Forms.TextBox tboxQSalamePiccante;
        private System.Windows.Forms.TextBox tboxQFunghiSalsiccia;
    }
}