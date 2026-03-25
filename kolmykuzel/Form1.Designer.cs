namespace kolmykuzel
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPocitej = new System.Windows.Forms.Button();
            this.textBoxJ = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownPol1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPol2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVys = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVys)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPocitej
            // 
            this.buttonPocitej.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPocitej.Location = new System.Drawing.Point(761, 12);
            this.buttonPocitej.Name = "buttonPocitej";
            this.buttonPocitej.Size = new System.Drawing.Size(27, 220);
            this.buttonPocitej.TabIndex = 0;
            this.buttonPocitej.Text = "pocitej!";
            this.buttonPocitej.UseVisualStyleBackColor = true;
            this.buttonPocitej.Click += new System.EventHandler(this.buttonPocitej_Click);
            // 
            // textBoxJ
            // 
            this.textBoxJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxJ.Location = new System.Drawing.Point(118, 206);
            this.textBoxJ.Name = "textBoxJ";
            this.textBoxJ.Size = new System.Drawing.Size(100, 30);
            this.textBoxJ.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(12, 242);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(776, 196);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "jednotka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Poloměr 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Poloměr 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Výška";
            // 
            // numericUpDownPol1
            // 
            this.numericUpDownPol1.DecimalPlaces = 2;
            this.numericUpDownPol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownPol1.Location = new System.Drawing.Point(118, 10);
            this.numericUpDownPol1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownPol1.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownPol1.Name = "numericUpDownPol1";
            this.numericUpDownPol1.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownPol1.TabIndex = 10;
            // 
            // numericUpDownPol2
            // 
            this.numericUpDownPol2.DecimalPlaces = 2;
            this.numericUpDownPol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownPol2.Location = new System.Drawing.Point(118, 44);
            this.numericUpDownPol2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownPol2.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownPol2.Name = "numericUpDownPol2";
            this.numericUpDownPol2.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownPol2.TabIndex = 11;
            // 
            // numericUpDownVys
            // 
            this.numericUpDownVys.DecimalPlaces = 2;
            this.numericUpDownVys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownVys.Location = new System.Drawing.Point(118, 80);
            this.numericUpDownVys.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownVys.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownVys.Name = "numericUpDownVys";
            this.numericUpDownVys.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownVys.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownVys);
            this.Controls.Add(this.numericUpDownPol2);
            this.Controls.Add(this.numericUpDownPol1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxJ);
            this.Controls.Add(this.buttonPocitej);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPocitej;
        private System.Windows.Forms.TextBox textBoxJ;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPol1;
        private System.Windows.Forms.NumericUpDown numericUpDownPol2;
        private System.Windows.Forms.NumericUpDown numericUpDownVys;
    }
}

