namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            guna2RadialGauge1 = new Guna.UI2.WinForms.Guna2RadialGauge();
            guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(373, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(415, 389);
            dataGridView1.TabIndex = 0;
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
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(guna2CircleButton1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges19;
            guna2GradientPanel1.Dock = DockStyle.Top;
            guna2GradientPanel1.FillColor = Color.DarkKhaki;
            guna2GradientPanel1.FillColor2 = Color.Ivory;
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges20;
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
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(28, 26);
            guna2CircleButton1.TabIndex = 0;
            guna2CircleButton1.Text = "X";
            // 
            // guna2RatingStar1
            // 
            guna2RatingStar1.Location = new Point(72, 49);
            guna2RatingStar1.Name = "guna2RatingStar1";
            guna2RatingStar1.Size = new Size(120, 28);
            guna2RatingStar1.TabIndex = 2;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(36, 97);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(200, 10);
            guna2Separator1.TabIndex = 3;
            // 
            // guna2vSeparator1
            // 
            guna2vSeparator1.Location = new Point(36, 113);
            guna2vSeparator1.Name = "guna2vSeparator1";
            guna2vSeparator1.Size = new Size(10, 200);
            guna2vSeparator1.TabIndex = 4;
            // 
            // guna2ToggleSwitch1
            // 
            guna2ToggleSwitch1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ToggleSwitch1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2ToggleSwitch1.CheckedState.InnerBorderColor = Color.White;
            guna2ToggleSwitch1.CheckedState.InnerColor = Color.White;
            guna2ToggleSwitch1.CustomizableEdges = customizableEdges16;
            guna2ToggleSwitch1.Location = new Point(52, 113);
            guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            guna2ToggleSwitch1.ShadowDecoration.CustomizableEdges = customizableEdges17;
            guna2ToggleSwitch1.Size = new Size(35, 20);
            guna2ToggleSwitch1.TabIndex = 5;
            guna2ToggleSwitch1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2ToggleSwitch1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            guna2ToggleSwitch1.UncheckedState.InnerBorderColor = Color.White;
            guna2ToggleSwitch1.UncheckedState.InnerColor = Color.White;
            // 
            // guna2ProgressBar1
            // 
            guna2ProgressBar1.CustomizableEdges = customizableEdges14;
            guna2ProgressBar1.Location = new Point(52, 159);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges15;
            guna2ProgressBar1.Size = new Size(300, 30);
            guna2ProgressBar1.TabIndex = 7;
            guna2ProgressBar1.Text = "guna2ProgressBar1";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2RadialGauge1
            // 
            guna2RadialGauge1.Font = new Font("Verdana", 8.2F);
            guna2RadialGauge1.ForeColor = Color.FromArgb(139, 152, 166);
            guna2RadialGauge1.Location = new Point(52, 195);
            guna2RadialGauge1.MinimumSize = new Size(30, 30);
            guna2RadialGauge1.Name = "guna2RadialGauge1";
            guna2RadialGauge1.Size = new Size(240, 240);
            guna2RadialGauge1.TabIndex = 8;
            // 
            // guna2Shapes1
            // 
            guna2Shapes1.Location = new Point(167, 142);
            guna2Shapes1.Name = "guna2Shapes1";
            guna2Shapes1.PolygonSkip = 1;
            guna2Shapes1.Rotate = 0F;
            guna2Shapes1.RoundedEdges = customizableEdges13;
            guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            guna2Shapes1.Size = new Size(200, 200);
            guna2Shapes1.TabIndex = 9;
            guna2Shapes1.Text = "guna2Shapes1";
            guna2Shapes1.Zoom = 80;
            // 
            // guna2TrackBar1
            // 
            guna2TrackBar1.Location = new Point(36, 372);
            guna2TrackBar1.Name = "guna2TrackBar1";
            guna2TrackBar1.Size = new Size(300, 23);
            guna2TrackBar1.TabIndex = 10;
            guna2TrackBar1.ThumbColor = Color.FromArgb(160, 113, 255);
            // 
            // guna2WinProgressIndicator1
            // 
            guna2WinProgressIndicator1.Location = new Point(221, 133);
            guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            guna2WinProgressIndicator1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2WinProgressIndicator1.Size = new Size(104, 117);
            guna2WinProgressIndicator1.TabIndex = 11;
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = null;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            guna2MessageDialog1.Parent = this;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            guna2MessageDialog1.Text = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2WinProgressIndicator1);
            Controls.Add(guna2TrackBar1);
            Controls.Add(guna2Shapes1);
            Controls.Add(guna2RadialGauge1);
            Controls.Add(guna2ProgressBar1);
            Controls.Add(guna2ToggleSwitch1);
            Controls.Add(guna2vSeparator1);
            Controls.Add(guna2Separator1);
            Controls.Add(guna2RatingStar1);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            guna2GradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2RadialGauge guna2RadialGauge1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}
