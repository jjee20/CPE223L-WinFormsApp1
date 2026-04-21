using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class CustomButton : Button
    {
            public CustomButton()
            {
                this.BackColor = Color.LightBlue;
                this.FlatStyle = FlatStyle.Flat;
                this.FlatAppearance.BorderSize = 0;
                this.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                this.ForeColor = Color.White;
                this.Padding = new Padding(10, 5, 10, 5);
                this.AutoEllipsis = true;
        }
    }
}
