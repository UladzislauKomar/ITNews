using ITNews.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITNews.Domain.Contracts.Services
{
    public interface ITagService
    {
        TagViewModel CreateTag(TagViewModel model);
        IEnumerable<TagViewModel> GetTags();
    }
}
