using ITNews.Domain.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITNews.Domain.Contracts.Services
{
    public interface INewsParserService
    {
        IEnumerable<NewsViewModel> ParseNews();
    }
}
