using System;
using Core.Entities;

namespace shopEntities.Concrete
{
    public class ProductPictures : IEntity
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public int ProductId { get; set; }
    }
}

