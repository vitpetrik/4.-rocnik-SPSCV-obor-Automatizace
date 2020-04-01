namespace winFormUI
{
    partial class signalLight
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
            this.drawBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawBox
            // 
            this.drawBox.Location = new System.Drawing.Point(0, 0);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(20, 20);
            this.drawBox.TabIndex = 0;
            this.drawBox.TabStop = false;
            this.drawBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawBox_Paint);
            // 
            // signalLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.drawBox);
            this.Name = "signalLight";
            this.Size = new System.Drawing.Size(20, 20);
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawBox;
    }
}
