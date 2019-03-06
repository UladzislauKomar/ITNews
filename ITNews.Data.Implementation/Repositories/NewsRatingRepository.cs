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
    public class NewsRatingRepository : INewsRatingRepository
    {
        private readonly ITNewsDbContext context;

        public NewsRatingRepository(ITNewsDbContext context)
        {
            this.context = context;
        }

        public NewsRatingEntity Create(NewsRatingEntity entity)
        {
            context.NewsRatings.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete(NewsRatingEntity entity)
        {
            context.NewsRatings.Attach(entity);
            context.NewsRatings.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<NewsRatingEntity> Read()
        {
            var output = context.Set<NewsRatingEntity>()
                .Include(x => x.News)
                .Include(x => x.User)
                .AsEnumerable();
            return output;
        }

        public NewsRatingEntity Read(NewsRatingEntity entity)
        {
            var output = context.Set<NewsRatingEntity>()
                .Include(x => x.News)
                .Include(x => x.User)
                .Single(x => x.NewsRatingId == entity.NewsRatingId || (x.UserId == entity.UserId && x.NewsId == entity.NewsId));
            return output;
        }

        public void Update(NewsRatingEntity entity)
        {
            context.NewsRatings.Attach(entity);
            var entry = context.Entry(entity);
            entry.Property(e => e.Rating).IsModified = true;
            context.SaveChanges();
        }
    }
}
