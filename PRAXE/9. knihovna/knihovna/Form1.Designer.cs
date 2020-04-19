namespace knihovna
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UserGenerateID = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UserID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.UserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.UsersTable = new System.Windows.Forms.ListView();
            this.DeleteUser = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 124);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(776, 343);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.UserGenerateID);
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Controls.Add(this.UserID);
            this.tabPage1.Controls.Add(this.UserName);
            this.tabPage1.Controls.Add(this.UsersTable);
            this.tabPage1.Controls.Add(this.DeleteUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uživatelé";
            // 
            // UserGenerateID
            // 
            this.UserGenerateID.BackColor = System.Drawing.Color.Turquoise;
            this.UserGenerateID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserGenerateID.Depth = 0;
            this.UserGenerateID.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.UserGenerateID.FlatAppearance.BorderSize = 5;
            this.UserGenerateID.Location = new System.Drawing.Point(545, 129);
            this.UserGenerateID.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserGenerateID.Name = "UserGenerateID";
            this.UserGenerateID.Primary = true;
            this.UserGenerateID.Size = new System.Drawing.Size(166, 38);
            this.UserGenerateID.TabIndex = 7;
            this.UserGenerateID.Text = "Vygenerovat ID";
            this.UserGenerateID.UseVisualStyleBackColor = false;
            this.UserGenerateID.Click += new System.EventHandler(this.UserGenerateID_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BackColor = System.Drawing.Color.Turquoise;
            this.materialRaisedButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.materialRaisedButton1.FlatAppearance.BorderSize = 5;
            this.materialRaisedButton1.Location = new System.Drawing.Point(545, 207);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(166, 38);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Přidat uživatele";
            this.materialRaisedButton1.UseVisualStyleBackColor = false;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // UserID
            // 
            this.UserID.Depth = 0;
            this.UserID.Hint = "ID uživatele";
            this.UserID.Location = new System.Drawing.Point(511, 34);
            this.UserID.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserID.Name = "UserID";
            this.UserID.PasswordChar = '\0';
            this.UserID.SelectedText = "";
            this.UserID.SelectionLength = 0;
            this.UserID.SelectionStart = 0;
            this.UserID.Size = new System.Drawing.Size(227, 23);
            this.UserID.TabIndex = 5;
            this.UserID.UseSystemPasswordChar = false;
            // 
            // UserName
            // 
            this.UserName.Depth = 0;
            this.UserName.Hint = "Jméno uživatele";
            this.UserName.Location = new System.Drawing.Point(511, 81);
            this.UserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.SelectedText = "";
            this.UserName.SelectionLength = 0;
            this.UserName.SelectionStart = 0;
            this.UserName.Size = new System.Drawing.Size(227, 23);
            this.UserName.TabIndex = 4;
            this.UserName.UseSystemPasswordChar = false;
            // 
            // UsersTable
            // 
            this.UsersTable.FullRowSelect = true;
            this.UsersTable.GridLines = true;
            this.UsersTable.HideSelection = false;
            this.UsersTable.Location = new System.Drawing.Point(6, 6);
            this.UsersTable.MultiSelect = false;
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.Size = new System.Drawing.Size(472, 305);
            this.UsersTable.TabIndex = 3;
            this.UsersTable.UseCompatibleStateImageBehavior = false;
            this.UsersTable.View = System.Windows.Forms.View.Details;
            // 
            // DeleteUser
            // 
            this.DeleteUser.BackColor = System.Drawing.Color.Turquoise;
            this.DeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteUser.Depth = 0;
            this.DeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.DeleteUser.FlatAppearance.BorderSize = 5;
            this.DeleteUser.Location = new System.Drawing.Point(545, 260);
            this.DeleteUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Primary = true;
            this.DeleteUser.Size = new System.Drawing.Size(166, 38);
            this.DeleteUser.TabIndex = 2;
            this.DeleteUser.Text = "Vymazat uživatele";
            this.DeleteUser.UseVisualStyleBackColor = false;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Knihy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 62);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(800, 41);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Form1";
            this.Text = "Knihovna";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteUser;
        private System.Windows.Forms.ListView UsersTable;
        private MaterialSkin.Controls.MaterialSingleLineTextField UserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField UserID;
        private MaterialSkin.Controls.MaterialRaisedButton UserGenerateID;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}

