using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITNews.Domain.Contracts.ViewModels
{
    public class SectionViewModel
    {
        [Key]
        public string SectionId { get; set; }
        public string Name { get; set; }
        
        public IEnumerable<NewsViewModel> News { get; set; }
    }
}