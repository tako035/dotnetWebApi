using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace shopEntities.Concrete
{
    public class Product: IEntity
    {
        
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Desc { get; set; }

        public string? Sku { get; set; }

        public string? Slug { get; set; }

        public decimal Price { get; set; }

        public string? Image { get; set; }

        public string? Thumbnail { get; set; }

        public int Category_id { get; set; }

        public DateTime Created_at { get; set; }

        public DateTime Updated_at { get; set; }
    }


}

