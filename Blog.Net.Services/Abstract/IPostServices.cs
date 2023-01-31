using Blog.Net.Entities.Concrete;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Net.Services.Abstract
{
    public interface IPostServices
    {
        public List<Post> GetAll();
        public Post GetByTitle(string title);
        public Post GetById(string id);
        public Post Add(Post post);
    }
}
