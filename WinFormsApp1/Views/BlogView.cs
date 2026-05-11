using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Domain.Models;
using WinFormsApp1.Domain.ViewModels;
using WinFormsApp1.Infastructure.Data;
using WinFormsApp1.Services.IServices;
using WinFormsApp1.Views.IViews;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class BlogView : Form, IBlogView
    {
        public BlogView()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Url { get => txtURL.Text.Trim(); set => txtURL.Text = value; }

        public event EventHandler CreateBlogClicked;

        public void DisplayBlogs(List<Blog> blogs)
        {
            dgBLogs.DataSource = blogs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateBlogClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
