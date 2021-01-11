using System;
using System.Collections.Generic;
using System.Text;

namespace RssPresentor.Model.Entities
{
    public class Upvote:IEntityBase
    {
        public string Id { get; set; }
        public string ArticleId { get; set; }
        public string UserName { get; set; }
        public bool IsUpvote { get; set; }
    }
}
