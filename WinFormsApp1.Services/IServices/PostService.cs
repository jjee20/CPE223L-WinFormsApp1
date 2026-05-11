using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Domain.Models;
using WinFormsApp1.Infastructure.Data;
using WinFormsApp1.Infastructure.Repositories;

namespace WinFormsApp1.Services.IServices
{
    public class PostService : Repository<Post>, IPostService
    {
        private readonly AppDbContext _appDbContext;

        public PostService(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Update(Post entity)
        {
            _appDbContext.Update(entity);
        }
    }

    public interface IPostService : IRepository<Post>
    {
        void Update(Post entity);
    }
}
