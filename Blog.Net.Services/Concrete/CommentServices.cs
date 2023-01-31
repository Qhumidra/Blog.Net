using Blog.Net.Core.Aspects.Autofac.Validation;
using Blog.Net.Data.Abstract;
using Blog.Net.Entities.Concrete;
using Blog.Net.Services.Abstract;
using Blog.Net.Services.BusinessAspects.Autofac;
using Blog.Net.Services.Validation.FluentValidation;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Net.Services.Concrete
{
    public class CommentServices : ICommentServices
    {
        ICommentDal _commentDal;

        public CommentServices(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        [SecuredOperation("admin,user,writer")]
        [ValidationAspect(typeof(CommentValidator))]
        public Comment Add(Comment comment)
        {
            var result = _commentDal.Create(comment);

            return result;
        }

        [SecuredOperation("admin,user,writer")]
        public List<Comment> GetByPostId(string id)
        {
            var result = _commentDal.GetByPostId(id);
            return result;
        }

        [SecuredOperation("admin,user,writer")]
        public List<Comment> GetAll()
        {
            return _commentDal.GetAll().ToList();
        }

    }
}
