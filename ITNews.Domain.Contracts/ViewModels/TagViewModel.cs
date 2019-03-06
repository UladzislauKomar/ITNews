using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITNews.Domain.Contracts.ViewModels
{
    public class TagViewModel
    {
        [Key]
        public string TagId { get; set; }
        public string Name { get; set; }

        public IEnumerable<NewsTagViewModel> News { get; set; }
    }
}