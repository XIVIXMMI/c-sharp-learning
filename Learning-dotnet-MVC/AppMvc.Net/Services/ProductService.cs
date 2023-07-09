using AppMvc.Models;
using System.Collections.Generic;

namespace AppMvc.Services
{
    public class ProductService : List<ProductModel>
    {
        public ProductService(){
            this.AddRange(new ProductModel[] {
                new ProductModel() { Id = 1, Name = "Iphone 11", Price = 899.99},
                new ProductModel() { Id = 2, Name = "Macbook Air", Price = 989.99},
                new ProductModel() { Id = 3, Name = "Airpod",Price = 149.99},
                new ProductModel() { Id = 4, Name = "Ipad Gen 9", Price = 499.99}
            });
        }
    }
}