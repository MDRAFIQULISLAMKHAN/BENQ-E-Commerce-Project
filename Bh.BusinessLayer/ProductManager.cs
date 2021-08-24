using System;
using System.Collections.Generic;
using System.Linq;
using BH.DataLayerSql;
using BH.Models;

namespace BH.BusinessLayer
{
    public class ProductManager
    {
        public static List<ProductModel> GetProducts()
        {
            SqlProductProvider provider = new SqlProductProvider();

            return provider.GetAllProduct();
        }
        //product categories
        public static List<ProductCategoriesModel> GetAllProductCategories()
        {
            SqlProductCategoriesProvider provider = new SqlProductCategoriesProvider();
            return provider.GetAllProductCategories();
        }

        public static List<ProductGalleryModel>  GetProductGallery( long id)
        {
            SqlProductGalleryProvider provider = new SqlProductGalleryProvider();

            return provider.GetProductGalleryById(id);
        }
       
        public static bool DeleteProductGallery(long Id)
        {
            SqlProductGalleryProvider provider = new SqlProductGalleryProvider();
            return provider.DeleteProductGallery(Id);
        }

        //Product
        public static List<ProductModel> GetAllProduct()
        {
            SqlProductProvider provider = new SqlProductProvider();
            return provider.GetAllProduct();
        }

        public static ProductModel GetProductById(long Id)
        {
            SqlProductProvider provider = new SqlProductProvider();
            return provider.GetProductById(Id);
        }

        public static long InsertProduct(ProductModel Product)
        {
            SqlProductProvider provider = new SqlProductProvider();
            return provider.InsertProduct(Product);
        }

        public static bool UpdateProduct(ProductModel product)
        {
            SqlProductProvider provider = new SqlProductProvider();
            return provider.UpdateProduct(product);
        }


        public static bool DeleteProduct(long Id)
        {
            SqlProductProvider provider = new SqlProductProvider();
            return provider.DeleteProduct(Id);
        }
    }
}
    