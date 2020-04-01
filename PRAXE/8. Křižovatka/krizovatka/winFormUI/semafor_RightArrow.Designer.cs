namespace winFormUI
{
    partial class semafor_RightArrow
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
            this.green = new winFormUI.signalLight();
            this.SuspendLayout();
            // 
            // green
            // 
            this.green.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.green.BackColor = System.Drawing.Color.Transparent;
            this.green.Enabled = false;
            this.green.Location = new System.Drawing.Point(7, 9);
            this.green.Name = "green";
            this.green.SignalColor = "green";
            this.green.Size = new System.Drawing.Size(20, 20);
            this.green.Status = true;
            this.green.TabIndex = 0;
            // 
            // semafor_RightArrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.green);
            this.Name = "semafor_RightArrow";
            this.Size = new System.Drawing.Size(35, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private signalLight green;
    }
}
