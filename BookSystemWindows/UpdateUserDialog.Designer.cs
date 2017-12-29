namespace BookSystemWindows
{
    partial class UpdateUserDialog
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.userExpire_dp = new System.Windows.Forms.DateTimePicker();
            this.userBirthday_dp = new System.Windows.Forms.DateTimePicker();
            this.userComments_txt = new System.Windows.Forms.TextBox();
            this.userMobile_txt = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓      名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "电      话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "生      日：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "到期时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "备      注：";
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(195, 69);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(200, 20);
            this.userName_txt.TabIndex = 5;
            this.userName_txt.ReadOnly = true;
            // 
            // userExpire_dp
            // 
            this.userExpire_dp.CustomFormat = "yyyy年MM月dd日";
            this.userExpire_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.userExpire_dp.Location = new System.Drawing.Point(195, 231);
            this.userExpire_dp.Name = "userExpire_dp";
            this.userExpire_dp.Size = new System.Drawing.Size(200, 20);
            this.userExpire_dp.TabIndex = 6;
            // 
            // userBirthday_dp
            // 
            this.userBirthday_dp.CustomFormat = "yyyy年MM月dd日";
            this.userBirthday_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.userBirthday_dp.Location = new System.Drawing.Point(195, 192);
            this.userBirthday_dp.Name = "userBirthday_dp";
            this.userBirthday_dp.Size = new System.Drawing.Size(200, 20);
            this.userBirthday_dp.TabIndex = 7;
            // 
            // userComments_txt
            // 
            this.userComments_txt.Location = new System.Drawing.Point(195, 279);
            this.userComments_txt.Multiline = true;
            this.userComments_txt.Name = "userComments_txt";
            this.userComments_txt.Size = new System.Drawing.Size(200, 67);
            this.userComments_txt.TabIndex = 8;
            // 
            // userMobile_txt
            // 
            this.userMobile_txt.Location = new System.Drawing.Point(195, 148);
            this.userMobile_txt.Name = "userMobile_txt";
            this.userMobile_txt.Size = new System.Drawing.Size(200, 20);
            this.userMobile_txt.TabIndex = 9;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(154, 385);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(82, 32);
            this.reset_btn.TabIndex = 10;
            this.reset_btn.Text = "重置";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(322, 385);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(82, 32);
            this.submit_btn.TabIndex = 11;
            this.submit_btn.Text = "提交";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(213, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(38, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "男";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(322, 113);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(38, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "女";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "性      别：";
            // 
            // UpdateUserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 494);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.userMobile_txt);
            this.Controls.Add(this.userComments_txt);
            this.Controls.Add(this.userBirthday_dp);
            this.Controls.Add(this.userExpire_dp);
            this.Controls.Add(this.userName_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(542, 533);
            this.Name = "UpdateUserDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.DateTimePicker userExpire_dp;
        private System.Windows.Forms.DateTimePicker userBirthday_dp;
        private System.Windows.Forms.TextBox userComments_txt;
        private System.Windows.Forms.TextBox userMobile_txt;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label7;
    }
}