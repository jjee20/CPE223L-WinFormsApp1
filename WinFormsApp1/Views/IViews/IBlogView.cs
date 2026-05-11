using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Domain.Models;

namespace WinFormsApp1.Views.IViews
{
    public interface IBlogView
    {
        string Url { get; set; } // txtUrl.Text
        void DisplayBlogs(List<Blog> blogs);
        event EventHandler CreateBlogClicked;
    }
}
