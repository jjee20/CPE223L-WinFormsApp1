namespace WinFormsApp1
{
    partial class BlogView
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlogView));
            dgBLogs = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewComboBoxColumn();
            Column4 = new DataGridViewButtonColumn();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            imageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            txtURL = new TextBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgBLogs).BeginInit();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgBLogs
            // 
            dgBLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBLogs.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4 });
            dgBLogs.Location = new Point(373, 49);
            dgBLogs.Name = "dgBLogs";
            dgBLogs.Size = new Size(415, 389);
            dgBLogs.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BlogId";
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Url";
            Column2.HeaderText = "URL";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.DataPropertyName = "PostTitles";
            Column3.HeaderText = "Posts";
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Items.AddRange(new object[] { "Yes", "No" });
            Column5.Name = "Column5";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column4.HeaderText = "";
            Column4.Name = "Column4";
            Column4.Text = "Delete";
            Column4.Width = 21;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(guna2CircleButton1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges5;
            guna2GradientPanel1.Dock = DockStyle.Top;
            guna2GradientPanel1.FillColor = Color.DarkKhaki;
            guna2GradientPanel1.FillColor2 = Color.Ivory;
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientPanel1.Size = new Size(800, 32);
            guna2GradientPanel1.TabIndex = 1;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Olive;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(769, 3);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(28, 26);
            guna2CircleButton1.TabIndex = 0;
            guna2CircleButton1.Text = "X";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "facebook.png");
            imageList1.Images.SetKeyName(1, "instagram.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 100);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Create Blogs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 143);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "URL";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(47, 171);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(292, 23);
            txtURL.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(47, 212);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtURL);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(dgBLogs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgBLogs).EndInit();
            guna2GradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgBLogs;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewComboBoxColumn Column5;
        private DataGridViewButtonColumn Column4;
        private ImageList imageList1;
        private Button btnAdd;
        private TextBox txtURL;
        private Label label2;
        private Label label1;
    }
}
