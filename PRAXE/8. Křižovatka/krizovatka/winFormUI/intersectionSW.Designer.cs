namespace winFormUI
{
    partial class intersectionSW
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeftRoad_Arrow = new winFormUI.semafor_RightArrow();
            this.RightRoad_Arrow = new winFormUI.semafor_RightArrow();
            this.BottomRoad_CrossWalk = new winFormUI.semafor_CrossWalk_Wide();
            this.TopRoad_CrossWalk = new winFormUI.semafor_CrossWalk_Wide();
            this.LeftRoad_CrossWalk = new winFormUI.semafor_CrossWalk();
            this.RightRoad_CrossWalk = new winFormUI.semafor_CrossWalk();
            this.BottomRoad_ForwardRight = new winFormUI.semafor_Main();
            this.BottomRoad_Left = new winFormUI.semafor_Main();
            this.TopRoad_Left = new winFormUI.semafor_Main();
            this.TopRoad_ForwardRight = new winFormUI.semafor_Main();
            this.LeftRoad_Main = new winFormUI.semafor_Main();
            this.RightRoad_Main = new winFormUI.semafor_Main();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winFormUI.Properties.Resources.krizovatka_day;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 776);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LeftRoad_Arrow
            // 
            this.LeftRoad_Arrow.BackColor = System.Drawing.Color.Black;
            this.LeftRoad_Arrow.Location = new System.Drawing.Point(61, 419);
            this.LeftRoad_Arrow.Name = "LeftRoad_Arrow";
            this.LeftRoad_Arrow.Size = new System.Drawing.Size(35, 40);
            this.LeftRoad_Arrow.Status = 0;
            this.LeftRoad_Arrow.TabIndex = 12;
            // 
            // RightRoad_Arrow
            // 
            this.RightRoad_Arrow.BackColor = System.Drawing.Color.Black;
            this.RightRoad_Arrow.Location = new System.Drawing.Point(694, 281);
            this.RightRoad_Arrow.Name = "RightRoad_Arrow";
            this.RightRoad_Arrow.Size = new System.Drawing.Size(35, 40);
            this.RightRoad_Arrow.Status = 0;
            this.RightRoad_Arrow.TabIndex = 11;
            // 
            // BottomRoad_CrossWalk
            // 
            this.BottomRoad_CrossWalk.BackColor = System.Drawing.Color.Black;
            this.BottomRoad_CrossWalk.Location = new System.Drawing.Point(359, 537);
            this.BottomRoad_CrossWalk.Name = "BottomRoad_CrossWalk";
            this.BottomRoad_CrossWalk.Size = new System.Drawing.Size(57, 29);
            this.BottomRoad_CrossWalk.Status = 1;
            this.BottomRoad_CrossWalk.TabIndex = 10;
            // 
            // TopRoad_CrossWalk
            // 
            this.TopRoad_CrossWalk.BackColor = System.Drawing.Color.Black;
            this.TopRoad_CrossWalk.Location = new System.Drawing.Point(359, 208);
            this.TopRoad_CrossWalk.Name = "TopRoad_CrossWalk";
            this.TopRoad_CrossWalk.Size = new System.Drawing.Size(57, 29);
            this.TopRoad_CrossWalk.Status = 1;
            this.TopRoad_CrossWalk.TabIndex = 9;
            // 
            // LeftRoad_CrossWalk
            // 
            this.LeftRoad_CrossWalk.BackColor = System.Drawing.Color.Black;
            this.LeftRoad_CrossWalk.Location = new System.Drawing.Point(164, 368);
            this.LeftRoad_CrossWalk.Name = "LeftRoad_CrossWalk";
            this.LeftRoad_CrossWalk.Size = new System.Drawing.Size(29, 57);
            this.LeftRoad_CrossWalk.Status = 1;
            this.LeftRoad_CrossWalk.TabIndex = 8;
            // 
            // RightRoad_CrossWalk
            // 
            this.RightRoad_CrossWalk.BackColor = System.Drawing.Color.Black;
            this.RightRoad_CrossWalk.Location = new System.Drawing.Point(582, 368);
            this.RightRoad_CrossWalk.Name = "RightRoad_CrossWalk";
            this.RightRoad_CrossWalk.Size = new System.Drawing.Size(29, 57);
            this.RightRoad_CrossWalk.Status = 1;
            this.RightRoad_CrossWalk.TabIndex = 7;
            // 
            // BottomRoad_ForwardRight
            // 
            this.BottomRoad_ForwardRight.BackColor = System.Drawing.Color.Black;
            this.BottomRoad_ForwardRight.Location = new System.Drawing.Point(491, 605);
            this.BottomRoad_ForwardRight.Name = "BottomRoad_ForwardRight";
            this.BottomRoad_ForwardRight.Size = new System.Drawing.Size(35, 80);
            this.BottomRoad_ForwardRight.Status = 1;
            this.BottomRoad_ForwardRight.TabIndex = 6;
            // 
            // BottomRoad_Left
            // 
            this.BottomRoad_Left.BackColor = System.Drawing.Color.Black;
            this.BottomRoad_Left.Location = new System.Drawing.Point(371, 605);
            this.BottomRoad_Left.Name = "BottomRoad_Left";
            this.BottomRoad_Left.Size = new System.Drawing.Size(35, 80);
            this.BottomRoad_Left.Status = 1;
            this.BottomRoad_Left.TabIndex = 5;
            // 
            // TopRoad_Left
            // 
            this.TopRoad_Left.BackColor = System.Drawing.Color.Black;
            this.TopRoad_Left.Location = new System.Drawing.Point(370, 89);
            this.TopRoad_Left.Name = "TopRoad_Left";
            this.TopRoad_Left.Size = new System.Drawing.Size(35, 80);
            this.TopRoad_Left.Status = 1;
            this.TopRoad_Left.TabIndex = 4;
            // 
            // TopRoad_ForwardRight
            // 
            this.TopRoad_ForwardRight.BackColor = System.Drawing.Color.Black;
            this.TopRoad_ForwardRight.Location = new System.Drawing.Point(255, 89);
            this.TopRoad_ForwardRight.Name = "TopRoad_ForwardRight";
            this.TopRoad_ForwardRight.Size = new System.Drawing.Size(35, 80);
            this.TopRoad_ForwardRight.Status = 1;
            this.TopRoad_ForwardRight.TabIndex = 3;
            // 
            // LeftRoad_Main
            // 
            this.LeftRoad_Main.BackColor = System.Drawing.Color.Black;
            this.LeftRoad_Main.Location = new System.Drawing.Point(22, 419);
            this.LeftRoad_Main.Name = "LeftRoad_Main";
            this.LeftRoad_Main.Size = new System.Drawing.Size(35, 80);
            this.LeftRoad_Main.Status = 1;
            this.LeftRoad_Main.TabIndex = 2;
            // 
            // RightRoad_Main
            // 
            this.RightRoad_Main.BackColor = System.Drawing.Color.Black;
            this.RightRoad_Main.Location = new System.Drawing.Point(655, 281);
            this.RightRoad_Main.Name = "RightRoad_Main";
            this.RightRoad_Main.Size = new System.Drawing.Size(35, 80);
            this.RightRoad_Main.Status = 1;
            this.RightRoad_Main.TabIndex = 1;
            // 
            // krizovatka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LeftRoad_Arrow);
            this.Controls.Add(this.RightRoad_Arrow);
            this.Controls.Add(this.BottomRoad_CrossWalk);
            this.Controls.Add(this.TopRoad_CrossWalk);
            this.Controls.Add(this.LeftRoad_CrossWalk);
            this.Controls.Add(this.RightRoad_CrossWalk);
            this.Controls.Add(this.BottomRoad_ForwardRight);
            this.Controls.Add(this.BottomRoad_Left);
            this.Controls.Add(this.TopRoad_Left);
            this.Controls.Add(this.TopRoad_ForwardRight);
            this.Controls.Add(this.LeftRoad_Main);
            this.Controls.Add(this.RightRoad_Main);
            this.Controls.Add(this.pictureBox1);
            this.Name = "krizovatka";
            this.Size = new System.Drawing.Size(776, 776);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private semafor_Main RightRoad_Main;
        private semafor_Main LeftRoad_Main;
        private semafor_Main TopRoad_ForwardRight;
        private semafor_Main TopRoad_Left;
        private semafor_Main BottomRoad_Left;
        private semafor_Main BottomRoad_ForwardRight;
        private semafor_CrossWalk RightRoad_CrossWalk;
        private semafor_CrossWalk LeftRoad_CrossWalk;
        private semafor_CrossWalk_Wide TopRoad_CrossWalk;
        private semafor_CrossWalk_Wide BottomRoad_CrossWalk;
        private semafor_RightArrow RightRoad_Arrow;
        private semafor_RightArrow LeftRoad_Arrow;
    }
}
