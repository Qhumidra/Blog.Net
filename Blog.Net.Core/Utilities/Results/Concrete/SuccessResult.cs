using Blog.Net.Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Net.Core.Utilities.Result.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message): base(true)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
