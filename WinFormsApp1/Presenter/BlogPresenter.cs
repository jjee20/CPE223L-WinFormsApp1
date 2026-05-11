using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Domain.Models;
using WinFormsApp1.Infastructure.Data;
using WinFormsApp1.Services.IServices;
using WinFormsApp1.Views.IViews;

namespace WinFormsApp1.Presenter
{
    public class BlogPresenter
    {
        private IBlogView _view;
        private IBlogService _blogService;
        private List<Blog> _blogs = [];
        private readonly AppDbContext _appDbContext;
        public BlogPresenter(IBlogView view)
        {
            _view = view;
            _appDbContext = new AppDbContext();
            _blogService = new BlogService(_appDbContext);

            _view.CreateBlogClicked += OnCreateBlogClicked;

            LoadBlogs();
        }

        private async void LoadBlogs()
        {
            var entities = await _blogService.ReadAllAsync();
            _blogs = entities.ToList();
            _view.DisplayBlogs(_blogs);
        }

        private async void OnCreateBlogClicked(object? sender, EventArgs e)
        {
            var blog = new Blog
            {
                Url = _view.Url
            };

            await _blogService.CreateAsync(blog);
            await _blogService.SaveAsync();
            MessageBox.Show("Blog created successfully!");
            LoadBlogs();
        }
    }
}
