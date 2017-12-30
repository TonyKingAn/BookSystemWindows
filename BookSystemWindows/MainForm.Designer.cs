using System.Drawing;
using System.Windows.Forms;

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
            this.UserManger = new System.Windows.Forms.ToolStripMenuItem();
            this.userDetail_tip = new System.Windows.Forms.ToolStripMenuItem();
            this.BookDetailList = new System.Windows.Forms.ListView();
            this.UpdateBook = new System.Windows.Forms.Button();
            this.DeleteBooks = new System.Windows.Forms.Button();
            this.RentBooks = new System.Windows.Forms.Button();
            this.ReturnBooks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.keyword_txt = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.UserManger});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 24);
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
            // 
            // CreateBooksTip
            // 
            this.CreateBooksTip.Name = "CreateBooksTip";
            this.CreateBooksTip.Size = new System.Drawing.Size(126, 22);
            this.CreateBooksTip.Text = "新增图书";
            this.CreateBooksTip.Click += new System.EventHandler(this.CreateBooks);
            // 
            // UserManger
            // 
            this.UserManger.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userDetail_tip});
            this.UserManger.Name = "UserManger";
            this.UserManger.Size = new System.Drawing.Size(71, 20);
            this.UserManger.Text = "用户管理";
            // 
            // userDetail_tip
            // 
            this.userDetail_tip.Name = "userDetail_tip";
            this.userDetail_tip.Size = new System.Drawing.Size(126, 22);
            this.userDetail_tip.Text = "用户详情";
            this.userDetail_tip.Click += new System.EventHandler(this.userDetailTip_Click);
            // 
            // BookDetailList
            // 
            this.BookDetailList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookDetailList.FullRowSelect = true;
            this.BookDetailList.GridLines = true;
            this.BookDetailList.Location = new System.Drawing.Point(37, 113);
            this.BookDetailList.Name = "BookDetailList";
            this.BookDetailList.Size = new System.Drawing.Size(1029, 309);
            this.BookDetailList.TabIndex = 1;
            this.BookDetailList.UseCompatibleStateImageBehavior = false;
            this.BookDetailList.View = System.Windows.Forms.View.Details;
            this.BookDetailList.SizeChanged += new System.EventHandler(this.listview_SizeChanged);
            // 
            // UpdateBook
            // 
            this.UpdateBook.Location = new System.Drawing.Point(854, 61);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Size = new System.Drawing.Size(94, 34);
            this.UpdateBook.TabIndex = 2;
            this.UpdateBook.Text = "修改图书";
            this.UpdateBook.UseVisualStyleBackColor = true;
            this.UpdateBook.Click += new System.EventHandler(this.UpdateBook_Click);
            // 
            // DeleteBooks
            // 
            this.DeleteBooks.Location = new System.Drawing.Point(954, 61);
            this.DeleteBooks.Name = "DeleteBooks";
            this.DeleteBooks.Size = new System.Drawing.Size(94, 34);
            this.DeleteBooks.TabIndex = 3;
            this.DeleteBooks.Text = "删除图书";
            this.DeleteBooks.UseVisualStyleBackColor = true;
            this.DeleteBooks.Click += new System.EventHandler(this.DeleteBooks_Click);
            // 
            // RentBooks
            // 
            this.RentBooks.Location = new System.Drawing.Point(654, 61);
            this.RentBooks.Name = "RentBooks";
            this.RentBooks.Size = new System.Drawing.Size(94, 34);
            this.RentBooks.TabIndex = 4;
            this.RentBooks.Text = "借书";
            this.RentBooks.UseVisualStyleBackColor = true;
            this.RentBooks.Click += new System.EventHandler(this.RentBooks_Click);
            // 
            // ReturnBooks
            // 
            this.ReturnBooks.Location = new System.Drawing.Point(754, 61);
            this.ReturnBooks.Name = "ReturnBooks";
            this.ReturnBooks.Size = new System.Drawing.Size(94, 34);
            this.ReturnBooks.TabIndex = 5;
            this.ReturnBooks.Text = "还书";
            this.ReturnBooks.UseVisualStyleBackColor = true;
            this.ReturnBooks.Click += new System.EventHandler(this.ReturnBooks_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(49, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "输入书名或书籍编码查询：";
            // 
            // keyword_txt
            // 
            this.keyword_txt.Location = new System.Drawing.Point(229, 69);
            this.keyword_txt.Name = "keyword_txt";
            this.keyword_txt.Size = new System.Drawing.Size(187, 20);
            this.keyword_txt.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 452);
            this.Controls.Add(this.keyword_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnBooks);
            this.Controls.Add(this.RentBooks);
            this.Controls.Add(this.DeleteBooks);
            this.Controls.Add(this.UpdateBook);
            this.Controls.Add(this.BookDetailList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CreateBooksTip;
        private System.Windows.Forms.ToolStripMenuItem UserManger;
        private System.Windows.Forms.ListView BookDetailList;
        private System.Windows.Forms.Button UpdateBook;
        private System.Windows.Forms.Button DeleteBooks;
        private System.Windows.Forms.Button RentBooks;
        private System.Windows.Forms.Button ReturnBooks;
        private Button button1;
        private Label label4;
        private TextBox keyword_txt;
        private ToolStripMenuItem userDetail_tip;
    }
}