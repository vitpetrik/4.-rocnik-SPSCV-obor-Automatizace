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
            public long ID;

            public string Name;
        }

        [DelimitedRecord(";")]
        public class Book
        {
            public long ID;

            public long ISBN;
        }

        [DelimitedRecord(";")]
        public class Transaction
        {
            public long UserID;
            public long bookID;

            [FieldConverter(ConverterKind.Date, "dd-MM-yyyy")]
            public DateTime CreatedAt;
            [FieldConverter(ConverterKind.Date, "dd-MM-yyyy")]
            public DateTime End;
        }

        public Form1()
        {
            InitializeComponent();

            UsersTable.Columns.Add("ID", 200);
            UsersTable.Columns.Add("Jméno", 200);


            ReadFiles();
        }

        private void ReadFiles()
        {
            try
            {
                Users = new FileHelperEngine<User>().ReadFile("users.csv").ToList();
                Books = new FileHelperEngine<Book>().ReadFile("books.csv").ToList();
                Transactions = new FileHelperEngine<Transaction>().ReadFile("transactions.csv").ToList();
            } 
            catch (BadUsageException e)
            {
                Console.WriteLine(e);
            }

            UsersTable.Items.Clear();
            foreach (var record in Users)
            {
                UsersTable.Items.Add(new ListViewItem(new string[2] { record.ID.ToString(), record.Name }));
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if(UsersTable.FocusedItem != null)
            {
                var index = UsersTable.FocusedItem.Index;
                Users.RemoveAt(index);

                new FileHelperEngine<User>().WriteFile("users.csv", Users);
                ReadFiles();
            }
        }

        private void UserGenerateID_Click(object sender, EventArgs e)
        {
            UserID.Text = Math.Abs(LongRandom(1000000000000, 9999999999999, new Random())).ToString();
        }

        private long LongRandom(long min, long max, Random rand)
        {
            long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
            result = (result << 32);
            result = result | (long)rand.Next((Int32)min, (Int32)max);
            return result;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Users.Add(new User { ID = long.Parse(UserID.Text), Name = UserName.Text });
            new FileHelperEngine<User>().WriteFile("users.csv", Users);
            ReadFiles();
        }
    }
}
