using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Domain.ViewModels;
using WinFormsApp1.Infastructure.Data;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var blogs = context.Blogs.Include(b => b.Posts)
                                                    .Select(b => new BlogVM
                                                    {
                                                        BlogId = b.BlogId,
                                                        Url = b.Url,
                                                        PostTitles = string.Join(", ", b.Posts.Select(p => p.Title))
                                                    })
                                                    .ToList();

            foreach (var blog in blogs)
            {
                var blogCard = new BlogCard(blog);
                flowLayoutPanel1.Controls.Add(blogCard);
            }
        }
    }
}
