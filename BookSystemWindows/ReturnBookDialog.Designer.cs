namespace BookSystemWindows
{
    partial class ReturnBookDialog
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
            this.userInfo_txt = new System.Windows.Forms.TextBox();
            this.bookType_txt = new System.Windows.Forms.TextBox();
            this.bookNumber_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.bookReturn_dp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookName_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comments_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInfo_txt
            // 
            this.userInfo_txt.Location = new System.Drawing.Point(192, 236);
            this.userInfo_txt.Name = "userInfo_txt";
            this.userInfo_txt.ReadOnly = true;
            this.userInfo_txt.Size = new System.Drawing.Size(200, 20);
            this.userInfo_txt.TabIndex = 30;
            // 
            // bookType_txt
            // 
            this.bookType_txt.Location = new System.Drawing.Point(192, 140);
            this.bookType_txt.Name = "bookType_txt";
            this.bookType_txt.ReadOnly = true;
            this.bookType_txt.Size = new System.Drawing.Size(200, 20);
            this.bookType_txt.TabIndex = 29;
            // 
            // bookNumber_txt
            // 
            this.bookNumber_txt.Location = new System.Drawing.Point(192, 95);
            this.bookNumber_txt.Name = "bookNumber_txt";
            this.bookNumber_txt.Size = new System.Drawing.Size(200, 20);
            this.bookNumber_txt.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "书籍编码：";
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(168, 360);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(82, 31);
            this.submit_btn.TabIndex = 26;
            this.submit_btn.Text = "提交";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(319, 360);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(82, 31);
            this.cancel_btn.TabIndex = 25;
            this.cancel_btn.Text = "取消";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // bookReturn_dp
            // 
            this.bookReturn_dp.CustomFormat = "yyyy年MM月dd日";
            this.bookReturn_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bookReturn_dp.Location = new System.Drawing.Point(192, 185);
            this.bookReturn_dp.Name = "bookReturn_dp";
            this.bookReturn_dp.Size = new System.Drawing.Size(200, 20);
            this.bookReturn_dp.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "归还时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "书籍类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "书籍名称：";
            // 
            // bookName_txt
            // 
            this.bookName_txt.Location = new System.Drawing.Point(192, 53);
            this.bookName_txt.Name = "bookName_txt";
            this.bookName_txt.ReadOnly = true;
            this.bookName_txt.Size = new System.Drawing.Size(200, 20);
            this.bookName_txt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "用户姓名：";
            // 
            // comments_txt
            // 
            this.comments_txt.Location = new System.Drawing.Point(192, 277);
            this.comments_txt.Multiline = true;
            this.comments_txt.Name = "comments_txt";
            this.comments_txt.Size = new System.Drawing.Size(200, 54);
            this.comments_txt.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "备        注：";
            // 
            // ReturnBookDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 434);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comments_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userInfo_txt);
            this.Controls.Add(this.bookType_txt);
            this.Controls.Add(this.bookNumber_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.bookReturn_dp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookName_txt);
            this.Name = "ReturnBookDialog";
            this.Text = "ReturnBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userInfo_txt;
        private System.Windows.Forms.TextBox bookType_txt;
        private System.Windows.Forms.TextBox bookNumber_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.DateTimePicker bookReturn_dp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookName_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox comments_txt;
        private System.Windows.Forms.Label label5;
    }
}