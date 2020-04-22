using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using FileHelpers;
using System.IO;

namespace knihovna
{
    public partial class Form1 : MaterialForm
    {
        private List<User> Users;
        private List<Book> Books;
        private List<Transaction> Transactions;


        [DelimitedRecord(";")]
        public class User
        {
            public int ID;
            public string Name;
        }

        [DelimitedRecord(";")]
        public class Book
        {
            public int ID;
            public long ISBN;
        }

        [DelimitedRecord(";")]
        public class Transaction
        {
            public int UserID;
            public int BookID;

            public bool Returned;

            [FieldConverter(ConverterKind.Date, "dd-MM-yyyy")]
            public DateTime CreatedAt;
            [FieldConverter(ConverterKind.Date, "dd-MM-yyyy")]
            public DateTime End;
        }

        public class ListItemColor
        {
            public Color BackColor;
            public Color ForeColor;
        }

        public Form1()
        {
            InitializeComponent();

            UserTable.Columns.Add("ID", 150);
            UserTable.Columns.Add("Jméno", 150);
            UserTable.Columns.Add("Vypůjčených knih", 100);

            BookTable.Columns.Add("ID", 150);
            BookTable.Columns.Add("ISBN", 150);
            BookTable.Columns.Add("K dispozici", 100);

            TransactionTable.Columns.Add("Uživatel", 100);
            TransactionTable.Columns.Add("Kniha", 100);
            TransactionTable.Columns.Add("Vráceno", 67);
            TransactionTable.Columns.Add("Od", 66);
            TransactionTable.Columns.Add("Do", 66);

            ReadFiles();

            PopulateUserTable();
            PopulateBookTable();
            PopulateTransactionTable();
        }

        //Přečte CSV soubory a zapíše jejich obsah do proměnných
        private void ReadFiles()
        {
            Users = new FileHelperEngine<User>().ReadFile("data/users.csv").ToList();
            Books = new FileHelperEngine<Book>().ReadFile("data/books.csv").ToList();
            Transactions = new FileHelperEngine<Transaction>().ReadFile("data/transactions.csv").ToList();
        }

        //Zapíše obsah proměnných do CSV souborů
        private void WriteFiles()
        {
            new FileHelperEngine<User>().WriteFile("data/users.csv", Users);
            new FileHelperEngine<Book>().WriteFile("data/books.csv", Books);
            new FileHelperEngine<Transaction>().WriteFile("data/transactions.csv", Transactions);
        }

        //zapsání do souborů proběhna při zavření okna programu
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            WriteFiles();
        }

        //Vyplní tabulku uživatelů
        private void PopulateUserTable()
        {
            UserTable.Items.Clear();
            foreach (var record in Users)
            {
                int count = Transactions.Where(x => x.UserID == record.ID && !x.Returned).Count();
                UserTable.Items.Add(new ListViewItem(new string[3] { record.ID.ToString(), record.Name, count.ToString() }));
            }
        }

        //Vyplní tabulku knih
        private void PopulateBookTable()
        {
            BookTable.Items.Clear();
            foreach (var record in Books)
            {
                bool returned = !(Transactions.Where(x => x.BookID == record.ID && !x.Returned).Count() > 0);
                BookTable.Items.Add(new ListViewItem(new string[3] { record.ID.ToString(), ISBNtoSring(record.ISBN), returned ? "ano" : "ne" }));
            }
        }

        //Vyplní tabulku transakcí
        private void PopulateTransactionTable()
        {
            TransactionTable.Items.Clear();
            foreach (var record in Transactions)
            {
                TransactionTable.Items.Add(new ListViewItem(new string[5] {
                    record.UserID.ToString(),
                    record.BookID.ToString(),
                    record.Returned ? "ano" : "ne",
                    record.CreatedAt.ToString().Split(' ')[0],
                    record.End.ToString().Split(' ')[0]
                }));

                //změní barvičku položky v závisloti na stavu výpůjčky
                ListItemColor color = getColorFromTransaction(record);
                TransactionTable.Items[TransactionTable.Items.Count - 1].BackColor = color.BackColor;
                TransactionTable.Items[TransactionTable.Items.Count - 1].ForeColor = color.ForeColor;
            }
        }

