namespace winFormUI
{
    partial class semafor_CrossWalk
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

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.red = new winFormUI.signalLight();
            this.green = new winFormUI.signalLight();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Transparent;
            this.red.Location = new System.Drawing.Point(5, 5);
            this.red.Name = "red";
            this.red.SignalColor = "red";
            this.red.Size = new System.Drawing.Size(20, 20);
            this.red.Status = true;
            this.red.TabIndex = 0;
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Transparent;
            this.green.Location = new System.Drawing.Point(4, 32);
            this.green.Name = "green";
            this.green.SignalColor = "green";
            this.green.Size = new System.Drawing.Size(20, 20);
            this.green.Status = true;
            this.green.TabIndex = 1;
            // 
            // semafor_CrossWalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Name = "semafor_CrossWalk";
            this.Size = new System.Drawing.Size(29, 57);
            this.ResumeLayout(false);

        }

        #endregion

        private signalLight red;
        private signalLight green;
    }
}
