namespace winFormUI
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
            this.components = new System.ComponentModel.Container();
            this.nextConfigurationTimer = new System.Windows.Forms.Timer(this.components);
            this.rezimListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.intersectionSW = new winFormUI.intersectionSW();
            this.buttonCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // nextConfigurationTimer
            // 
            this.nextConfigurationTimer.Tick += new System.EventHandler(this.nextConfigurationTimer_Tick);
            // 
            // rezimListBox
            // 
            this.rezimListBox.FormattingEnabled = true;
            this.rezimListBox.Location = new System.Drawing.Point(36, 179);
            this.rezimListBox.Name = "rezimListBox";
            this.rezimListBox.Size = new System.Drawing.Size(169, 56);
            this.rezimListBox.TabIndex = 1;
            this.rezimListBox.SelectedIndexChanged += new System.EventHandler(this.rezimListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vyberte režim křizovatky";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Křižovatka";
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(51, 260);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(132, 52);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // intersectionSW
            // 
            this.intersectionSW.AutoSize = true;
            this.intersectionSW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.intersectionSW.Configuration = null;
            this.intersectionSW.Location = new System.Drawing.Point(298, 12);
            this.intersectionSW.Name = "intersectionSW";
            this.intersectionSW.Size = new System.Drawing.Size(779, 779);
            this.intersectionSW.TabIndex = 0;
            // 
            // buttonCheckTimer
            // 
            this.buttonCheckTimer.Tick += new System.EventHandler(this.buttonCheckTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 801);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rezimListBox);
            this.Controls.Add(this.intersectionSW);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private intersectionSW intersectionSW;
        private System.Windows.Forms.Timer nextConfigurationTimer;
        private System.Windows.Forms.ListBox rezimListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer buttonCheckTimer;
    }
}

