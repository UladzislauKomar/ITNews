using AutoMapper;
using ITNews.Data.Contracts.Entities;
using ITNews.Data.Contracts.Repositories;
using ITNews.Domain.Contracts.Services;
using ITNews.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITNews.Domain.Implementation.Services
{
    public class CommentLikeService : ICommentLikeService
    {
        private readonly ICommentLikeRepository repository;
        private readonly IMapper mapper;

        public CommentLikeService(ICommentLikeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public IEnumerable<CommentLikeViewModel> GetLikesByComment(CommentViewModel model)
        {
            var entities = repository.Read().Where(x => x.CommentId == model.CommentId);
            var models = mapper.Map<IEnumerable<CommentLikeEntity>, IEnumerable<CommentLikeViewModel>>(entities);
            return models;
        }

        public IEnumerable<CommentLikeViewModel> GetLikesByUser(UserViewModel model)
        {
            var entities = repository.Read().Where(x => x.UserId == model.Id);
            var models = mapper.Map<IEnumerable<CommentLikeEntity>, IEnumerable<CommentLikeViewModel>>(entities);
            return models;
        }

        public IEnumerable<CommentLikeViewModel> GetLikes()
        {
            var entities = repository.Read();
            var models = mapper.Map<IEnumerable<CommentLikeEntity>, IEnumerable<CommentLikeViewModel>>(entities);
            return models;
        }

        public CommentLikeViewModel Like(CommentLikeViewModel model)
        {
            var entity = mapper.Map<CommentLikeViewModel, CommentLikeEntity>(model);
            var outputEntity = repository.Create(entity);
            var outputModel = mapper.Map<CommentLikeEntity, CommentLikeViewModel>(outputEntity);
            return outputModel;
        }

        public void Unlike(CommentLikeViewModel model)
        {
            var entity = mapper.Map<CommentLikeViewModel, CommentLikeEntity>(model);
            try
            {
                repository.Delete(entity);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
