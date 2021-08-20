using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
using BH.DataLayerSql;

namespace BH.BusinessLayer
{
    public class ProductManager
    {
        //product categories
        public static List<ProductCategoriesModel> GetAllProductCategories()
        {
            SqlProductCategoriesProvider provider = new SqlProductCategoriesProvider();
            return provider.GetAllProductCategories();
        }

        public static ProductCategoriesModel GetProductCategoriesById(long Id)
        {
            SqlProductCategoriesProvider provider = new SqlProductCategoriesProvider();
            return provider.GetProductCategoriesById(Id);
        }

        public static long InsertProductCategories(ProductCategoriesModel Productcategories)
        {
            SqlProductCategoriesProvider provider = new SqlProductCategoriesProvider();
            return provider.InsertProductCategories(Productcategories);
        }

        public static bool UpdateProductCategories(ProductCategoriesModel productcategories)
        {
            SqlProductCategoriesProvider provider = new SqlProductCategoriesProvider();
            return provider.UpdateProductCategories(productcategories);
        }


        public static bool DeleteProductCategories(long Id)
        {
            SqlProductCategoriesProvider provider = new SqlProductCategoriesProvider();
            return provider.DeleteProductCategories(Id);
        }
        
        //product sub categoriers
        public static List<ProductSubCategoriesModel> GetAllProductSubCategories()
        {
            SqlProducSubCategoriesProvider provider = new SqlProducSubCategoriesProvider();
            return provider.GetAllProductSubCategories();
        }

        public static ProductSubCategoriesModel GetProductSubCategoriesById(long Id)
        {
            SqlProducSubCategoriesProvider provider = new SqlProducSubCategoriesProvider();
            return provider.GetProductSubCategoriesById(Id);
        }

        public static long InsertProjectSubCategory(ProductSubCategoriesModel Productsubcategories)
        {
            SqlProducSubCategoriesProvider provider = new SqlProducSubCategoriesProvider();
            return provider.InsertProjectSubCategory(Productsubcategories);
        }

        public static bool UpdateProjectSubCategory(ProductSubCategoriesModel productsubcategories)
        {
            SqlProducSubCategoriesProvider provider = new SqlProducSubCategoriesProvider();
            return provider.UpdateProjectSubCategory(productsubcategories);
        }


        public static bool DeleteProjectSubCategory(long Id)
        {
            SqlProducSubCategoriesProvider provider = new SqlProducSubCategoriesProvider();
            return provider.DeleteProjectSubCategory(Id);
        }

    
        //product type
        public static List<ProductTypeModel> GetAllProductType()
        {
            SqlProductTypeProvider provider = new SqlProductTypeProvider();
            return provider.GetAllProductType();
        }

        public static ProductTypeModel GetProductTypeById(long Id)
        {
            SqlProductTypeProvider provider = new SqlProductTypeProvider();
            return provider.GetProductTypeById(Id);
        }

        public static long InsertProductType(ProductTypeModel Producttype)
        {
            SqlProductTypeProvider provider = new SqlProductTypeProvider();
            return provider.InsertProductType(Producttype);
        }

        public static bool UpdateProductType(ProductTypeModel producttype)
        {
            SqlProductTypeProvider provider = new SqlProductTypeProvider();
            return provider.UpdateProductType(producttype);
        }


        public static bool DeleteProductType(long Id)
        {
            SqlProductTypeProvider provider = new SqlProductTypeProvider();
            return provider.DeleteProductType(Id);
        }

        //Product Gallery
        public static List<ProductGalleryModel> GetAllProductGallery()
        {
            SqlProductGalleryProvider provider = new SqlProductGalleryProvider();
            return provider.GetAllProductGallery();
        }

        public static ProductGalleryModel GetProductGalleryById(long Id)
        {
            SqlProductGalleryProvider provider = new SqlProductGalleryProvider();
            return provider.GetProductGalleryById(Id);
        }

        public static long InsertProductGallery(ProductGalleryModel Productgallery)
        {
            SqlProductGalleryProvider provider = new SqlProductGalleryProvider();
            return provider.InsertProductGallery(Productgallery);
        }

        public static bool UpdateProductGallery(ProductGalleryModel productgallery)
        {
            SqlProductGalleryProvider provider = new SqlProductGalleryProvider();
            return provider.UpdateProductGallery(productgallery);
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
