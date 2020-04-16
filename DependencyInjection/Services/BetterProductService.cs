using DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class BetterProductService : IProductService
    {
        public List<ProductViewModel> getAll()
        {
            return( new List<ProductViewModel>
            { new ProductViewModel {Id=1, Name="Telivision"},
            new ProductViewModel {Id=2, Name="Telephone"} });
        }
    }
}
