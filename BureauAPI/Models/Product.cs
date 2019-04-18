using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BureauAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategorieType { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }
    }
}
