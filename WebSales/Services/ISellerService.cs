using WebSales.Models;

namespace WebSales.Services
{
    public interface ISellerService
    {
        List<Seller> FindAll();
        void Insert(Seller seller);
    }
}
