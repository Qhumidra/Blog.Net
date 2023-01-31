using Blog.Net.Core.Entities.Abstract;

namespace Blog.Net.Entities.Concrete
{
    public class Comment : MongoDbEntity
    {
        public string PostId { get; set; }
        public string Text { get; set; }
        public int Rate { get; set; }
        public string UserId { get; set; }
    }
}
