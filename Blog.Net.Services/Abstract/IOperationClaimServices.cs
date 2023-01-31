using Blog.Net.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Net.Services.Abstract
{
    public interface IOperationClaimServices
    {
        public OperationClaim Add(OperationClaim operationClaim);
        public List<OperationClaim> GetByUserId(string userId);
    }
}
