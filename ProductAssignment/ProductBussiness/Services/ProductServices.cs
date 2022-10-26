using ProductData;
using ProductData.Repository;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;


namespace ProductBussiness.Services
{
    public class ProductServices
    {
      ProductDbContext _db;
        IProductRepo _productRepo;
      
        public ProductServices(IProductRepo productRepository, ProductDbContext productDbContext)
        {
            _productRepo = productRepository;
          _db = productDbContext;
        }
        public void AddProduct(Product product)
        {
            //_productRepo.AddProduct(product);
            string productCode = string.Empty;
            _productRepo.GenerateProductCode(product, out productCode);

            product.ProductCode = productCode;

            _db.products.Add(product);

                 _db.SaveChangesAsync();

                ///*- Send ProductCreatedEvent to notify other teams(Implementation and destionation is up to you) */
                //string productString = JsonSerializer.Serialize(product);

                //await Notify(productString);

                //return CreatedAtAction("PostProduct", new { id = product.ProductId }, newProduct);

           
        }
        public void UpdateProduct(Product product)
        {
            _productRepo.UpdateProduct(product);
        }
        public void DeleteProduct(int productId)
        {
            _productRepo.DeleteProduct(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepo.GetProducts();
        }
        public Product GetProductByid(int productId)
        {
            return _productRepo.GetProductById(productId);
        }
    }
}
