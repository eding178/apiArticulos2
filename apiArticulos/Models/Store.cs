using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiArticulos.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Article> articles { get; set; }
    }
}
