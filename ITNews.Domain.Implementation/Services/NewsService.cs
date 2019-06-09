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
    public class NewsService : INewsService
    {
        private readonly INewsRepository repository;
        private readonly IMapper mapper;

        public NewsService(INewsRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public bool Delete(NewsViewModel model)
        {
            var result = false;
            var entity = mapper.Map<NewsViewModel, NewsEntity>(model);
            try
            {
                repository.Delete(entity);
                result = true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return result;
        }

        public bool Edit(NewsViewModel model)
        {
            var entity = repository.Read().FirstOrDefault(x => x.NewsId == model.NewsId);
            var result = false;
            mapper.Map<NewsViewModel, NewsEntity>(model, entity);
            try
            {
                repository.Update(entity);
                result = true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return result;
        }

        public IEnumerable<NewsViewModel> GetNewsByUser(UserViewModel model)
        {
            var entitiesList = repository.Read().Where(x => x.UserId == model.Id);
            var modelList = mapper.Map<IEnumerable<NewsEntity>, IEnumerable<NewsViewModel>>(entitiesList);
            return modelList;
        }

        public NewsViewModel GetNewsDetails(NewsViewModel model)
        {
            var entity = mapper.Map<NewsViewModel, NewsEntity>(model);
            var outputEntity = repository.Read(entity);
            var outputModel = mapper.Map<NewsEntity, NewsViewModel>(outputEntity);
            return outputModel;
        }

        public NewsViewModel GetNewsDetails(string newsId)
        {
            var outputEntity = repository.Read().Single(x => x.NewsId == newsId);
            var outputModel = mapper.Map<NewsEntity, NewsViewModel>(outputEntity);
            return outputModel;
        }

        public IEnumerable<NewsViewModel> GetNewsList()
        {
            var entitiesList = repository.Read();
            var modelList = mapper.Map<IEnumerable<NewsEntity>, IEnumerable<NewsViewModel>>(entitiesList);
            return modelList;
        }

        public NewsViewModel Post(NewsViewModel model)
        {
            var entity = mapper.Map<NewsViewModel, NewsEntity>(model);
            entity.Description = model.Description;
            entity.UserId = model.UserId;
            entity.Section = mapper.Map<SectionViewModel, SectionEntity>(model.Section);
            entity.Created = DateTime.Now;
            var outputEntity = repository.Create(entity);
            var outputModel = mapper.Map<NewsEntity, NewsViewModel>(outputEntity);
            return outputModel;
        }
    }
}
