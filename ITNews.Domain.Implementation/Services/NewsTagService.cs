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
    public class NewsTagService : INewsTagService
    {
        private readonly INewsTagRepository repository;
        private readonly ITagRepository tagRepository;
        private readonly IMapper mapper;

        public NewsTagService(INewsTagRepository repository, ITagRepository tagRepository, IMapper mapper)
        {
            this.repository = repository;
            this.tagRepository = tagRepository;
            this.mapper = mapper;
        }

        public IEnumerable<NewsViewModel> GetNewsByTag(TagViewModel model)
        {
            var entities = repository.Read().Where(x => x.TagId == model.TagId);
            var models = mapper.Map<IEnumerable<NewsTagEntity>, IEnumerable<NewsTagViewModel>>(entities);
            var outputModels = models.Select(x => x.News);
            return outputModels;
        }

        public IEnumerable<TagViewModel> GetTagsByNews(NewsViewModel model)
        {
            var entities = repository.Read().Where(x => x.NewsId == model.NewsId);
            var models = mapper.Map<IEnumerable<NewsTagEntity>, IEnumerable<NewsTagViewModel>>(entities);
            var outputModels = models.Select(x => x.Tag);
            return outputModels;
        }

        public void SetTags(string newsId, IEnumerable<string> tags)
        {
            foreach (var tag in tags)
            {
                var tagEntity = tagRepository.Read().SingleOrDefault(x => x.Name == tag.Trim());
                if (tagEntity == null)
                {
                    tagEntity = new TagEntity()
                    {
                        Name = tag.Trim()
                    };
                    tagEntity = tagRepository.Create(tagEntity);
                }
                var entity = new NewsTagEntity()
                {
                    News = new NewsEntity()
                    {
                        NewsId = newsId,
                        Tags = new List<NewsTagEntity>()
                    },
                    Tag = new TagEntity()
                    {
                        TagId = tagEntity.TagId,
                        News = new List<NewsTagEntity>()
                    }
                };
                repository.Create(entity);
            }

            
        }
    }
}
