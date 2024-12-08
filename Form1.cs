namespace Crownhart_LibraryCatalog
{
    public partial class frmMain : Form
    {
        Catalog catalog = new Catalog();
        Borrowing borrowing = new Borrowing();
        BookTree bookTree = new BookTree();
        WaitList waitList = new WaitList();
        private TextBox[] submitTextBox;
        Book currentWaitListBook = null;




        public frmMain()
        {
            InitializeComponent();


            submitTextBox = new TextBox[] { txtTitle, txtAuthor, txtISBN, txtCopies };

            foreach (var textBox in submitTextBox)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }




            if (txtCopies.Text.Length == 0)
            {
                lblCWarn.Visible = true;
                lblCWarn.Text = "Enter the number of copies";
            }
            else
            {
                lblCWarn.Visible = false;
            }


        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void ValidateTextBoxes()
        {

            bool allFilled = submitTextBox.All(tb => !string.IsNullOrWhiteSpace(tb.Text));

            btnSubmit.Enabled = allFilled;
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string isbn = txtISBN.Text;
            int copies;



            if (!int.TryParse(txtCopies.Text, out copies))
            {
                lblCWarn.Visible = true;
                lblCWarn.Text = "Enter a valid number";
                return;
            }

            Book newBook = new Book(title, author, isbn, copies);
            catalog.AddBook(newBook);
            bookTree.AddBook(newBook);
            UpdateBookList();

            txtTitle.Clear();
            txtAuthor.Clear();
            txtISBN.Clear();
            txtCopies.Clear();
        }

        private void UpdateBookList()
        {
            lsbCatalog.Items.Clear();
            foreach (var book in catalog.GetLibrary())
            {
                lsbCatalog.Items.Add(book);
            }

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

            
            if (lsbCatalog.SelectedItem is Book selectedBook)
            {
                if (selectedBook != null)
                {
                    if (selectedBook.Copies > 0)
                    {
                        selectedBook.Copies--;
                        borrowing.Borrow(selectedBook);
                        lsbBorrowing.Items.Add(selectedBook);
                        UpdateBookList();
                    }
                    else
                    {
                        currentWaitListBook = selectedBook;
                        lblWaitList.Visible = true;
                        chbWaitListYes.Visible = true;
                        chbWaitListNo.Visible = true;
                        chbWaitListYes.Enabled = true;
                        chbWaitListNo.Enabled = true;
                        lblUserName.Visible = true;
                        btnAddWaitList.Visible = true;
                    }
                }

            }

        }


        private void btnUndoBorrow_Click(object sender, EventArgs e)
        {
            if (borrowing.GetHistory().Count > 0)
            {
                Book lastBorrowed = borrowing.GetHistory().Peek();

                borrowing.UndoBorrow();

                Book returnBook = catalog.GetLibrary().FirstOrDefault
                        (book => book.Id == lastBorrowed.Id);

                if (returnBook != null)
                {
                    if (returnBook.Copies < returnBook.OriginalCopies)
                    {
                        returnBook.Copies++;

                        if(returnBook.Copies == 1)
                        {
                            string notify = waitList.NotifyNextUser();
                            lblNotifyUser.Text = notify;
                            lblNotifyUser.Visible = true;
                        }
                    }

                    UpdateBookList();

                    for (int i = 0; i < lsbBorrowing.Items.Count; i++)
                    {
                        lsbBorrowing.Items.RemoveAt(i);
                        break;
                    }
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string bookSearch = txtSearch.Text.Trim();

            Book foundBook = bookTree.SearchByTitleOrISBN(bookSearch); ;

            DisplayResults(foundBook);


        }

        private void DisplayResults(Book foundBook)
        {


            if (foundBook != null)
            {

                HighlightBookInCatalog(foundBook.Id);
            }
            else
            {
                lblResults.Visible = true;
                lblResults.Text = "No Match Found";
            }

            txtSearch.Clear();
        }

        private void HighlightBookInCatalog(int bookId)
        {
            for (int i = 0; i < lsbCatalog.Items.Count; i++)
            {
                if (lsbCatalog.Items[i] is Book catalogBook && catalogBook.Id == bookId)
                {
                    lsbCatalog.SelectedIndex = i;
                    lsbCatalog.TopIndex = i;
                    break;
                }
            }
        }

        private void chbTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTitle.Checked)
            {
                chbISBN.Checked = false;
                chbISBN.Enabled = false;
            }
            else
            {

                chbISBN.Enabled = true;
            }
        }

        private void chbISBN_CheckedChanged(object sender, EventArgs e)
        {
            if (chbISBN.Checked)
            {
                chbTitle.Checked = false;
                chbTitle.Enabled = false;
            }
            else
            {
                chbTitle.Enabled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = !string.IsNullOrEmpty(txtSearch.Text.Trim());

        }

        private void chbWaitListYes_CheckedChanged(object sender, EventArgs e)
        {

            if (chbWaitListYes.Checked)
            {
                chbWaitListNo.Checked = false;
                chbWaitListNo.Enabled = false;
                txtUserName.Visible = true;
                btnAddWaitList.Visible = true;
                btnAddWaitList.Enabled = true;
                chbWaitListNo.Enabled = false;
            }
            else
            {
                chbWaitListNo.Visible = true;
                chbWaitListNo.Enabled = true;
            }

        }

        private void chbWaitListNo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbWaitListNo.Checked)
            {
                lblWaitList.Visible = false;
                chbWaitListYes.Visible = false;
                chbWaitListNo.Visible = false;
                chbWaitListYes.Enabled = false;
                chbWaitListNo.Enabled = false;
                lblUserName.Visible = false;
                txtUserName.Visible = false;
                btnAddWaitList.Visible = false;
            }
            else
            {
                lblWaitList.Visible = true;
                chbWaitListYes.Visible = true;
                chbWaitListNo.Visible = true;
                chbWaitListYes.Enabled = true;
                chbWaitListNo.Enabled = true;
                lblUserName.Visible = true;
                btnAddWaitList.Visible = true;
            }
        }


        private void btnAddWaitList_Click(object sender, EventArgs e)
        {
            if (currentWaitListBook != null && !string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                string userName = txtUserName.Text.Trim();
                btnAddWaitList.Enabled = true;
                waitList.AddToWaitList(userName);

                txtUserName.Clear();
                lblWaitList.Visible = false;
                chbWaitListYes.Visible = false;
                chbWaitListNo.Visible = false;
                chbWaitListYes.Enabled = false;
                chbWaitListNo.Enabled = false;
                lblUserName.Visible = false;
                txtUserName.Visible = false;
                btnAddWaitList.Visible = false;
            }
        }

        
    }
}
