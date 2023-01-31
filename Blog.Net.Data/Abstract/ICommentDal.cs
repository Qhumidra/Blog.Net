using Blog.Net.Core.Data.Abstract;
using Blog.Net.Entities.Concrete;
using System.Collections.Generic;

namespace Blog.Net.Data.Abstract
{
    public interface ICommentDal : IRepository<Comment>
    {
        public List<Comment> GetByPostId(string id);
    }

}
