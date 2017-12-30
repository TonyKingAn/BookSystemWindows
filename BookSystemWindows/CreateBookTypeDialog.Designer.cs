namespace BookSystemWindows
{
    partial class CreateBookTypeDialog
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
            this.create_btn = new System.Windows.Forms.Button();
            this.booktype_lbl = new System.Windows.Forms.Label();
            this.bookType_txt = new System.Windows.Forms.TextBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.bookType_List = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(245, 38);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(75, 23);
            this.create_btn.TabIndex = 0;
            this.create_btn.Text = "新建";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // booktype_lbl
            // 
            this.booktype_lbl.AutoSize = true;
            this.booktype_lbl.Location = new System.Drawing.Point(33, 42);
            this.booktype_lbl.Name = "booktype_lbl";
            this.booktype_lbl.Size = new System.Drawing.Size(61, 13);
            this.booktype_lbl.TabIndex = 1;
            this.booktype_lbl.Text = "图书类型: ";
            // 
            // bookType_txt
            // 
            this.bookType_txt.Location = new System.Drawing.Point(98, 40);
            this.bookType_txt.Name = "bookType_txt";
            this.bookType_txt.Size = new System.Drawing.Size(129, 20);
            this.bookType_txt.TabIndex = 2;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(139, 96);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 23);
            this.del_btn.TabIndex = 3;
            this.del_btn.Text = "删除";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // bookType_List
            // 
            this.bookType_List.Location = new System.Drawing.Point(42, 120);
            this.bookType_List.Name = "bookType_List";
            this.bookType_List.Size = new System.Drawing.Size(281, 194);
            this.bookType_List.TabIndex = 4;
            this.bookType_List.UseCompatibleStateImageBehavior = false;
            this.bookType_List.View = System.Windows.Forms.View.Details;
            this.bookType_List.SizeChanged += new System.EventHandler(this.listview_SizeChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "已有图书类型：";
            // 
            // CreateBookTypeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookType_List);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.bookType_txt);
            this.Controls.Add(this.booktype_lbl);
            this.Controls.Add(this.create_btn);
            this.Name = "CreateBookTypeDialog";
            this.Text = "CreateBookTypeDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label booktype_lbl;
        private System.Windows.Forms.TextBox bookType_txt;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.ListView bookType_List;
        private System.Windows.Forms.Label label1;
    }
}