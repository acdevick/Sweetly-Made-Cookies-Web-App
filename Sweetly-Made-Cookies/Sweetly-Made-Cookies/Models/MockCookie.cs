using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SweetlyMadeCookies.Models
{
    public class MockCookie : ICookie
    {
        private readonly ICategory _category = new MockCategory();

        public IEnumerable<Cookie> Cookies
        {
            get
            {
                return  new List<Cookie>()
                {
                    new Cookie() { CookieId = 1, Name = "Bull Dog", ShortDescription = "Bull Dog Cookie", LongDescription = "Van Meter's Mascot Bull Dog sugar cookie", Price = 2.50m}
                };
            }
        }
    }
}
