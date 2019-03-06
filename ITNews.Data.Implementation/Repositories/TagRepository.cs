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
    public class TagRepository : ITagRepository
    {
        private readonly ITNewsDbContext context;

        public TagRepository(ITNewsDbContext context)
        {
            this.context = context;
        }

        public TagEntity Create(TagEntity entity)
        {
            context.Tags.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete(TagEntity entity)
        {
            context.Tags.Attach(entity);
            context.Tags.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<TagEntity> Read()
        {
            var output = context.Set<TagEntity>()
                .Include(x => x.News)
                .AsEnumerable();
            return output;
        }

        public TagEntity Read(TagEntity entity)
        {
            var output = context.Set<TagEntity>()
                .Include(x => x.News)
                .Single(x => x.TagId == entity.TagId || x.Name == entity.Name);
            return output;
        }

        public void Update(TagEntity entity)
        {
            context.Tags.Attach(entity);
            var entry = context.Entry(entity);
            entry.Property(e => e.Name).IsModified = true;
            context.SaveChanges();
        }
    }
}
