using System.Collections.Generic;
using souq.Models;

namespace souq.Models
{
    public class SearchVM
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public string Query { get; set; }
    }
}
