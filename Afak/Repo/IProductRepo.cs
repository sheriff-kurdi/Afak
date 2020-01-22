using Afak.Models;
using Afak.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Afak.Repo
{
    public interface IProductRepo
    {

        void AddProduct(ProductCreateVM product);
        Product GetProductByID(int id);
        IEnumerable<Product> GetAllProducts();
        void Delete(Product pro);
        void Update(ProductCreateVM proToUpdate);
        IEnumerable<Product> GeOrthodonticsProducts();
        IEnumerable<Product> GetAirCompressorProducts();
        IEnumerable<Product> GetUnitProducts();
        IEnumerable<Product> GetSmallDeviceProducts();
        IEnumerable<Product> GetContraAccessoriesProducts();
        IEnumerable<Product> GetCompressorAccessoriesProducts();
    }
}
