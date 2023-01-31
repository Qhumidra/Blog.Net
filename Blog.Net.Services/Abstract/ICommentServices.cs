using Blog.Net.Entities.Concrete;
using System.Collections.Generic;

namespace Blog.Net.Services.Abstract
{
    public interface ICommentServices
    {
        public List<Comment> GetAll();
        public List<Comment> GetByPostId(string id);
        public Comment Add(Comment comment);
    }
}
