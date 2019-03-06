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
    public class CommentLikeRepository : ICommentLikeRepository
    {
        private readonly ITNewsDbContext context;

        public CommentLikeRepository(ITNewsDbContext context)
        {
            this.context = context;
        }

        public CommentLikeEntity Create(CommentLikeEntity entity)
        {
            context.CommentLikes.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete(CommentLikeEntity entity)
        {
            context.CommentLikes.Attach(entity);
            context.CommentLikes.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<CommentLikeEntity> Read()
        {
            var output = context.Set<CommentLikeEntity>()
                .Include(x => x.User)
                .Include(x => x.Comment)
                .AsEnumerable();
            return output;
        }

        public CommentLikeEntity Read(CommentLikeEntity entity)
        {
            var output = context.Set<CommentLikeEntity>()
                .Include(x => x.User)
                .Include(x => x.Comment)
                .Single(x => x.CommentLikeId == entity.CommentLikeId || (x.UserId == entity.UserId && x.CommentId == entity.CommentId));
            return output;
        }

        public void Update(CommentLikeEntity entity)
        {
            context.CommentLikes.Attach(entity);
            var entry = context.Entry(entity);
            entry.Property(e => e.CommentId).IsModified = true;
            entry.Property(e => e.UserId).IsModified = true;
            context.SaveChanges();
        }
    }
}
