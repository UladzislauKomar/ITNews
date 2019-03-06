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
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository repository;
        private readonly IMapper mapper;

        public SectionService(ISectionRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public SectionViewModel CreateSection(SectionViewModel model)
        {
            var entity = mapper.Map<SectionViewModel, SectionEntity>(model);
            var outputEntity = repository.Create(entity);
            var output = mapper.Map<SectionEntity, SectionViewModel>(outputEntity);
            return output;
        }

        public IEnumerable<SectionViewModel> GetSections()
        {
            var entities = repository.Read();
            var models = mapper.Map<IEnumerable<SectionEntity>, IEnumerable<SectionViewModel>>(entities);
            return models;
        }
    }
}
