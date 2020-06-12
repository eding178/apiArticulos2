using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiArticulos.Models
{
    public class Article
    {      
        public int Id { get; set; }
        public string Name { get; set; }
        public float price { get; set; }
        public string units { get; set; }
        public int storeId { get; set; }
        public Store store { get; set; }
    }
}
