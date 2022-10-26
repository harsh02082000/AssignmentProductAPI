using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Repository
{
    public interface IProductRepo
    {
        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int productId);

        Product GetProductById(int productId);
        IEnumerable<Product> GetProducts();
        void GenerateProductCode(Product product, out string productCode);

    }
}
