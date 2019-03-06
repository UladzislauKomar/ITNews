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
    public class CommentRepository : ICommentRepository
    {
        private readonly ITNewsDbContext context;

        public CommentRepository(ITNewsDbContext context)
        {
            this.context = context;
        }

        public CommentEntity Create(CommentEntity entity)
        {
            context.Comments.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete(CommentEntity entity)
        {
            context.Comments.Attach(entity);
            context.Comments.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<CommentEntity> Read()
        {
            var output = context.Set<CommentEntity>()
                .Include(x => x.User)
                .Include(x => x.News)
                .Include(x => x.Likes)
                .AsEnumerable();
            return output;
        }

        public CommentEntity Read(CommentEntity entity)
        {
            var output = context.Set<CommentEntity>()
                .Include(x => x.User)
                .Include(x => x.News)
                .Include(x => x.Likes)
                .Single(x => x.CommentId == entity.CommentId);
            return output;
        }

        public void Update(CommentEntity entity)
        {
            context.Comments.Attach(entity);
            var entry = context.Entry(entity);
            entry.Property(e => e.Content).IsModified = true;
            context.SaveChanges();
        }
    }
}
