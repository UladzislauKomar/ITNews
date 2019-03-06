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
    public class NewsRatingService : INewsRatingService
    {
        private readonly INewsRatingRepository repository;
        private readonly IMapper mapper;

        public NewsRatingService(INewsRatingRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public IEnumerable<NewsRatingViewModel> GetRatingByNews(NewsViewModel model)
        {
            var entities = repository.Read().Where(x => x.NewsId == model.NewsId);
            var models = mapper.Map<IEnumerable<NewsRatingEntity>, IEnumerable<NewsRatingViewModel>>(entities);
            return models;
        }

        public IEnumerable<NewsRatingViewModel> GetRatingByUser(UserViewModel model)
        {
            var entities = repository.Read().Where(x => x.UserId == model.Id);
            var models = mapper.Map<IEnumerable<NewsRatingEntity>, IEnumerable<NewsRatingViewModel>>(entities);
            return models;
        }

        public NewsRatingViewModel Rate(NewsRatingViewModel model)
        {
            var entity = mapper.Map<NewsRatingViewModel, NewsRatingEntity>(model);
            var outputEntity = repository.Create(entity);
            var outputModel = mapper.Map<NewsRatingEntity, NewsRatingViewModel>(outputEntity);
            return outputModel;
        }
    }
}
