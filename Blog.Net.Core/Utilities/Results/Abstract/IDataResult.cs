using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Net.Core.Utilities.Result.Abstract
{
    public interface IDataResult<T> :IResult
    {
        public T Data { get; set; }
    }
}
