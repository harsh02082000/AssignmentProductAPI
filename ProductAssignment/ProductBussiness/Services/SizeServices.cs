using ProductData.Repository;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBussiness.Services
{
    public class SizeServices
    {
        ISizeRepo _sizeRepo;
        public SizeServices(ISizeRepo sizeRepository)
        {
            _sizeRepo = sizeRepository;
        }
        public void AddSize(Sizes size)
        {
            _sizeRepo.AddSize(size);
        }
        public void UpdateSize(Sizes size)
        {
            _sizeRepo.UpdateSize(size);
        }
        public void DeleteSize(int sizeId)
        {
            _sizeRepo.DeleteSize(sizeId);
        }

        public IEnumerable<Sizes> GetSizes()
        {
            return _sizeRepo.GetSizes();
        }
        public Sizes GetSizeByid(int sizeId)
        {
            return _sizeRepo.GetSizeById(sizeId);
        }
    }
}
