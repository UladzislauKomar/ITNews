using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITNews.Data.Contracts.Entities
{
    public class SectionEntity
    {
        [Key]
        public string SectionId { get; set; }
        public string Name { get; set; }

        public IEnumerable<NewsEntity> News { get; set; }
    }
}