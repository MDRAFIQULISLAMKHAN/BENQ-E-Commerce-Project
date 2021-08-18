using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
namespace BH.DataLayerSql
{
    public interface IProductGalleryProvider
    {
        List<ProductGalleryModel> GetAllProductGallery();
        ProductGalleryModel GetProductGalleryById(long Id);
        long InsertProductGallery(ProductGalleryModel Productgallery);
        bool UpdateProductGallery(ProductGalleryModel productgallery);
        bool DeleteProductGallery(long Id);
    }
}
