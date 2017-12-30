namespace BookSystemWindows
{
    partial class UserDetailPage
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
            this.userDetailList = new System.Windows.Forms.ListView();
            this.keyword_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUser_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUser_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUser_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.submit_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userDetailList
            // 
            this.userDetailList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDetailList.FullRowSelect = true;
            this.userDetailList.GridLines = true;
            this.userDetailList.Location = new System.Drawing.Point(45, 99);
            this.userDetailList.Name = "userDetailList";
            this.userDetailList.Size = new System.Drawing.Size(784, 294);
            this.userDetailList.TabIndex = 1;
            this.userDetailList.UseCompatibleStateImageBehavior = false;
            this.userDetailList.View = System.Windows.Forms.View.Details;
            this.userDetailList.SizeChanged += new System.EventHandler(this.listview_SizeChanged);
            // 
            // keyword_txt
            // 
            this.keyword_txt.Location = new System.Drawing.Point(45, 63);
            this.keyword_txt.Name = "keyword_txt";
            this.keyword_txt.Size = new System.Drawing.Size(180, 20);
            this.keyword_txt.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(262, 63);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "查询";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUser_btn,
            this.updateUser_btn,
            this.deleteUser_btn});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // createUser_btn
            // 
            this.createUser_btn.Name = "createUser_btn";
            this.createUser_btn.Size = new System.Drawing.Size(126, 22);
            this.createUser_btn.Text = "新建用户";
            this.createUser_btn.Click += new System.EventHandler(this.createUser_btn_Click);
            // 
            // updateUser_btn
            // 
            this.updateUser_btn.Name = "updateUser_btn";
            this.updateUser_btn.Size = new System.Drawing.Size(126, 22);
            this.updateUser_btn.Text = "修改用户";
            this.updateUser_btn.Click += new System.EventHandler(this.updateUser_btn_Click);
            // 
            // deleteUser_btn
            // 
            this.deleteUser_btn.Name = "deleteUser_btn";
            this.deleteUser_btn.Size = new System.Drawing.Size(126, 22);
            this.deleteUser_btn.Text = "删除用户";
            this.deleteUser_btn.Click += new System.EventHandler(this.deleteUser_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(428, 63);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 23);
            this.submit_btn.TabIndex = 4;
            this.submit_btn.Text = "确定";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // UserDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 452);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.keyword_txt);
            this.Controls.Add(this.userDetailList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserDetailPage";
            this.Text = "用户信息";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView userDetailList;
        private System.Windows.Forms.TextBox keyword_txt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUser_btn;
        private System.Windows.Forms.ToolStripMenuItem updateUser_btn;
        private System.Windows.Forms.ToolStripMenuItem deleteUser_btn;
        private System.Windows.Forms.Button submit_btn;
    }
}