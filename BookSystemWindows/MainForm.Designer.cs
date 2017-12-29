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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.userDetail_tip.Size = new System.Drawing.Size(152, 22);
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
            this.BookDetailList.Location = new System.Drawing.Point(37, 159);
            this.BookDetailList.Name = "BookDetailList";
            this.BookDetailList.Size = new System.Drawing.Size(1029, 305);
            this.BookDetailList.TabIndex = 1;
            this.BookDetailList.UseCompatibleStateImageBehavior = false;
            this.BookDetailList.View = System.Windows.Forms.View.Details;
            this.BookDetailList.SizeChanged += new System.EventHandler(this.listview_SizeChanged);
            // 
            // UpdateBook
            // 
            this.UpdateBook.Location = new System.Drawing.Point(794, 43);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Size = new System.Drawing.Size(94, 34);
            this.UpdateBook.TabIndex = 2;
            this.UpdateBook.Text = "修改图书";
            this.UpdateBook.UseVisualStyleBackColor = true;
            this.UpdateBook.Click += new System.EventHandler(this.UpdateBook_Click);
            // 
            // DeleteBooks
            // 
            this.DeleteBooks.Location = new System.Drawing.Point(794, 96);
            this.DeleteBooks.Name = "DeleteBooks";
            this.DeleteBooks.Size = new System.Drawing.Size(94, 34);
            this.DeleteBooks.TabIndex = 3;
            this.DeleteBooks.Text = "删除图书";
            this.DeleteBooks.UseVisualStyleBackColor = true;
            this.DeleteBooks.Click += new System.EventHandler(this.DeleteBooks_Click);
            // 
            // RentBooks
            // 
            this.RentBooks.Location = new System.Drawing.Point(923, 96);
            this.RentBooks.Name = "RentBooks";
            this.RentBooks.Size = new System.Drawing.Size(94, 34);
            this.RentBooks.TabIndex = 4;
            this.RentBooks.Text = "借书";
            this.RentBooks.UseVisualStyleBackColor = true;
            this.RentBooks.Click += new System.EventHandler(this.RentBooks_Click);
            // 
            // ReturnBooks
            // 
            this.ReturnBooks.Location = new System.Drawing.Point(923, 44);
            this.ReturnBooks.Name = "ReturnBooks";
            this.ReturnBooks.Size = new System.Drawing.Size(94, 34);
            this.ReturnBooks.TabIndex = 5;
            this.ReturnBooks.Text = "还书";
            this.ReturnBooks.UseVisualStyleBackColor = true;
            this.ReturnBooks.Click += new System.EventHandler(this.ReturnBooks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "图书名称：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "作者姓名：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(409, 58);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(409, 102);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "图书编号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "关键字词：";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(164, 58);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(117, 20);
            this.textBox4.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 496);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox textBox4;
        private ToolStripMenuItem userDetail_tip;
    }
}