        //Vymaže uživatele ze záznmu
        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if (UserTable.FocusedItem != null)
            {
                var index = UserTable.FocusedItem.Index;

                var count = Transactions.Where(x => x.UserID == Users[index].ID && !x.Returned).Count();
                if (count > 0)
                {
                    MessageBox.Show("Není možné vymazat uživatele, protože má " + count.ToString() + " neodevzdaných knih");
                    return;
                }

                Users.RemoveAt(index);
                PopulateUserTable();
            }
        }

        //Vygeneruje ID uživatele
        private void UserGenerateID_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            UserID.Text = random.Next(0, 9999999).ToString();
        }

        //Přidá uživatele do záznamu
        private void UserAdd_Click(object sender, EventArgs e)
        {
            if (UserID.Text == "" || UserName.Text == "")
            {
                MessageBox.Show("Chybí parametr");
                return;
            }
            Users.Add(new User { ID = int.Parse(UserID.Text), Name = UserName.Text });
            PopulateUserTable();
        }

        //Vyhledá uživatele podle ID a zvýrazní ho v tabulce
        private void UserSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var index = Users.FindIndex(x => x.ID == long.Parse(UserIDSearch.Text));
                if (index < 0)
                {
                    MessageBox.Show("Hledané ID nebylo nalezeno");
                    return;
                }
                UserTable.Items[index].Selected = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Hledané ID nebylo zadáno správně");
            }
        }

        //Vygeneruje ID knížky
        private void BookGenerateID_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            BookID.Text = random.Next(0, 9999999).ToString();
        }

        //Přidá knihu do záznamu
        private void BookAdd_Click(object sender, EventArgs e)
        {
            if (BookID.Text == "" || BookISBN.Text == "")
            {
                MessageBox.Show("Chybí parametr");
                return;
            }

            Books.Add(new Book { ID = int.Parse(BookID.Text), ISBN = long.Parse(RemoveExcept(BookISBN.Text, false, true)) });
            PopulateBookTable();
        }

        //Vymaže knihu ze záznamu
        private void BookDelete_Click(object sender, EventArgs e)
        {
            if (BookTable.FocusedItem != null)
            {
                var index = BookTable.FocusedItem.Index;

                //Pokud kniha není vrácena, nemůžeme jí vymazat
                var returned = !(Transactions.Exists(x => x.BookID == Books[index].ID && !x.Returned));
                if (!returned)
                {
                    MessageBox.Show("Není možné vymazat neodevzdanou knihu");
                    return;
                }

                Books.RemoveAt(index);
                PopulateBookTable();
            }
        }

        //Vyhledá knihu pomocí ID a zvýrazní ji v tabulce
        private void BookSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var index = Books.FindIndex(x => x.ID == long.Parse(BookIDSearch.Text));
                if (index < 0)
                {
                    MessageBox.Show("Hledané ID nebylo nalezeno");
                    return;
                }
                Console.WriteLine(index);
                BookTable.Items[index].Selected = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Hledané ID nebylo zadáno správně");
            }
        }

        //Akce vrácení knihy
        private void TransactionReturn_Click(object sender, EventArgs e)
        {
            if (TransactionTable.FocusedItem != null)
            {
                //Vezmeme index zvýrazněné položky
                var index = TransactionTable.FocusedItem.Index;
                if (index < 0)
                {
                    MessageBox.Show("Nebyla nalezená vyhovující transakce");
                    return;
                }

                Transactions[index].Returned = true;

                PopulateUserTable();
                PopulateBookTable();
                PopulateTransactionTable();
            }
        }

        //Přidá výpůjčku do záznamu
        private void TransactionBorrow_Click(object sender, EventArgs e)
        {
            if (Transactions.Exists(x => x.BookID == int.Parse(TransactionBookID.Text) && !x.Returned))
            {
                MessageBox.Show("Není možné vypůjčit nevrácenou knihu");
                return;
            }

            if (!Users.Exists(x => x.ID == int.Parse(TransactionUserID.Text)))
            {
                MessageBox.Show("Uživatel nebyl nalezen");
                return;
            }

            if (!Books.Exists(x => x.ID == int.Parse(TransactionBookID.Text)))
            {
                MessageBox.Show("Kniha nebyla nalezena");
                return;
            }

            Transactions.Add(new Transaction
            {
                UserID = int.Parse(TransactionUserID.Text),
                BookID = int.Parse(TransactionBookID.Text),
                Returned = false,
                CreatedAt = DateTime.Now,
                End = TransactionEnd.Value
            });

            PopulateUserTable();
            PopulateBookTable();
            PopulateTransactionTable();
        }

        //Postupně vyhledává položku v tabulce podle toho jak zadáváme uživatele a knihu
        private void TransactionFocus(object sender, EventArgs e)
        {
            try
            {
                var index = Transactions.FindIndex(x => x.BookID == int.Parse(TransactionBookID.Text) && x.UserID == int.Parse(TransactionUserID.Text) && !x.Returned);
                if (index >= 0)
                {
                    TransactionTable.Items[index].Focused = true;
                }
            }
            catch
            {
                return;
            }
        }

        //Uložení výpisu do souboru
        private void TransactionPrint_Click(object sender, EventArgs e)
        {
            //vytvoří a zobrazí ukládací dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT|*.txt";
            saveFileDialog.Title = "Uložit soubor";
            saveFileDialog.ShowDialog();

            String s = "";

            //Podle nastavení radio buttonů se rozhodne co se má vypsat
            if (PrintByUser.Checked)
            {
                var items = Transactions.Where(x => x.UserID == int.Parse(TransactionUserID.Text));
                s += "Seznam transakcí uživatele s ID: " + TransactionUserID.Text + "\n\n";

                foreach (var record in items)
                {
                    s += "ID knihy: " + record.BookID + "\n";
                    s += "Od: " + record.CreatedAt.ToString().Split(' ')[0] + "\n";
                    s += "Do: " + record.End.ToString().Split(' ')[0] + "\n";
                    s += (record.Returned ? "Vráceno" : "Nevráceno") + "\n";
                    s += "\n";
                }
            }
            else if (PrintByBook.Checked)
            {
                var items = Transactions.Where(x => x.BookID == int.Parse(TransactionBookID.Text));
                s += "Seznam transakcí knihy s ID: " + TransactionBookID.Text + "\n\n";

                foreach (var record in items)
                {
                    s += "ID uživatele: " + record.UserID + "\n";
                    s += "Od: " + record.CreatedAt.ToString().Split(' ')[0] + "\n";
                    s += "Do: " + record.End.ToString().Split(' ')[0] + "\n";
                    s += (record.Returned ? "Vráceno" : "Nevráceno") + "\n";
                    s += "\n";
                }
            }
            else if (PrintBorrowed.Checked)
            {
                var items = Transactions.Where(x => !x.Returned);
                s += "Seznam vypůjčených knih\n\n";

                foreach (var record in items)
                {
                    s += "ID uživatele: " + record.UserID + "\n";
                    s += "ID knihy: " + record.BookID + "\n";
                    s += "Od: " + record.CreatedAt.ToString().Split(' ')[0] + "\n";
                    s += "Do: " + record.End.ToString().Split(' ')[0] + "\n";
                    s += (record.Returned ? "Vráceno" : "Nevráceno") + "\n";
                    s += "\n";
                }
            }

            //Uložíme soubor se zvolenou cestou
            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, s);
            }
        }

        //Funkce, která ze stringu nechá jenom požadované typy znaků
        public string RemoveExcept(string value, bool alphas = false, bool numerics = false, bool dashes = false, bool underlines = false, bool spaces = false, bool periods = false)
        {
            if (string.IsNullOrWhiteSpace(value)) return value;
            if (new[] { alphas, numerics, dashes, underlines, spaces, periods }.All(x => x == false)) return value;

            var whitelistChars = new HashSet<char>(string.Concat(
                alphas ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" : "",
                numerics ? "01234567890" : "",
                dashes ? "-" : "",
                underlines ? "_" : "",
                periods ? "." : "",
                spaces ? " " : ""
            ).ToCharArray());

            var scrubbedValue = value.Aggregate(new StringBuilder(), (sb, @char) =>
            {
                if (whitelistChars.Contains(@char)) sb.Append(@char);
                return sb;
            }).ToString();

            return scrubbedValue;
        }

        //Formátování ISBN to podoby s pomlkami
        private string ISBNtoSring(long ISBN)
        {
            String s = "";
            if (ISBN.ToString().Length == 13)
            {
                s += ISBN.ToString()[0];
                s += ISBN.ToString()[1];
                s += ISBN.ToString()[2];
                s += "-";
                s += ISBN.ToString()[3];
                s += ISBN.ToString()[4];
                s += "-";
                s += ISBN.ToString()[5];
                s += ISBN.ToString()[6];
                s += ISBN.ToString()[7];
                s += ISBN.ToString()[8];
                s += ISBN.ToString()[9];
                s += "-";
                s += ISBN.ToString()[10];
                s += ISBN.ToString()[11];
                s += "-";
                s += ISBN.ToString()[12];
            }
            return s;
        }

        private ListItemColor getColorFromTransaction(Transaction transaction)
        {
            if (transaction.Returned)
            {
                return new ListItemColor { BackColor = Color.Green, ForeColor = Color.White };
            }
            if (transaction.End < DateTime.Now)
            {
                return new ListItemColor { BackColor = Color.Red, ForeColor = Color.White };
            }
            return new ListItemColor { BackColor = Color.White, ForeColor = Color.Black };
        }
    }
}
