namespace MenuInterattivo
{
    partial class FormPanino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanino));
            this.btnMenuPanino = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxHamburger = new System.Windows.Forms.CheckBox();
            this.cboxHotDog = new System.Windows.Forms.CheckBox();
            this.cboxCheeseburger = new System.Windows.Forms.CheckBox();
            this.cboxChickenBurger = new System.Windows.Forms.CheckBox();
            this.cboxToast = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxQHamburger = new System.Windows.Forms.TextBox();
            this.tboxQToast = new System.Windows.Forms.TextBox();
            this.tboxQChickenBurger = new System.Windows.Forms.TextBox();
            this.tboxQCheeseburger = new System.Windows.Forms.TextBox();
            this.tboxQHotDog = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConfermaPanino = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuPanino
            // 
            this.btnMenuPanino.Location = new System.Drawing.Point(510, 364);
            this.btnMenuPanino.Name = "btnMenuPanino";
            this.btnMenuPanino.Size = new System.Drawing.Size(113, 23);
            this.btnMenuPanino.TabIndex = 0;
            this.btnMenuPanino.Text = "Torna al menù";
            this.btnMenuPanino.UseVisualStyleBackColor = true;
            this.btnMenuPanino.Click += new System.EventHandler(this.btnMenuPanino_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scegli il panino";
            // 
            // cboxHamburger
            // 
            this.cboxHamburger.AutoSize = true;
            this.cboxHamburger.Location = new System.Drawing.Point(35, 110);
            this.cboxHamburger.Name = "cboxHamburger";
            this.cboxHamburger.Size = new System.Drawing.Size(87, 19);
            this.cboxHamburger.TabIndex = 2;
            this.cboxHamburger.Text = "Hamburger";
            this.cboxHamburger.UseVisualStyleBackColor = true;
            this.cboxHamburger.CheckedChanged += new System.EventHandler(this.cboxHamburger_CheckedChanged);
            // 
            // cboxHotDog
            // 
            this.cboxHotDog.AutoSize = true;
            this.cboxHotDog.Location = new System.Drawing.Point(35, 149);
            this.cboxHotDog.Name = "cboxHotDog";
            this.cboxHotDog.Size = new System.Drawing.Size(71, 19);
            this.cboxHotDog.TabIndex = 3;
            this.cboxHotDog.Text = "Hot Dog";
            this.cboxHotDog.UseVisualStyleBackColor = true;
            this.cboxHotDog.CheckedChanged += new System.EventHandler(this.cboxHotDog_CheckedChanged);
            // 
            // cboxCheeseburger
            // 
            this.cboxCheeseburger.AutoSize = true;
            this.cboxCheeseburger.Location = new System.Drawing.Point(35, 192);
            this.cboxCheeseburger.Name = "cboxCheeseburger";
            this.cboxCheeseburger.Size = new System.Drawing.Size(99, 19);
            this.cboxCheeseburger.TabIndex = 4;
            this.cboxCheeseburger.Text = "Cheeseburger";
            this.cboxCheeseburger.UseVisualStyleBackColor = true;
            this.cboxCheeseburger.CheckedChanged += new System.EventHandler(this.cboxCheeseburger_CheckedChanged);
            // 
            // cboxChickenBurger
            // 
            this.cboxChickenBurger.AutoSize = true;
            this.cboxChickenBurger.Location = new System.Drawing.Point(35, 236);
            this.cboxChickenBurger.Name = "cboxChickenBurger";
            this.cboxChickenBurger.Size = new System.Drawing.Size(107, 19);
            this.cboxChickenBurger.TabIndex = 5;
            this.cboxChickenBurger.Text = "Chicken Burger";
            this.cboxChickenBurger.UseVisualStyleBackColor = true;
            this.cboxChickenBurger.CheckedChanged += new System.EventHandler(this.cboxChickenBurger_CheckedChanged);
            // 
            // cboxToast
            // 
            this.cboxToast.AutoSize = true;
            this.cboxToast.Location = new System.Drawing.Point(35, 279);
            this.cboxToast.Name = "cboxToast";
            this.cboxToast.Size = new System.Drawing.Size(53, 19);
            this.cboxToast.TabIndex = 6;
            this.cboxToast.Text = "Toast";
            this.cboxToast.UseVisualStyleBackColor = true;
            this.cboxToast.CheckedChanged += new System.EventHandler(this.cboxToast_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantità";
            // 
            // tboxQHamburger
            // 
            this.tboxQHamburger.Location = new System.Drawing.Point(441, 110);
            this.tboxQHamburger.Name = "tboxQHamburger";
            this.tboxQHamburger.Size = new System.Drawing.Size(100, 23);
            this.tboxQHamburger.TabIndex = 8;
            this.tboxQHamburger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQHamburger_KeyPress);
            // 
            // tboxQToast
            // 
            this.tboxQToast.Location = new System.Drawing.Point(441, 277);
            this.tboxQToast.Name = "tboxQToast";
            this.tboxQToast.Size = new System.Drawing.Size(100, 23);
            this.tboxQToast.TabIndex = 8;
            this.tboxQToast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQToast_KeyPress);
            // 
            // tboxQChickenBurger
            // 
            this.tboxQChickenBurger.Location = new System.Drawing.Point(441, 232);
            this.tboxQChickenBurger.Name = "tboxQChickenBurger";
            this.tboxQChickenBurger.Size = new System.Drawing.Size(100, 23);
            this.tboxQChickenBurger.TabIndex = 8;
            this.tboxQChickenBurger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQChickenBurger_KeyPress);
            // 
            // tboxQCheeseburger
            // 
            this.tboxQCheeseburger.Location = new System.Drawing.Point(441, 190);
            this.tboxQCheeseburger.Name = "tboxQCheeseburger";
            this.tboxQCheeseburger.Size = new System.Drawing.Size(100, 23);
            this.tboxQCheeseburger.TabIndex = 8;
            this.tboxQCheeseburger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQCheeseburger_KeyPress);
            // 
            // tboxQHotDog
            // 
            this.tboxQHotDog.Location = new System.Drawing.Point(441, 147);
            this.tboxQHotDog.Name = "tboxQHotDog";
            this.tboxQHotDog.Size = new System.Drawing.Size(100, 23);
            this.tboxQHotDog.TabIndex = 8;
            this.tboxQHotDog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxQHotDog_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(322, 364);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConfermaPanino
            // 
            this.btnConfermaPanino.Location = new System.Drawing.Point(419, 364);
            this.btnConfermaPanino.Name = "btnConfermaPanino";
            this.btnConfermaPanino.Size = new System.Drawing.Size(75, 23);
            this.btnConfermaPanino.TabIndex = 10;
            this.btnConfermaPanino.Text = "Conferma";
            this.btnConfermaPanino.UseVisualStyleBackColor = true;
            this.btnConfermaPanino.Click += new System.EventHandler(this.btnConfermaPanino_Click);
            // 
            // FormPanino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(635, 500);
            this.Controls.Add(this.btnConfermaPanino);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tboxQHotDog);
            this.Controls.Add(this.tboxQCheeseburger);
            this.Controls.Add(this.tboxQChickenBurger);
            this.Controls.Add(this.tboxQToast);
            this.Controls.Add(this.tboxQHamburger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxToast);
            this.Controls.Add(this.cboxChickenBurger);
            this.Controls.Add(this.cboxCheeseburger);
            this.Controls.Add(this.cboxHotDog);
            this.Controls.Add(this.cboxHamburger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenuPanino);
            this.Name = "FormPanino";
            this.Text = "Scegli Panino";
            this.Load += new System.EventHandler(this.FormPanino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuPanino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cboxHamburger;
        private System.Windows.Forms.CheckBox cboxHotDog;
        private System.Windows.Forms.CheckBox cboxCheeseburger;
        private System.Windows.Forms.CheckBox cboxChickenBurger;
        private System.Windows.Forms.CheckBox cboxToast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxQHamburger;
        private System.Windows.Forms.TextBox tboxQToast;
        private System.Windows.Forms.TextBox tboxQChickenBurger;
        private System.Windows.Forms.TextBox tboxQCheeseburger;
        private System.Windows.Forms.TextBox tboxQHotDog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConfermaPanino;
    }
}