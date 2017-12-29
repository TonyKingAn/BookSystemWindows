namespace BookSystemWindows
{
    partial class RentBooksDialog
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
            this.bookName_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookRentDate_dp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.bookReturn_dp = new System.Windows.Forms.DateTimePicker();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bookNumber_txt = new System.Windows.Forms.TextBox();
            this.bookType_txt = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.userInfo_txt = new System.Windows.Forms.TextBox();
            this.selectUser_btn = new System.Windows.Forms.Button();
            this.userId_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bookName_txt
            // 
            this.bookName_txt.Location = new System.Drawing.Point(191, 53);
            this.bookName_txt.Name = "bookName_txt";
            this.bookName_txt.ReadOnly = true;
            this.bookName_txt.Size = new System.Drawing.Size(200, 20);
            this.bookName_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "书籍名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "书籍类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "借阅时间：";
            // 
            // bookRentDate_dp
            // 
            this.bookRentDate_dp.CustomFormat = "yyyy年MM月dd日";
            this.bookRentDate_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bookRentDate_dp.Location = new System.Drawing.Point(191, 189);
            this.bookRentDate_dp.Name = "bookRentDate_dp";
            this.bookRentDate_dp.Size = new System.Drawing.Size(200, 20);
            this.bookRentDate_dp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "归还时间：";
            // 
            // bookReturn_dp
            // 
            this.bookReturn_dp.CustomFormat = "yyyy年MM月dd日";
            this.bookReturn_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bookReturn_dp.Location = new System.Drawing.Point(191, 241);
            this.bookReturn_dp.Name = "bookReturn_dp";
            this.bookReturn_dp.Size = new System.Drawing.Size(200, 20);
            this.bookReturn_dp.TabIndex = 7;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(167, 322);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(82, 31);
            this.submit_btn.TabIndex = 11;
            this.submit_btn.Text = "提交";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "书籍编码：";
            // 
            // bookNumber_txt
            // 
            this.bookNumber_txt.Location = new System.Drawing.Point(191, 95);
            this.bookNumber_txt.Name = "bookNumber_txt";
            this.bookNumber_txt.Size = new System.Drawing.Size(200, 20);
            this.bookNumber_txt.TabIndex = 13;
            // 
            // bookType_txt
            // 
            this.bookType_txt.Location = new System.Drawing.Point(191, 140);
            this.bookType_txt.Name = "bookType_txt";
            this.bookType_txt.ReadOnly = true;
            this.bookType_txt.Size = new System.Drawing.Size(200, 20);
            this.bookType_txt.TabIndex = 14;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(318, 322);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(82, 31);
            this.cancel_btn.TabIndex = 10;
            this.cancel_btn.Text = "取消";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // userInfo_txt
            // 
            this.userInfo_txt.Location = new System.Drawing.Point(191, 278);
            this.userInfo_txt.Name = "userInfo_txt";
            this.userInfo_txt.ReadOnly = true;
            this.userInfo_txt.Size = new System.Drawing.Size(200, 20);
            this.userInfo_txt.TabIndex = 15;
            // 
            // selectUser_btn
            // 
            this.selectUser_btn.Location = new System.Drawing.Point(93, 277);
            this.selectUser_btn.Name = "selectUser_btn";
            this.selectUser_btn.Size = new System.Drawing.Size(75, 23);
            this.selectUser_btn.TabIndex = 16;
            this.selectUser_btn.Text = "选择用户";
            this.selectUser_btn.UseVisualStyleBackColor = true;
            this.selectUser_btn.Click += new System.EventHandler(this.selectUser_btn_Click);
            // 
            // userId_txt
            // 
            this.userId_txt.Location = new System.Drawing.Point(191, 22);
            this.userId_txt.Name = "userId_txt";
            this.userId_txt.Size = new System.Drawing.Size(100, 20);
            this.userId_txt.TabIndex = 17;
            // 
            // RentBooksDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 409);
            this.Controls.Add(this.userId_txt);
            this.Controls.Add(this.selectUser_btn);
            this.Controls.Add(this.userInfo_txt);
            this.Controls.Add(this.bookType_txt);
            this.Controls.Add(this.bookNumber_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.bookReturn_dp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookRentDate_dp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookName_txt);
            this.Name = "RentBooksDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "借阅读书";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookName_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker bookRentDate_dp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker bookReturn_dp;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bookNumber_txt;
        private System.Windows.Forms.TextBox bookType_txt;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox userInfo_txt;
        private System.Windows.Forms.Button selectUser_btn;
        private System.Windows.Forms.TextBox userId_txt;
    }
}