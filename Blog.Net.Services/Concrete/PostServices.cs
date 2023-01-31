using Blog.Net.Core.Aspects.Autofac.Validation;
using Blog.Net.Data.Abstract;
using Blog.Net.Entities.Concrete;
using Blog.Net.Services.Abstract;
using Blog.Net.Services.BusinessAspects.Autofac;
using Blog.Net.Services.Validation.FluentValidation;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Net.Services.Concrete
{
    public class PostServices : IPostServices
    {
        IPostDal _postDal;

        public PostServices(IPostDal postDal)
        {
            _postDal = postDal;

        }

        [SecuredOperation("admin,writer")]
        [ValidationAspect(typeof(PostValidator))]
        public Post Add(Post post)
        {
            var result = _postDal.Create(post);

            return result;
        }

        [SecuredOperation("admin,user,writer")]
        public Post GetByTitle(string title)
        {
            var result = _postDal.GetByTitle(title);

            return result;
        }

        [SecuredOperation("admin")]
        public Post GetById(string id)
        {
            var result = _postDal.GetById(id);

            return result;
        }

        [SecuredOperation("admin,user,writer")]
        public List<Post> GetAll()
        {

            return _postDal.GetAll().ToList();
        }

    }
}
