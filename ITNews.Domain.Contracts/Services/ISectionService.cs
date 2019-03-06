using ITNews.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITNews.Domain.Contracts.Services
{
    public interface ISectionService
    {
        SectionViewModel CreateSection(SectionViewModel model);
        IEnumerable<SectionViewModel> GetSections();
    }
}
