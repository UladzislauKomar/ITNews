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
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository repository;
        private readonly IMapper mapper;

        public CommentService(ICommentRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public CommentViewModel Comment(CommentViewModel model)
        {
            var entity = mapper.Map<CommentViewModel, CommentEntity>(model);
            var outputEntity = repository.Create(entity);
            var output = mapper.Map<CommentEntity, CommentViewModel>(outputEntity);
            return output;
        }

        public IEnumerable<CommentViewModel> GetCommentsByNews(NewsViewModel model)
        {
            var entities = repository.Read().Where(x => x.NewsId == model.NewsId);
            var models = mapper.Map<IEnumerable<CommentEntity>, IEnumerable<CommentViewModel>>(entities);
            return models;
        }
    }
}
