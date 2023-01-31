using System;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Net.Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
