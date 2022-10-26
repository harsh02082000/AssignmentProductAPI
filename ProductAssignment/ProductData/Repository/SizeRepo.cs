using Microsoft.EntityFrameworkCore;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductData.Repository
{
    public class SizeRepo:ISizeRepo
    {
        ProductDbContext _productDbContext;
        public SizeRepo(ProductDbContext producDbContext)
        {
            _productDbContext = producDbContext;
        }
        public void AddSize(Sizes size)
        {
            _productDbContext.sizes.Add(size);
            _productDbContext.SaveChanges();
        }
        public void DeleteSize(int sizeId)
        {
            var size = _productDbContext.sizes.Find(sizeId);
            _productDbContext.sizes.Remove(size);
            _productDbContext.SaveChanges();
        }

        public IEnumerable<Sizes> GetSizes()
        {
            return _productDbContext.sizes.ToList();
        }
        public void UpdateSize(Sizes size)
        {
            _productDbContext.Entry(size).State = EntityState.Modified;
            _productDbContext.SaveChanges();
        }
        public Sizes GetSizeById(int sizeId)
        {
            return _productDbContext.sizes.Find(sizeId);
        }
    }
}
