﻿using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Collections.Generic;

namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {

        private EfDbContext context = new EfDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}