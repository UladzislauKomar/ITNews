using System;
using System.Collections.Generic;
using System.Text;

namespace ITNews.Data.Contracts.Entities
{
    public class NewsTagEntity
    {
        public string NewsTagId { get; set; }

        public string NewsId { get; set; }
        public NewsEntity News { get; set; }

        public string TagId { get; set; }
        public TagEntity Tag { get; set; }
    }
}
