using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Domain.Models;
using WinFormsApp1.Infastructure.Data;
using WinFormsApp1.Infastructure.Repositories;

namespace WinFormsApp1.Services.IServices
{
    public class BlogService : Repository<Blog>, IBlogService
    {
        private readonly AppDbContext _appDbContext;

        public BlogService(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Update(Blog entity)
        {
            _appDbContext.Update(entity);
        }
    }

    public interface IBlogService : IRepository<Blog>
    {
        void Update(Blog entity);
    }
}
