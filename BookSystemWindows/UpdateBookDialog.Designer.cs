using System.Drawing;

namespace BookSystemWindows
{
    partial class UpdateBookDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookName_txt = new System.Windows.Forms.TextBox();
            this.bookNumber_txt = new System.Windows.Forms.TextBox();
            this.bookType_cb = new System.Windows.Forms.ComboBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(71, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "书       名:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(68, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "书籍编码:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(69, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "图书类型：";
            // 
            // bookName_txt
            // 
            this.bookName_txt.Location = new System.Drawing.Point(206, 87);
            this.bookName_txt.Name = "bookName_txt";
            this.bookName_txt.Size = new System.Drawing.Size(179, 20);
            this.bookName_txt.TabIndex = 3;
            // 
            // bookNumber_txt
            // 
            this.bookNumber_txt.Location = new System.Drawing.Point(206, 144);
            this.bookNumber_txt.Name = "bookNumber_txt";
            this.bookNumber_txt.Size = new System.Drawing.Size(179, 20);
            this.bookNumber_txt.TabIndex = 4;
            // 
            // bookType_cb
            // 
            this.bookType_cb.FormattingEnabled = true;
            this.bookType_cb.Location = new System.Drawing.Point(204, 209);
            this.bookType_cb.Name = "bookType_cb";
            this.bookType_cb.Size = new System.Drawing.Size(179, 21);
            this.bookType_cb.TabIndex = 5;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(287, 267);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(96, 32);
            this.confirm_btn.TabIndex = 6;
            this.confirm_btn.Text = "确定";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // UpdateBookDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 354);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.bookType_cb);
            this.Controls.Add(this.bookNumber_txt);
            this.Controls.Add(this.bookName_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateBookDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改书籍";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookName_txt;
        private System.Windows.Forms.TextBox bookNumber_txt;
        private System.Windows.Forms.ComboBox bookType_cb;
        private System.Windows.Forms.Button confirm_btn;
    }
}