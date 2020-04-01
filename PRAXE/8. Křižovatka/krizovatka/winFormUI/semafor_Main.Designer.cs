namespace winFormUI
{
    partial class semafor_Main
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
            this.yellow = new winFormUI.signalLight();
            this.red = new winFormUI.signalLight();
            this.SuspendLayout();
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Transparent;
            this.green.Location = new System.Drawing.Point(7, 55);
            this.green.Name = "green";
            this.green.SignalColor = "green";
            this.green.Size = new System.Drawing.Size(20, 20);
            this.green.Status = true;
            this.green.TabIndex = 2;
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Transparent;
            this.yellow.Location = new System.Drawing.Point(7, 28);
            this.yellow.Name = "yellow";
            this.yellow.SignalColor = "yellow";
            this.yellow.Size = new System.Drawing.Size(20, 20);
            this.yellow.Status = true;
            this.yellow.TabIndex = 1;
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Transparent;
            this.red.Location = new System.Drawing.Point(7, 3);
            this.red.Name = "red";
            this.red.SignalColor = "red";
            this.red.Size = new System.Drawing.Size(20, 20);
            this.red.Status = true;
            this.red.TabIndex = 0;
            // 
            // semafor_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.green);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.red);
            this.Name = "semafor_Main";
            this.Size = new System.Drawing.Size(35, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private signalLight red;
        private signalLight yellow;
        private signalLight green;
    }
}
