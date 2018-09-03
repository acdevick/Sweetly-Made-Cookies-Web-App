using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace SweetlyMadeCookies.Models
{
    public interface ICookie
    {
        IEnumerable<Cookie> Cookies { get; }
        IEnumerable<Cookie> CookiesOnSale { get; }
        Cookie GetCookieById(int CookieId);
    }

    public class Cookie
    {
        public int CookieId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
