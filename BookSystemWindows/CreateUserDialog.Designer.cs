namespace BookSystemWindows
{
    partial class CreateUserDialog
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
            this.expireDate_dp = new System.Windows.Forms.DateTimePicker();
            this.userBirthday_dp = new System.Windows.Forms.DateTimePicker();
            this.userComments_txt = new System.Windows.Forms.TextBox();
            this.userMobile_txt = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.male_cb = new System.Windows.Forms.CheckBox();
            this.female_cb = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓      名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "电      话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "生      日：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "到期时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "备      注：";
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(198, 69);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(200, 20);
            this.userName_txt.TabIndex = 5;
            // 
            // expireDate_dp
            // 
            this.expireDate_dp.CustomFormat = "yyyy年MM月dd日";
            this.expireDate_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expireDate_dp.Location = new System.Drawing.Point(198, 231);
            this.expireDate_dp.Name = "expireDate_dp";
            this.expireDate_dp.Size = new System.Drawing.Size(200, 20);
            this.expireDate_dp.TabIndex = 6;
            // 
            // userBirthday_dp
            // 
            this.userBirthday_dp.CustomFormat = "yyyy年MM月dd日";
            this.userBirthday_dp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.userBirthday_dp.Location = new System.Drawing.Point(198, 192);
            this.userBirthday_dp.Name = "userBirthday_dp";
            this.userBirthday_dp.Size = new System.Drawing.Size(200, 20);
            this.userBirthday_dp.TabIndex = 7;
            // 
            // userComments_txt
            // 
            this.userComments_txt.Location = new System.Drawing.Point(198, 279);
            this.userComments_txt.Multiline = true;
            this.userComments_txt.Name = "userComments_txt";
            this.userComments_txt.Size = new System.Drawing.Size(200, 67);
            this.userComments_txt.TabIndex = 8;
            // 
            // userMobile_txt
            // 
            this.userMobile_txt.Location = new System.Drawing.Point(198, 148);
            this.userMobile_txt.Name = "userMobile_txt";
            this.userMobile_txt.Size = new System.Drawing.Size(200, 20);
            this.userMobile_txt.TabIndex = 9;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(158, 392);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(82, 32);
            this.reset_btn.TabIndex = 10;
            this.reset_btn.Text = "重置";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(302, 392);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(82, 32);
            this.submit_btn.TabIndex = 11;
            this.submit_btn.Text = "提交";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // male_cb
            // 
            this.male_cb.AutoSize = true;
            this.male_cb.Location = new System.Drawing.Point(216, 113);
            this.male_cb.Name = "male_cb";
            this.male_cb.Size = new System.Drawing.Size(38, 17);
            this.male_cb.TabIndex = 12;
            this.male_cb.Text = "男";
            this.male_cb.UseVisualStyleBackColor = true;
            // 
            // female_cb
            // 
            this.female_cb.AutoSize = true;
            this.female_cb.Location = new System.Drawing.Point(325, 113);
            this.female_cb.Name = "female_cb";
            this.female_cb.Size = new System.Drawing.Size(38, 17);
            this.female_cb.TabIndex = 13;
            this.female_cb.Text = "女";
            this.female_cb.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "性      别：";
            // 
            // CreateUserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 494);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.female_cb);
            this.Controls.Add(this.male_cb);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.userMobile_txt);
            this.Controls.Add(this.userComments_txt);
            this.Controls.Add(this.userBirthday_dp);
            this.Controls.Add(this.expireDate_dp);
            this.Controls.Add(this.userName_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateUserDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建用户";
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
        private System.Windows.Forms.DateTimePicker expireDate_dp;
        private System.Windows.Forms.DateTimePicker userBirthday_dp;
        private System.Windows.Forms.TextBox userComments_txt;
        private System.Windows.Forms.TextBox userMobile_txt;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.CheckBox male_cb;
        private System.Windows.Forms.CheckBox female_cb;
        private System.Windows.Forms.Label label7;
    }
}