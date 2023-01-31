using Blog.Net.Core.Data.Abstract;
using Blog.Net.Core.Entities.Concrete;
using System.Collections.Generic;

namespace Blog.Net.Data.Abstract
{
    public interface IUserDal : IRepository<User>
    {
        public User GetByEmail(string email);
    }

}
