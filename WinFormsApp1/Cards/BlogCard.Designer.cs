namespace WinFormsApp1
{
    partial class BlogCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Id = new Label();
            URL = new Label();
            listBoxPosts = new ListBox();
            SuspendLayout();
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Dock = DockStyle.Top;
            Id.Location = new Point(0, 0);
            Id.Name = "Id";
            Id.Size = new Size(17, 15);
            Id.TabIndex = 0;
            Id.Text = "Id";
            // 
            // URL
            // 
            URL.AutoSize = true;
            URL.Dock = DockStyle.Top;
            URL.Location = new Point(0, 15);
            URL.Name = "URL";
            URL.Size = new Size(28, 15);
            URL.TabIndex = 1;
            URL.Text = "URL";
            // 
            // listBoxPosts
            // 
            listBoxPosts.Dock = DockStyle.Fill;
            listBoxPosts.FormattingEnabled = true;
            listBoxPosts.Location = new Point(0, 30);
            listBoxPosts.Name = "listBoxPosts";
            listBoxPosts.Size = new Size(150, 120);
            listBoxPosts.TabIndex = 2;
            // 
            // BlogCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(listBoxPosts);
            Controls.Add(URL);
            Controls.Add(Id);
            Name = "BlogCard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Id;
        private Label URL;
        private ListBox listBoxPosts;
    }
}
