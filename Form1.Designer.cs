﻿
namespace LibraryADONET
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblMouse = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(31, 66);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(736, 343);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_RowEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ımportToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ımportToolStripMenuItem
            // 
            this.ımportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesFromFileToolStripMenuItem,
            this.booksFromFileToolStripMenuItem});
            this.ımportToolStripMenuItem.Name = "ımportToolStripMenuItem";
            this.ımportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ımportToolStripMenuItem.Text = "Import";
            // 
            // categoriesFromFileToolStripMenuItem
            // 
            this.categoriesFromFileToolStripMenuItem.Name = "categoriesFromFileToolStripMenuItem";
            this.categoriesFromFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriesFromFileToolStripMenuItem.Text = "Categories from File";
            this.categoriesFromFileToolStripMenuItem.Click += new System.EventHandler(this.categoriesFromFileToolStripMenuItem_Click);
            // 
            // booksFromFileToolStripMenuItem
            // 
            this.booksFromFileToolStripMenuItem.Name = "booksFromFileToolStripMenuItem";
            this.booksFromFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.booksFromFileToolStripMenuItem.Text = "Books from File";
            this.booksFromFileToolStripMenuItem.Click += new System.EventHandler(this.booksFromFileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.addToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(31, 27);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(186, 21);
            this.cbCategories.TabIndex = 2;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(31, 425);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(0, 13);
            this.lblBook.TabIndex = 3;
            // 
            // lblMouse
            // 
            this.lblMouse.AutoSize = true;
            this.lblMouse.Location = new System.Drawing.Point(731, 425);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(0, 13);
            this.lblMouse.TabIndex = 4;
            this.lblMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouse_MouseMove);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(240, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(307, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ımportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksFromFileToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblMouse;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

