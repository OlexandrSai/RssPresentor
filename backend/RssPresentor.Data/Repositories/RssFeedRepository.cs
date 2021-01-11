using RssPresentor.Data.Abstract;
using RssPresentor.Model.Entities;

namespace RssPresentor.Data.Repositories
{
    public class RssFeedRepository : EntityBaseRepository<RssFeed>, IRssFeedRepository
    {
        public RssFeedRepository(RssPresentorContext context):base(context){}
    }
}
