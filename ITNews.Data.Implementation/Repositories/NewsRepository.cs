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
    public class NewsRepository : INewsRepository
    {
        private readonly ITNewsDbContext context;

        public NewsRepository(ITNewsDbContext context)
        {
            this.context = context;
        }

        public NewsEntity Create(NewsEntity entity)
        {
            context.News.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete(NewsEntity entity)
        {
            context.News.Attach(entity);
            context.News.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<NewsEntity> Read()
        {
            var output = context.Set<NewsEntity>()
                .Include(x => x.Tags)
                .Include(x => x.Ratings)
                .Include(x => x.Comments)
                .Include(x => x.User)
                .Include(x => x.Section)
                .AsEnumerable();
            return output;
        }

        public NewsEntity Read(NewsEntity entity)
        {
            var output = context.Set<NewsEntity>()
                .Include(x => x.Tags)
                .Include(x => x.Ratings)
                .Include(x => x.Comments)
                .Include(x => x.User)
                .Include(x => x.Section)
                .Single(x => x.NewsId == entity.NewsId);
            return output;
        }

        public void Update(NewsEntity entity)
        {
            context.News.Attach(entity);
            var entry = context.Entry(entity);
            entry.Property(e => e.Content).IsModified = true;
            //entry.Property(e => e.Description).IsModified = true;
            entry.Property(e => e.Title).IsModified = true;
            context.SaveChanges();
        }
    }
}
