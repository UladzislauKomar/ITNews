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
    public class SectionRepository : ISectionRepository
    {
        private readonly ITNewsDbContext context;

        public SectionRepository(ITNewsDbContext context)
        {
            this.context = context;
        }

        public SectionEntity Create(SectionEntity entity)
        {
            context.Sections.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete(SectionEntity entity)
        {
            context.Sections.Attach(entity);
            context.Sections.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<SectionEntity> Read()
        {
            var output = context.Set<SectionEntity>()
                .Include(x => x.News)
                .AsEnumerable();
            return output;
        }

        public SectionEntity Read(SectionEntity entity)
        {
            var output = context.Set<SectionEntity>()
                .Include(x => x.News)
                .Single(x => x.SectionId == entity.SectionId || x.Name == entity.Name);
            return output;
        }

        public void Update(SectionEntity entity)
        {
            context.Sections.Attach(entity);
            var entry = context.Entry(entity);
            entry.Property(e => e.Name).IsModified = true;
            context.SaveChanges();
        }
    }
}
