using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project01_7735_5114_dotNet5780;

namespace DAL
{
    interface Idal
    {
        //guest request
        void AddGuestRequest(GuestRequest guest);
        void UpdateGuestRequest(GuestRequest guest);

        //hosting unit
        void AddHostingUnit(HostingUnit hostingUnit);
        void UpdateHostingUnit(HostingUnit hostingUnit);
        void DeleteHostingUnit(int key);

        //order
        void AddOrder(Order order);
        void UpdateOrder(Order order);

        //lists

        List<HostingUnit> GetAllHostingUnits();
        List<GuestRequest> GetAllGuestRequests();
        List<Order> GetAllOrders();

        List<BankBranch> GetBankBranches();
    }
}
