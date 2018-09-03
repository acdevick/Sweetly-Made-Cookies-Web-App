using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SweetlyMadeCookies.Models
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>()
                {
                    new Category(){CategoryId = 1, CategoryName = "Van Meter Homecoming", Description = "Homecoming cookdies"},
                    new Category(){CategoryId = 2,CategoryName = "Shelby's Wedding", Description = "Up Theme Cookies"},
                    new Category(){CategoryId = 3, CategoryName = "Halloween Cookies", Description = "Bat, Pumpkin cookies"}
                };

            }
        }
    }
}
