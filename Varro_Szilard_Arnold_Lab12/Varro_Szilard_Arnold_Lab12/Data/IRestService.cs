
using System.Collections.Generic;
using System.Threading.Tasks;
using Varro_Szilard_Arnold_Lab12.Models;

namespace Varro_Szilard_Arnold_Lab12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
