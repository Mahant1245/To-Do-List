namespace To_Do_List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.ListBtn = new System.Windows.Forms.Button();
            this.AddTextbox = new System.Windows.Forms.TextBox();
            this.RemoveTextbox = new System.Windows.Forms.TextBox();
            this.RemoveAllBtn = new System.Windows.Forms.Button();
            this.TodoListbox = new System.Windows.Forms.ListBox();
            this.CompletedItemListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(127, 103);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(598, 103);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 1;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ListBtn
            // 
            this.ListBtn.Location = new System.Drawing.Point(374, 103);
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.Size = new System.Drawing.Size(75, 23);
            this.ListBtn.TabIndex = 2;
            this.ListBtn.Text = "List All";
            this.ListBtn.UseVisualStyleBackColor = true;
            this.ListBtn.Click += new System.EventHandler(this.ListBtn_Click);
            // 
            // AddTextbox
            // 
            this.AddTextbox.Location = new System.Drawing.Point(118, 74);
            this.AddTextbox.Name = "AddTextbox";
            this.AddTextbox.Size = new System.Drawing.Size(100, 23);
            this.AddTextbox.TabIndex = 3;
            this.AddTextbox.TextChanged += new System.EventHandler(this.AddTextbox_TextChanged);
            // 
            // RemoveTextbox
            // 
            this.RemoveTextbox.Location = new System.Drawing.Point(588, 58);
            this.RemoveTextbox.Name = "RemoveTextbox";
            this.RemoveTextbox.Size = new System.Drawing.Size(100, 23);
            this.RemoveTextbox.TabIndex = 5;
            // 
            // RemoveAllBtn
            // 
            this.RemoveAllBtn.Location = new System.Drawing.Point(678, 413);
            this.RemoveAllBtn.Name = "RemoveAllBtn";
            this.RemoveAllBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveAllBtn.TabIndex = 6;
            this.RemoveAllBtn.Text = "Remove All";
            this.RemoveAllBtn.UseVisualStyleBackColor = true;
            this.RemoveAllBtn.Click += new System.EventHandler(this.RemoveAllBtn_Click);
            // 
            // TodoListbox
            // 
            this.TodoListbox.FormattingEnabled = true;
            this.TodoListbox.ItemHeight = 15;
            this.TodoListbox.Location = new System.Drawing.Point(199, 188);
            this.TodoListbox.Name = "TodoListbox";
            this.TodoListbox.Size = new System.Drawing.Size(120, 94);
            this.TodoListbox.TabIndex = 8;
            // 
            // CompletedItemListbox
            // 
            this.CompletedItemListbox.FormattingEnabled = true;
            this.CompletedItemListbox.ItemHeight = 15;
            this.CompletedItemListbox.Location = new System.Drawing.Point(341, 188);
            this.CompletedItemListbox.Name = "CompletedItemListbox";
            this.CompletedItemListbox.Size = new System.Drawing.Size(120, 94);
            this.CompletedItemListbox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CompletedItemListbox);
            this.Controls.Add(this.TodoListbox);
            this.Controls.Add(this.RemoveAllBtn);
            this.Controls.Add(this.RemoveTextbox);
            this.Controls.Add(this.AddTextbox);
            this.Controls.Add(this.ListBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Form1";
            this.Text = "To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button ListBtn;
        private System.Windows.Forms.TextBox AddTextbox;
        private System.Windows.Forms.TextBox RemoveTextbox;
        private System.Windows.Forms.Button RemoveAllBtn;
        private System.Windows.Forms.ListBox TodoListbox;
        private System.Windows.Forms.ListBox CompletedItemListbox;
    }
}
