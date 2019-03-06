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
    public class NewsTagRepository : INewsTagRepository
    {
        private readonly ITNewsDbContext context;

        public NewsTagRepository(ITNewsDbContext context)
        {
            this.context = context;
        }

        public NewsTagEntity Create(NewsTagEntity entity)
        {
            context.NewsTags.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete(NewsTagEntity entity)
        {
            context.NewsTags.Attach(entity);
            context.NewsTags.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<NewsTagEntity> Read()
        {
            var output = context.Set<NewsTagEntity>()
                .Include(x => x.News)
                .Include(x => x.Tag)
                .AsEnumerable();
            return output;
        }

        public NewsTagEntity Read(NewsTagEntity entity)
        {
            var output = context.Set<NewsTagEntity>()
                .Include(x => x.News)
                .Include(x => x.Tag)
                .Single(x => x.NewsTagId == entity.NewsTagId || (x.NewsId == entity.NewsId && x.TagId == entity.TagId));
            return output;
        }

        public void Update(NewsTagEntity entity)
        {
            context.NewsTags.Attach(entity);
            var entry = context.Entry(entity);
            entry.Property(e => e.NewsId).IsModified = true;
            entry.Property(e => e.TagId).IsModified = true;
            context.SaveChanges();
        }
    }
}
