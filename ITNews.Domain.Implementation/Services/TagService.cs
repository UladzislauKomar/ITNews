using AutoMapper;
using ITNews.Data.Contracts.Entities;
using ITNews.Data.Contracts.Repositories;
using ITNews.Domain.Contracts.Services;
using ITNews.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITNews.Domain.Implementation.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository repository;
        private readonly IMapper mapper;

        public TagService(ITagRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public TagViewModel CreateTag(TagViewModel model)
        {
            var entity = mapper.Map<TagViewModel, TagEntity>(model);
            var outputEntity = repository.Create(entity);
            var output = mapper.Map<TagEntity, TagViewModel>(outputEntity);
            return output;
        }

        public IEnumerable<TagViewModel> GetTags()
        {
            var entities = repository.Read();
            var models = mapper.Map<IEnumerable<TagEntity>, IEnumerable<TagViewModel>>(entities);
            return models;
        }
    }
}
