namespace Crownhart_LibraryCatalog
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuCatalog = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            lblCatalog = new Label();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblISBN = new Label();
            lblCopies = new Label();
            txtAuthor = new TextBox();
            txtISBN = new TextBox();
            txtCopies = new TextBox();
            btnSubmit = new Button();
            lsbCatalog = new ListBox();
            lsbBorrowing = new ListBox();
            lblBorrowing = new Label();
            btnBorrow = new Button();
            btnUndoBorrow = new Button();
            lblAddBook = new Label();
            txtTitle = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblTitleWarn = new Label();
            lblCWarn = new Label();
            lblISBNwarn = new Label();
            lblAwarn = new Label();
            chbTitle = new CheckBox();
            chbISBN = new CheckBox();
            lblNoResults = new Label();
            lblResults = new Label();
            lblWaitList = new Label();
            chbWaitListYes = new CheckBox();
            chbWaitListNo = new CheckBox();
            lblUserName = new Label();
            txtUserName = new TextBox();
            btnAddWaitList = new Button();
            lblNotifyUser = new Label();
            mnuCatalog.SuspendLayout();
            SuspendLayout();
            // 
            // mnuCatalog
            // 
            mnuCatalog.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            mnuCatalog.Location = new Point(0, 0);
            mnuCatalog.Name = "mnuCatalog";
            mnuCatalog.Size = new Size(1368, 24);
            mnuCatalog.TabIndex = 0;
            mnuCatalog.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // lblCatalog
            // 
            lblCatalog.BackColor = SystemColors.Control;
            lblCatalog.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatalog.Location = new Point(593, 38);
            lblCatalog.Name = "lblCatalog";
            lblCatalog.Size = new Size(100, 23);
            lblCatalog.TabIndex = 0;
            lblCatalog.Text = "Catalog";
            lblCatalog.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(15, 76);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(48, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(15, 111);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(68, 21);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(15, 155);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(51, 21);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN:";
            // 
            // lblCopies
            // 
            lblCopies.AutoSize = true;
            lblCopies.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCopies.Location = new Point(15, 193);
            lblCopies.Name = "lblCopies";
            lblCopies.Size = new Size(65, 21);
            lblCopies.TabIndex = 4;
            lblCopies.Text = "Copies:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(122, 113);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 6;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(122, 153);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(100, 23);
            txtISBN.TabIndex = 7;
            // 
            // txtCopies
            // 
            txtCopies.Location = new Point(122, 195);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(100, 23);
            txtCopies.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.Enabled = false;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(69, 252);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 28);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lsbCatalog
            // 
            lsbCatalog.FormattingEnabled = true;
            lsbCatalog.ItemHeight = 15;
            lsbCatalog.Location = new Point(564, 66);
            lsbCatalog.Name = "lsbCatalog";
            lsbCatalog.Size = new Size(179, 304);
            lsbCatalog.TabIndex = 10;
            // 
            // lsbBorrowing
            // 
            lsbBorrowing.FormattingEnabled = true;
            lsbBorrowing.ItemHeight = 15;
            lsbBorrowing.Location = new Point(794, 66);
            lsbBorrowing.Name = "lsbBorrowing";
            lsbBorrowing.Size = new Size(179, 304);
            lsbBorrowing.TabIndex = 11;
            // 
            // lblBorrowing
            // 
            lblBorrowing.AutoSize = true;
            lblBorrowing.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBorrowing.Location = new Point(838, 40);
            lblBorrowing.Name = "lblBorrowing";
            lblBorrowing.Size = new Size(90, 21);
            lblBorrowing.TabIndex = 12;
            lblBorrowing.Text = "Borrowing";
            lblBorrowing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBorrow
            // 
            btnBorrow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrow.Location = new Point(618, 376);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(75, 33);
            btnBorrow.TabIndex = 13;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnUndoBorrow
            // 
            btnUndoBorrow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUndoBorrow.Location = new Point(819, 376);
            btnUndoBorrow.Name = "btnUndoBorrow";
            btnUndoBorrow.Size = new Size(140, 33);
            btnUndoBorrow.TabIndex = 14;
            btnUndoBorrow.Text = "Undo Borrow";
            btnUndoBorrow.UseVisualStyleBackColor = true;
            btnUndoBorrow.Click += btnUndoBorrow_Click;
            // 
            // lblAddBook
            // 
            lblAddBook.AutoSize = true;
            lblAddBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddBook.Location = new Point(12, 40);
            lblAddBook.Name = "lblAddBook";
            lblAddBook.Size = new Size(97, 21);
            lblAddBook.TabIndex = 15;
            lblAddBook.Text = "Add a Book";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(122, 74);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 17;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(286, 138);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(183, 23);
            txtSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(316, 178);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 36);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblTitleWarn
            // 
            lblTitleWarn.Location = new Point(0, 0);
            lblTitleWarn.Name = "lblTitleWarn";
            lblTitleWarn.Size = new Size(100, 23);
            lblTitleWarn.TabIndex = 0;
            // 
            // lblCWarn
            // 
            lblCWarn.AutoSize = true;
            lblCWarn.Location = new Point(122, 296);
            lblCWarn.Name = "lblCWarn";
            lblCWarn.Size = new Size(84, 15);
            lblCWarn.TabIndex = 21;
            lblCWarn.Text = "lblCopiesWarn";
            lblCWarn.Visible = false;
            // 
            // lblISBNwarn
            // 
            lblISBNwarn.Location = new Point(0, 0);
            lblISBNwarn.Name = "lblISBNwarn";
            lblISBNwarn.Size = new Size(100, 23);
            lblISBNwarn.TabIndex = 0;
            // 
            // lblAwarn
            // 
            lblAwarn.Location = new Point(0, 0);
            lblAwarn.Name = "lblAwarn";
            lblAwarn.Size = new Size(100, 23);
            lblAwarn.TabIndex = 0;
            // 
            // chbTitle
            // 
            chbTitle.AutoSize = true;
            chbTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbTitle.Location = new Point(286, 76);
            chbTitle.Name = "chbTitle";
            chbTitle.Size = new Size(141, 25);
            chbTitle.TabIndex = 20;
            chbTitle.Text = "Search By Title";
            chbTitle.UseVisualStyleBackColor = true;
            chbTitle.CheckedChanged += chbTitle_CheckedChanged;
            // 
            // chbISBN
            // 
            chbISBN.AutoSize = true;
            chbISBN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbISBN.Location = new Point(286, 107);
            chbISBN.Name = "chbISBN";
            chbISBN.Size = new Size(144, 25);
            chbISBN.TabIndex = 21;
            chbISBN.Text = "Search By ISBN";
            chbISBN.UseVisualStyleBackColor = true;
            chbISBN.CheckedChanged += chbISBN_CheckedChanged;
            // 
            // lblNoResults
            // 
            lblNoResults.Location = new Point(0, 0);
            lblNoResults.Name = "lblNoResults";
            lblNoResults.Size = new Size(100, 23);
            lblNoResults.TabIndex = 0;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResults.Location = new Point(316, 252);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 21);
            lblResults.TabIndex = 24;
            lblResults.TextAlign = ContentAlignment.MiddleCenter;
            lblResults.Visible = false;
            // 
            // lblWaitList
            // 
            lblWaitList.AutoSize = true;
            lblWaitList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaitList.Location = new Point(286, 252);
            lblWaitList.Name = "lblWaitList";
            lblWaitList.Size = new Size(138, 21);
            lblWaitList.TabIndex = 25;
            lblWaitList.Text = "Add To Wait List?";
            lblWaitList.Visible = false;
            // 
            // chbWaitListYes
            // 
            chbWaitListYes.AutoSize = true;
            chbWaitListYes.Enabled = false;
            chbWaitListYes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbWaitListYes.Location = new Point(286, 291);
            chbWaitListYes.Name = "chbWaitListYes";
            chbWaitListYes.Size = new Size(52, 25);
            chbWaitListYes.TabIndex = 26;
            chbWaitListYes.Text = "Yes";
            chbWaitListYes.UseVisualStyleBackColor = true;
            chbWaitListYes.Visible = false;
            chbWaitListYes.CheckedChanged += chbWaitListYes_CheckedChanged;
            // 
            // chbWaitListNo
            // 
            chbWaitListNo.AutoSize = true;
            chbWaitListNo.Enabled = false;
            chbWaitListNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbWaitListNo.Location = new Point(286, 331);
            chbWaitListNo.Name = "chbWaitListNo";
            chbWaitListNo.Size = new Size(50, 25);
            chbWaitListNo.TabIndex = 27;
            chbWaitListNo.Text = "No";
            chbWaitListNo.UseVisualStyleBackColor = true;
            chbWaitListNo.Visible = false;
            chbWaitListNo.CheckedChanged += chbWaitListNo_CheckedChanged_1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(286, 374);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(170, 21);
            lblUserName.TabIndex = 28;
            lblUserName.Text = "Enter Your Username";
            lblUserName.Visible = false;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(286, 409);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(170, 23);
            txtUserName.TabIndex = 29;
            txtUserName.Visible = false;
            // 
            // btnAddWaitList
            // 
            btnAddWaitList.Enabled = false;
            btnAddWaitList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddWaitList.Location = new Point(302, 447);
            btnAddWaitList.Name = "btnAddWaitList";
            btnAddWaitList.Size = new Size(141, 39);
            btnAddWaitList.TabIndex = 30;
            btnAddWaitList.Text = "Add To Wait List";
            btnAddWaitList.UseVisualStyleBackColor = true;
            btnAddWaitList.Visible = false;
            btnAddWaitList.Click += btnAddWaitList_Click;
            // 
            // lblNotifyUser
            // 
            lblNotifyUser.AutoSize = true;
            lblNotifyUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotifyUser.Location = new Point(692, 456);
            lblNotifyUser.Name = "lblNotifyUser";
            lblNotifyUser.Size = new Size(172, 21);
            lblNotifyUser.TabIndex = 31;
            lblNotifyUser.Text = "Wait List Notification";
            lblNotifyUser.Visible = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 513);
            Controls.Add(lblNotifyUser);
            Controls.Add(btnAddWaitList);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(chbWaitListNo);
            Controls.Add(chbWaitListYes);
            Controls.Add(lblWaitList);
            Controls.Add(lblResults);
            Controls.Add(chbISBN);
            Controls.Add(chbTitle);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtTitle);
            Controls.Add(lblAddBook);
            Controls.Add(btnUndoBorrow);
            Controls.Add(btnBorrow);
            Controls.Add(lblBorrowing);
            Controls.Add(lsbBorrowing);
            Controls.Add(lsbCatalog);
            Controls.Add(btnSubmit);
            Controls.Add(txtCopies);
            Controls.Add(txtISBN);
            Controls.Add(txtAuthor);
            Controls.Add(lblCopies);
            Controls.Add(lblISBN);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(lblCatalog);
            Controls.Add(mnuCatalog);
            MainMenuStrip = mnuCatalog;
            Name = "frmMain";
            Text = "Library Catalog";
            mnuCatalog.ResumeLayout(false);
            mnuCatalog.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private MenuStrip mnuCatalog;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Label lblCatalog;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblISBN;
        private Label lblCopies;
        private TextBox txtAuthor;
        private TextBox txtISBN;
        private TextBox txtCopies;
        private Button btnSubmit;
        private ListBox lsbCatalog;
        private ListBox lsbBorrowing;
        private Label lblBorrowing;
        private Button btnBorrow;
        private Button btnUndoBorrow;
        private Label lblAddBook;
        private TextBox txtTitle;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblTitleWarn;
        private Label lblCWarn;
        private Label lblISBNwarn;
        private Label lblAwarn;
        private CheckBox chbTitle;
        private CheckBox chbISBN;
        private Label lblNoResults;
        private Label lblResults;
        private Label lblWaitList;
        private CheckBox chbWaitListYes;
        private CheckBox chbWaitListNo;
        private Label lblUserName;
        private TextBox txtUserName;
        private Button btnAddWaitList;
        private Label lblNotifyUser;
    }
}
