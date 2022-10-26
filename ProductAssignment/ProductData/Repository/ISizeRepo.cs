using ProductEntity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ProductData.Repository
{
    public interface ISizeRepo
    {
        void AddSize(Sizes size);

        void UpdateSize(Sizes size);

        void DeleteSize(int sizeId);

        Sizes GetSizeById(int sizeId);
        IEnumerable<Sizes> GetSizes();
    }
}
