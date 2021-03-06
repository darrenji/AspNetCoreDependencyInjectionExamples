﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjectionExamples.Models
{
    public class MemoryRepository : IRepository
    {
        private IModelStorage storage;

        public MemoryRepository(IModelStorage modelStore)
        {
            storage = modelStore;

            new List<Product>
            {
                new Product {Name="Kayak", Price=275M },
                new Product {Name="Lifejacket", Price=48.95M },
                new Product {Name="Social ball", Price=19.50M }
            }.ForEach(p => AddProduct(p));
        }
        public Product this[string name]
        {
            get
            {
                return storage[name];
            }
        }

        public IEnumerable<Product> Products
        {
            get
            {
                return storage.Items;
            }
        }

        public void AddProduct(Product product)
        {
            storage[product.Name] = product;
        }

        public void DeleteProduct(Product product)
        {
            storage.RemoveItem(product.Name);
        }
    }
}
