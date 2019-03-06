using ITNews.Data.Contracts.Entities;
using ITNews.Data.Contracts.Repositories;
using ITNews.Data.Implementation.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITNews.Data.Implementation.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ITNewsDbContext context;

        public UserRepository(ITNewsDbContext context)
        {
            this.context = context;
        }

        public UserEntity Create(UserEntity entity)
        {
            context.Users.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete(UserEntity entity)
        {
            var entry = context.Entry(entity);
            entry.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public IEnumerable<UserEntity> Read()
        {
            var output = context.Set<UserEntity>()
                .Include(x => x.News)
                .Include(x => x.Comments)
                .Include(x => x.Ratings)
                .Include(x => x.Likes)
                .AsEnumerable();
            return output;
        }

        public UserEntity Read(UserEntity entity)
        {
            var output = context.Set<UserEntity>()
                .Include(x => x.News)
                .Include(x => x.Comments)
                .Include(x => x.Ratings)
                .Include(x => x.Likes)
                .Single(x => x.UserName == entity.UserName || x.Id == entity.Id);
            return output;
        }

        public void Update(UserEntity entity)
        {
            var entry = context.Entry(entity);
            entry.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
