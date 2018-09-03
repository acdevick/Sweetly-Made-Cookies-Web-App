using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SweetlyMadeCookies.Models
{
    public interface ICategory
    {
        IEnumerable<Category> Categories { get; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string  Description { get; set; }
        public List<Cookie> Cookies { get; set; }

    }
}
