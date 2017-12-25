namespace BookSystemWindows
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateBooksTip = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateUserTip = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateUserTip = new System.Windows.Forms.ToolStripMenuItem();
            this.BookDetailList = new System.Windows.Forms.ListView();
            this.UpdateBook = new System.Windows.Forms.Button();
            this.DeleteBooks = new System.Windows.Forms.Button();
            this.RentBooks = new System.Windows.Forms.Button();
            this.ReturnBooks = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.用户管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateBooksTip});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "图书管理";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // CreateBooksTip
            // 
            this.CreateBooksTip.Name = "CreateBooksTip";
            this.CreateBooksTip.Size = new System.Drawing.Size(126, 22);
            this.CreateBooksTip.Text = "新增图书";
            this.CreateBooksTip.Click += new System.EventHandler(this.CreateBooks);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateUserTip,
            this.UpdateUserTip});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // CreateUserTip
            // 
            this.CreateUserTip.Name = "CreateUserTip";
            this.CreateUserTip.Size = new System.Drawing.Size(126, 22);
            this.CreateUserTip.Text = "新增用户";
            this.CreateUserTip.Click += new System.EventHandler(this.CreateUserTip_Click);
            // 
            // UpdateUserTip
            // 
            this.UpdateUserTip.Name = "UpdateUserTip";
            this.UpdateUserTip.Size = new System.Drawing.Size(126, 22);
            this.UpdateUserTip.Text = "修改用户";
            this.UpdateUserTip.Click += new System.EventHandler(this.UpdateUserTip_Click);
            // 
            // BookDetailList
            // 
            this.BookDetailList.Location = new System.Drawing.Point(34, 67);
            this.BookDetailList.Name = "BookDetailList";
            this.BookDetailList.Size = new System.Drawing.Size(388, 254);
            this.BookDetailList.TabIndex = 1;
            this.BookDetailList.UseCompatibleStateImageBehavior = false;
            this.BookDetailList.View = System.Windows.Forms.View.Details;
            // 
            // UpdateBook
            // 
            this.UpdateBook.Location = new System.Drawing.Point(472, 96);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Size = new System.Drawing.Size(75, 23);
            this.UpdateBook.TabIndex = 2;
            this.UpdateBook.Text = "修改图书";
            this.UpdateBook.UseVisualStyleBackColor = true;
            // 
            // DeleteBooks
            // 
            this.DeleteBooks.Location = new System.Drawing.Point(472, 154);
            this.DeleteBooks.Name = "DeleteBooks";
            this.DeleteBooks.Size = new System.Drawing.Size(75, 23);
            this.DeleteBooks.TabIndex = 3;
            this.DeleteBooks.Text = "删除图书";
            this.DeleteBooks.UseVisualStyleBackColor = true;
            // 
            // RentBooks
            // 
            this.RentBooks.Location = new System.Drawing.Point(472, 208);
            this.RentBooks.Name = "RentBooks";
            this.RentBooks.Size = new System.Drawing.Size(75, 23);
            this.RentBooks.TabIndex = 4;
            this.RentBooks.Text = "借书";
            this.RentBooks.UseVisualStyleBackColor = true;
            // 
            // ReturnBooks
            // 
            this.ReturnBooks.Location = new System.Drawing.Point(472, 266);
            this.ReturnBooks.Name = "ReturnBooks";
            this.ReturnBooks.Size = new System.Drawing.Size(75, 23);
            this.ReturnBooks.TabIndex = 5;
            this.ReturnBooks.Text = "还书";
            this.ReturnBooks.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 376);
            this.Controls.Add(this.ReturnBooks);
            this.Controls.Add(this.RentBooks);
            this.Controls.Add(this.DeleteBooks);
            this.Controls.Add(this.UpdateBook);
            this.Controls.Add(this.BookDetailList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CreateBooksTip;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateUserTip;
        private System.Windows.Forms.ToolStripMenuItem UpdateUserTip;
        private System.Windows.Forms.ListView BookDetailList;
        private System.Windows.Forms.Button UpdateBook;
        private System.Windows.Forms.Button DeleteBooks;
        private System.Windows.Forms.Button RentBooks;
        private System.Windows.Forms.Button ReturnBooks;
    }
}