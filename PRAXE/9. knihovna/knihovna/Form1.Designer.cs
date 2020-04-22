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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.UserIDSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.UserSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UserGenerateID = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UserAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UserID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.UserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.UserTable = new System.Windows.Forms.ListView();
            this.UserDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.BookIDSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BookSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BookGenerateID = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BookAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BookID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BookISBN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BookDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BookTable = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrintBorrowed = new MaterialSkin.Controls.MaterialRadioButton();
            this.TransactionPrint = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PrintByBook = new MaterialSkin.Controls.MaterialRadioButton();
            this.PrintByUser = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TransactionEnd = new System.Windows.Forms.DateTimePicker();
            this.TransactionBorrow = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TransactionReturn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TransactionUserID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TransactionBookID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TransactionTable = new System.Windows.Forms.ListView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 124);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(776, 387);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialDivider1);
            this.tabPage1.Controls.Add(this.UserIDSearch);
            this.tabPage1.Controls.Add(this.UserSearch);
            this.tabPage1.Controls.Add(this.UserGenerateID);
            this.tabPage1.Controls.Add(this.UserAdd);
            this.tabPage1.Controls.Add(this.UserID);
            this.tabPage1.Controls.Add(this.UserName);
            this.tabPage1.Controls.Add(this.UserTable);
            this.tabPage1.Controls.Add(this.UserDelete);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uživatelé";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(439, 200);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(308, 2);
            this.materialDivider1.TabIndex = 10;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // UserIDSearch
            // 
            this.UserIDSearch.Depth = 0;
            this.UserIDSearch.Hint = "ID uživatele";
            this.UserIDSearch.Location = new System.Drawing.Point(448, 251);
            this.UserIDSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserIDSearch.Name = "UserIDSearch";
            this.UserIDSearch.PasswordChar = '\0';
            this.UserIDSearch.SelectedText = "";
            this.UserIDSearch.SelectionLength = 0;
            this.UserIDSearch.SelectionStart = 0;
            this.UserIDSearch.Size = new System.Drawing.Size(210, 23);
            this.UserIDSearch.TabIndex = 9;
            this.UserIDSearch.UseSystemPasswordChar = false;
            // 
            // UserSearch
            // 
            this.UserSearch.BackColor = System.Drawing.Color.Turquoise;
            this.UserSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserSearch.Depth = 0;
            this.UserSearch.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.UserSearch.FlatAppearance.BorderSize = 5;
            this.UserSearch.Location = new System.Drawing.Point(664, 236);
            this.UserSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserSearch.Name = "UserSearch";
            this.UserSearch.Primary = true;
            this.UserSearch.Size = new System.Drawing.Size(74, 38);
            this.UserSearch.TabIndex = 8;
            this.UserSearch.Text = "Hledat";
            this.UserSearch.UseVisualStyleBackColor = false;
            this.UserSearch.Click += new System.EventHandler(this.UserSearch_Click);
            // 
            // UserGenerateID
            // 
            this.UserGenerateID.BackColor = System.Drawing.Color.Turquoise;
            this.UserGenerateID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserGenerateID.Depth = 0;
            this.UserGenerateID.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.UserGenerateID.FlatAppearance.BorderSize = 5;
            this.UserGenerateID.Location = new System.Drawing.Point(448, 127);
            this.UserGenerateID.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserGenerateID.Name = "UserGenerateID";
            this.UserGenerateID.Primary = true;
            this.UserGenerateID.Size = new System.Drawing.Size(139, 38);
            this.UserGenerateID.TabIndex = 7;
            this.UserGenerateID.Text = "Vygenerovat ID";
            this.UserGenerateID.UseVisualStyleBackColor = false;
            this.UserGenerateID.Click += new System.EventHandler(this.UserGenerateID_Click);
            // 
            // UserAdd
            // 
            this.UserAdd.BackColor = System.Drawing.Color.Turquoise;
            this.UserAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserAdd.Depth = 0;
            this.UserAdd.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.UserAdd.FlatAppearance.BorderSize = 5;
            this.UserAdd.Location = new System.Drawing.Point(605, 127);
            this.UserAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserAdd.Name = "UserAdd";
            this.UserAdd.Primary = true;
            this.UserAdd.Size = new System.Drawing.Size(133, 38);
            this.UserAdd.TabIndex = 6;
            this.UserAdd.Text = "Přidat uživatele";
            this.UserAdd.UseVisualStyleBackColor = false;
            this.UserAdd.Click += new System.EventHandler(this.UserAdd_Click);
            // 
            // UserID
            // 
            this.UserID.Depth = 0;
            this.UserID.Hint = "ID uživatele";
            this.UserID.Location = new System.Drawing.Point(448, 24);
            this.UserID.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserID.Name = "UserID";
            this.UserID.PasswordChar = '\0';
            this.UserID.SelectedText = "";
            this.UserID.SelectionLength = 0;
            this.UserID.SelectionStart = 0;
            this.UserID.Size = new System.Drawing.Size(290, 23);
            this.UserID.TabIndex = 5;
            this.UserID.UseSystemPasswordChar = false;
            // 
            // UserName
            // 
            this.UserName.Depth = 0;
            this.UserName.Hint = "Jméno uživatele";
            this.UserName.Location = new System.Drawing.Point(448, 72);
            this.UserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.SelectedText = "";
            this.UserName.SelectionLength = 0;
            this.UserName.SelectionStart = 0;
            this.UserName.Size = new System.Drawing.Size(290, 23);
            this.UserName.TabIndex = 4;
            this.UserName.UseSystemPasswordChar = false;
            // 
            // UserTable
            // 
            this.UserTable.FullRowSelect = true;
            this.UserTable.GridLines = true;
            this.UserTable.HideSelection = false;
            this.UserTable.Location = new System.Drawing.Point(6, 6);
            this.UserTable.MultiSelect = false;
            this.UserTable.Name = "UserTable";
            this.UserTable.Size = new System.Drawing.Size(404, 352);
            this.UserTable.TabIndex = 3;
            this.UserTable.UseCompatibleStateImageBehavior = false;
            this.UserTable.View = System.Windows.Forms.View.Details;
            // 
            // UserDelete
            // 
            this.UserDelete.BackColor = System.Drawing.Color.Turquoise;
            this.UserDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserDelete.Depth = 0;
            this.UserDelete.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.UserDelete.FlatAppearance.BorderSize = 5;
            this.UserDelete.Location = new System.Drawing.Point(572, 298);
            this.UserDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserDelete.Name = "UserDelete";
            this.UserDelete.Primary = true;
            this.UserDelete.Size = new System.Drawing.Size(166, 38);
            this.UserDelete.TabIndex = 2;
            this.UserDelete.Text = "Vymazat uživatele";
            this.UserDelete.UseVisualStyleBackColor = false;
            this.UserDelete.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialDivider2);
            this.tabPage2.Controls.Add(this.BookIDSearch);
            this.tabPage2.Controls.Add(this.BookSearch);
            this.tabPage2.Controls.Add(this.BookGenerateID);
            this.tabPage2.Controls.Add(this.BookAdd);
            this.tabPage2.Controls.Add(this.BookID);
            this.tabPage2.Controls.Add(this.BookISBN);
            this.tabPage2.Controls.Add(this.BookDelete);
            this.tabPage2.Controls.Add(this.BookTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Knihy";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(439, 200);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(308, 2);
            this.materialDivider2.TabIndex = 18;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // BookIDSearch
            // 
            this.BookIDSearch.Depth = 0;
            this.BookIDSearch.Hint = "ID knihy";
            this.BookIDSearch.Location = new System.Drawing.Point(448, 251);
            this.BookIDSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.BookIDSearch.Name = "BookIDSearch";
            this.BookIDSearch.PasswordChar = '\0';
            this.BookIDSearch.SelectedText = "";
            this.BookIDSearch.SelectionLength = 0;
            this.BookIDSearch.SelectionStart = 0;
            this.BookIDSearch.Size = new System.Drawing.Size(210, 23);
            this.BookIDSearch.TabIndex = 17;
            this.BookIDSearch.UseSystemPasswordChar = false;
            // 
            // BookSearch
            // 
            this.BookSearch.BackColor = System.Drawing.Color.Turquoise;
            this.BookSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BookSearch.Depth = 0;
            this.BookSearch.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BookSearch.FlatAppearance.BorderSize = 5;
            this.BookSearch.Location = new System.Drawing.Point(664, 236);
            this.BookSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.BookSearch.Name = "BookSearch";
            this.BookSearch.Primary = true;
            this.BookSearch.Size = new System.Drawing.Size(74, 38);
            this.BookSearch.TabIndex = 16;
            this.BookSearch.Text = "Hledat";
            this.BookSearch.UseVisualStyleBackColor = false;
            this.BookSearch.Click += new System.EventHandler(this.BookSearch_Click);
            // 
            // BookGenerateID
            // 
            this.BookGenerateID.BackColor = System.Drawing.Color.Turquoise;
            this.BookGenerateID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BookGenerateID.Depth = 0;
            this.BookGenerateID.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BookGenerateID.FlatAppearance.BorderSize = 5;
            this.BookGenerateID.Location = new System.Drawing.Point(448, 127);
            this.BookGenerateID.MouseState = MaterialSkin.MouseState.HOVER;
            this.BookGenerateID.Name = "BookGenerateID";
            this.BookGenerateID.Primary = true;
            this.BookGenerateID.Size = new System.Drawing.Size(139, 38);
            this.BookGenerateID.TabIndex = 15;
            this.BookGenerateID.Text = "Vygenerovat ID";
            this.BookGenerateID.UseVisualStyleBackColor = false;
            this.BookGenerateID.Click += new System.EventHandler(this.BookGenerateID_Click);
            // 
            // BookAdd
            // 
            this.BookAdd.BackColor = System.Drawing.Color.Turquoise;
            this.BookAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BookAdd.Depth = 0;
            this.BookAdd.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BookAdd.FlatAppearance.BorderSize = 5;
            this.BookAdd.Location = new System.Drawing.Point(618, 127);
            this.BookAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BookAdd.Name = "BookAdd";
            this.BookAdd.Primary = true;
            this.BookAdd.Size = new System.Drawing.Size(120, 38);
            this.BookAdd.TabIndex = 14;
            this.BookAdd.Text = "Přidat knihu";
            this.BookAdd.UseVisualStyleBackColor = false;
            this.BookAdd.Click += new System.EventHandler(this.BookAdd_Click);
            // 
            // BookID
            // 
            this.BookID.Depth = 0;
            this.BookID.Hint = "ID knihy";
            this.BookID.Location = new System.Drawing.Point(448, 24);
            this.BookID.MouseState = MaterialSkin.MouseState.HOVER;
            this.BookID.Name = "BookID";
            this.BookID.PasswordChar = '\0';
            this.BookID.SelectedText = "";
            this.BookID.SelectionLength = 0;
            this.BookID.SelectionStart = 0;
            this.BookID.Size = new System.Drawing.Size(290, 23);
            this.BookID.TabIndex = 13;
            this.BookID.UseSystemPasswordChar = false;
            // 
            // BookISBN
            // 
            this.BookISBN.Depth = 0;
            this.BookISBN.Hint = "ISBN knihy";
            this.BookISBN.Location = new System.Drawing.Point(448, 72);
            this.BookISBN.MouseState = MaterialSkin.MouseState.HOVER;
            this.BookISBN.Name = "BookISBN";
            this.BookISBN.PasswordChar = '\0';
            this.BookISBN.SelectedText = "";
            this.BookISBN.SelectionLength = 0;
            this.BookISBN.SelectionStart = 0;
            this.BookISBN.Size = new System.Drawing.Size(290, 23);
            this.BookISBN.TabIndex = 12;
            this.BookISBN.UseSystemPasswordChar = false;
            // 
            // BookDelete
            // 
            this.BookDelete.BackColor = System.Drawing.Color.Turquoise;
            this.BookDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BookDelete.Depth = 0;
            this.BookDelete.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BookDelete.FlatAppearance.BorderSize = 5;
            this.BookDelete.Location = new System.Drawing.Point(572, 298);
            this.BookDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BookDelete.Name = "BookDelete";
            this.BookDelete.Primary = true;
            this.BookDelete.Size = new System.Drawing.Size(166, 38);
            this.BookDelete.TabIndex = 11;
            this.BookDelete.Text = "Vymazat knihu";
            this.BookDelete.UseVisualStyleBackColor = false;
            this.BookDelete.Click += new System.EventHandler(this.BookDelete_Click);
            // 
            // BookTable
            // 
            this.BookTable.FullRowSelect = true;
            this.BookTable.GridLines = true;
            this.BookTable.HideSelection = false;
            this.BookTable.Location = new System.Drawing.Point(6, 6);
            this.BookTable.MultiSelect = false;
            this.BookTable.Name = "BookTable";
            this.BookTable.Size = new System.Drawing.Size(404, 352);
            this.BookTable.TabIndex = 4;
            this.BookTable.UseCompatibleStateImageBehavior = false;
            this.BookTable.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.TransactionEnd);
            this.tabPage3.Controls.Add(this.TransactionBorrow);
            this.tabPage3.Controls.Add(this.TransactionReturn);
            this.tabPage3.Controls.Add(this.TransactionUserID);
            this.tabPage3.Controls.Add(this.TransactionBookID);
            this.tabPage3.Controls.Add(this.TransactionTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transakce";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrintBorrowed);
            this.groupBox1.Controls.Add(this.TransactionPrint);
            this.groupBox1.Controls.Add(this.PrintByBook);
            this.groupBox1.Controls.Add(this.PrintByUser);
            this.groupBox1.Location = new System.Drawing.Point(448, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 126);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vytisknout";
            // 
            // PrintBorrowed
            // 
            this.PrintBorrowed.AutoSize = true;
            this.PrintBorrowed.Depth = 0;
            this.PrintBorrowed.Font = new System.Drawing.Font("Roboto", 10F);
            this.PrintBorrowed.Location = new System.Drawing.Point(12, 86);
            this.PrintBorrowed.Margin = new System.Windows.Forms.Padding(0);
            this.PrintBorrowed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PrintBorrowed.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrintBorrowed.Name = "PrintBorrowed";
            this.PrintBorrowed.Ripple = true;
            this.PrintBorrowed.Size = new System.Drawing.Size(133, 30);
            this.PrintBorrowed.TabIndex = 25;
            this.PrintBorrowed.TabStop = true;
            this.PrintBorrowed.Text = "Všechny půjčené";
            this.PrintBorrowed.UseVisualStyleBackColor = true;
            // 
            // TransactionPrint
            // 
            this.TransactionPrint.Depth = 0;
            this.TransactionPrint.Location = new System.Drawing.Point(163, 82);
            this.TransactionPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.TransactionPrint.Name = "TransactionPrint";
            this.TransactionPrint.Primary = true;
            this.TransactionPrint.Size = new System.Drawing.Size(121, 38);
            this.TransactionPrint.TabIndex = 24;
            this.TransactionPrint.Text = "Vytisknout";
            this.TransactionPrint.UseVisualStyleBackColor = true;
            this.TransactionPrint.Click += new System.EventHandler(this.TransactionPrint_Click);
            // 
            // PrintByBook
            // 
            this.PrintByBook.AutoSize = true;
            this.PrintByBook.Depth = 0;
            this.PrintByBook.Font = new System.Drawing.Font("Roboto", 10F);
            this.PrintByBook.Location = new System.Drawing.Point(12, 51);
            this.PrintByBook.Margin = new System.Windows.Forms.Padding(0);
            this.PrintByBook.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PrintByBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrintByBook.Name = "PrintByBook";
            this.PrintByBook.Ripple = true;
            this.PrintByBook.Size = new System.Drawing.Size(100, 30);
            this.PrintByBook.TabIndex = 23;
            this.PrintByBook.TabStop = true;
            this.PrintByBook.Text = "Podle knihy";
            this.PrintByBook.UseVisualStyleBackColor = true;
            // 
            // PrintByUser
            // 
            this.PrintByUser.AutoSize = true;
            this.PrintByUser.Depth = 0;
            this.PrintByUser.Font = new System.Drawing.Font("Roboto", 10F);
            this.PrintByUser.Location = new System.Drawing.Point(12, 16);
            this.PrintByUser.Margin = new System.Windows.Forms.Padding(0);
            this.PrintByUser.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PrintByUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrintByUser.Name = "PrintByUser";
            this.PrintByUser.Ripple = true;
            this.PrintByUser.Size = new System.Drawing.Size(123, 30);
            this.PrintByUser.TabIndex = 22;
            this.PrintByUser.TabStop = true;
            this.PrintByUser.Text = "Podle uživatele";
            this.PrintByUser.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(444, 105);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(179, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Datum ukončení výpůjčky";
            // 
            // TransactionEnd
            // 
            this.TransactionEnd.Location = new System.Drawing.Point(448, 129);
            this.TransactionEnd.Name = "TransactionEnd";
            this.TransactionEnd.Size = new System.Drawing.Size(290, 20);
            this.TransactionEnd.TabIndex = 18;
            // 
            // TransactionBorrow
            // 
            this.TransactionBorrow.BackColor = System.Drawing.Color.Turquoise;
            this.TransactionBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TransactionBorrow.Depth = 0;
            this.TransactionBorrow.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.TransactionBorrow.FlatAppearance.BorderSize = 5;
            this.TransactionBorrow.Location = new System.Drawing.Point(617, 166);
            this.TransactionBorrow.MouseState = MaterialSkin.MouseState.HOVER;
            this.TransactionBorrow.Name = "TransactionBorrow";
            this.TransactionBorrow.Primary = true;
            this.TransactionBorrow.Size = new System.Drawing.Size(121, 38);
            this.TransactionBorrow.TabIndex = 17;
            this.TransactionBorrow.Text = "Půjčit knihu";
            this.TransactionBorrow.UseVisualStyleBackColor = false;
            this.TransactionBorrow.Click += new System.EventHandler(this.TransactionBorrow_Click);
            // 
            // TransactionReturn
            // 
            this.TransactionReturn.BackColor = System.Drawing.Color.Turquoise;
            this.TransactionReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TransactionReturn.Depth = 0;
            this.TransactionReturn.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.TransactionReturn.FlatAppearance.BorderSize = 5;
            this.TransactionReturn.Location = new System.Drawing.Point(448, 166);
            this.TransactionReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TransactionReturn.Name = "TransactionReturn";
            this.TransactionReturn.Primary = true;
            this.TransactionReturn.Size = new System.Drawing.Size(132, 38);
            this.TransactionReturn.TabIndex = 16;
            this.TransactionReturn.Text = "Vrátit knihu";
            this.TransactionReturn.UseVisualStyleBackColor = false;
            this.TransactionReturn.Click += new System.EventHandler(this.TransactionReturn_Click);
            // 
            // TransactionUserID
            // 
            this.TransactionUserID.Depth = 0;
            this.TransactionUserID.Hint = "ID uživatele";
            this.TransactionUserID.Location = new System.Drawing.Point(448, 11);
            this.TransactionUserID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TransactionUserID.Name = "TransactionUserID";
            this.TransactionUserID.PasswordChar = '\0';
            this.TransactionUserID.SelectedText = "";
            this.TransactionUserID.SelectionLength = 0;
            this.TransactionUserID.SelectionStart = 0;
            this.TransactionUserID.Size = new System.Drawing.Size(290, 23);
            this.TransactionUserID.TabIndex = 15;
            this.TransactionUserID.UseSystemPasswordChar = false;
            this.TransactionUserID.TextChanged += new System.EventHandler(this.TransactionFocus);
            // 
            // TransactionBookID
            // 
            this.TransactionBookID.Depth = 0;
            this.TransactionBookID.Hint = "ID knihy";
            this.TransactionBookID.Location = new System.Drawing.Point(448, 59);
            this.TransactionBookID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TransactionBookID.Name = "TransactionBookID";
            this.TransactionBookID.PasswordChar = '\0';
            this.TransactionBookID.SelectedText = "";
            this.TransactionBookID.SelectionLength = 0;
            this.TransactionBookID.SelectionStart = 0;
            this.TransactionBookID.Size = new System.Drawing.Size(290, 23);
            this.TransactionBookID.TabIndex = 14;
            this.TransactionBookID.UseSystemPasswordChar = false;
            this.TransactionBookID.TextChanged += new System.EventHandler(this.TransactionFocus);
            // 
            // TransactionTable
            // 
            this.TransactionTable.FullRowSelect = true;
            this.TransactionTable.GridLines = true;
            this.TransactionTable.HideSelection = false;
            this.TransactionTable.Location = new System.Drawing.Point(6, 6);
            this.TransactionTable.MultiSelect = false;
            this.TransactionTable.Name = "TransactionTable";
            this.TransactionTable.Size = new System.Drawing.Size(404, 352);
            this.TransactionTable.TabIndex = 5;
            this.TransactionTable.UseCompatibleStateImageBehavior = false;
            this.TransactionTable.View = System.Windows.Forms.View.Details;
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
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Knihovna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton UserDelete;
        private System.Windows.Forms.ListView UserTable;
        private MaterialSkin.Controls.MaterialSingleLineTextField UserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField UserID;
        private MaterialSkin.Controls.MaterialRaisedButton UserGenerateID;
        private MaterialSkin.Controls.MaterialRaisedButton UserAdd;
        private MaterialSkin.Controls.MaterialRaisedButton UserSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField UserIDSearch;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ListView BookTable;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialSingleLineTextField BookIDSearch;
        private MaterialSkin.Controls.MaterialRaisedButton BookSearch;
        private MaterialSkin.Controls.MaterialRaisedButton BookGenerateID;
        private MaterialSkin.Controls.MaterialRaisedButton BookAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField BookID;
        private MaterialSkin.Controls.MaterialSingleLineTextField BookISBN;
        private MaterialSkin.Controls.MaterialRaisedButton BookDelete;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView TransactionTable;
        private MaterialSkin.Controls.MaterialSingleLineTextField TransactionBookID;
        private MaterialSkin.Controls.MaterialSingleLineTextField TransactionUserID;
        private MaterialSkin.Controls.MaterialRaisedButton TransactionReturn;
        private MaterialSkin.Controls.MaterialRaisedButton TransactionBorrow;
        private System.Windows.Forms.DateTimePicker TransactionEnd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton PrintByBook;
        private MaterialSkin.Controls.MaterialRadioButton PrintByUser;
        private MaterialSkin.Controls.MaterialRaisedButton TransactionPrint;
        private MaterialSkin.Controls.MaterialRadioButton PrintBorrowed;
    }
}

