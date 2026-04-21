using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class BlogCard : UserControl
    {
        public BlogCard(Domain.ViewModels.BlogVM blog)
        {
            InitializeComponent();

            LoadBlog(blog);
        }

        private void LoadBlog(Domain.ViewModels.BlogVM blog)
        {
            Id.Text = $"I.D.: {blog.BlogId.ToString()}";
            URL.Text = $"URL: {blog.Url}";
            listBoxPosts.Items.Add(blog.PostTitles);
        }
    }
}
