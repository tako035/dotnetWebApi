using System;
using Core.Entities;

namespace shopEntities.Concrete
{
    public class ProductSpecs : IEntity
    {
        public int Id { get; set; }

        public string? Spec { get; set; }

        public string? Desc { get; set; }

        public int Product_id { get; set; }

        public DateTime Created_at { get; set; }

        public DateTime Updated_at { get; set; }
    }
}

