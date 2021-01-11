using System;
using System.Collections.Generic;
using System.Text;

namespace RssPresentor.Model.Entities
{
    public class Comment:IEntityBase
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsApproved { get; set; }
        public Article Article { get; set; }
        public int ParentId { get; set; }
        public string UserName { get; set; }
    }
}
