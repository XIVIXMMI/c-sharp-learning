namespace web_mvc
{
    public class ProductService : List<ProductModel>
    {
        public ProductService(){
            this.AddRange(new ProductModel[]{
                new ProductModel() {Id = 1, Name = "Iphone",Price = 899},
                new ProductModel() {Id = 2, Name = "Macbook", Price = 1499},
                new ProductModel() {Id = 3, Name = "Ipad", Price = 499},
                new ProductModel() {Id = 4, Name = "Watch", Price = 499},
            });
        }
    }
}