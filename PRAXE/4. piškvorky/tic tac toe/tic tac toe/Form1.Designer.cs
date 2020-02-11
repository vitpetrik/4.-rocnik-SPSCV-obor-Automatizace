namespace tic_tac_toe
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
            this.play_ground = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gravity = new System.Windows.Forms.CheckBox();
            this.count = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.play_ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count)).BeginInit();
            this.SuspendLayout();
            // 
            // play_ground
            // 
            this.play_ground.BackColor = System.Drawing.Color.White;
            this.play_ground.Location = new System.Drawing.Point(32, 37);
            this.play_ground.Name = "play_ground";
            this.play_ground.Size = new System.Drawing.Size(520, 380);
            this.play_ground.TabIndex = 0;
            this.play_ground.TabStop = false;
            this.play_ground.Paint += new System.Windows.Forms.PaintEventHandler(this.Play_ground_Paint);
            this.play_ground.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Play_ground_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "reset game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.resetGrid);
            // 
            // gravity
            // 
            this.gravity.AutoSize = true;
            this.gravity.Location = new System.Drawing.Point(701, 381);
            this.gravity.Name = "gravity";
            this.gravity.Size = new System.Drawing.Size(59, 17);
            this.gravity.TabIndex = 2;
            this.gravity.Text = "Gravity";
            this.gravity.UseVisualStyleBackColor = true;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(596, 334);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(120, 20);
            this.count.TabIndex = 3;
            this.count.Tag = "Na kolik hrajeme";
            this.count.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Na kolik hrajeme";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(621, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "O : X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score_text
            // 
            this.score_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_text.Location = new System.Drawing.Point(622, 82);
            this.score_text.Name = "score_text";
            this.score_text.Size = new System.Drawing.Size(120, 35);
            this.score_text.TabIndex = 6;
            this.score_text.Text = "0 : 0";
            this.score_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count);
            this.Controls.Add(this.gravity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.play_ground);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.play_ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox play_ground;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox gravity;
        private System.Windows.Forms.NumericUpDown count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score_text;
    }
}

