using System;
using System.Collections.Generic;
using System.Text;

namespace RssPresentor.Model.Entities
{
    public class ArticleCategory:IEntityBase
    {
        public string Id { get; set; }
        public string ArticleId { get; set; }
        public Article Article { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
