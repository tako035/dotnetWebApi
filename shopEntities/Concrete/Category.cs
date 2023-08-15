using System;
using Core.Entities;

namespace shopEntities.Concrete
{
    public class Category: IEntity
    {

            public int id { get; set; }

            public string? name { get; set; }

            public string? desc { get; set; }

            public string? slug { get; set; }

            public bool menuactive { get; set; }

            public DateTime created_at { get; set; }

            public DateTime updated_at { get; set; }
    }
}

