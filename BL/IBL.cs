using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project01_7735_5114_dotNet5780;

namespace BL
{
    interface IBL
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
        // { if (order.GuestRequestKey.EntryDate <= order.GuestRequestKey.ReleaseDate) throw Exception; }
        void UpdateOrder(Order order);

        //lists

        List<HostingUnit> GetAllHostingUnits();
        List<GuestRequest> GetAllGuestRequests();
        List<Order> GetAllOrders();

        List<BankBranch> GetBankBranches();


        List<HostingUnit> GetHostingUnitsByDates(DateTime EntryDate, int Days);
        int countDaysBetween(DateTime fromDate, Nullable<DateTime> endDate);
        //int countDaysBetween(DateTime Date);
        List<Order> countOrders(int days);
        List<GuestRequest> GetGuestRequests(Predicate<GuestRequest> predicate);
        int getOrdersByGuestRequest(GuestRequest request);
        int getOrdersByHostingUnit(HostingUnit hostingUnit);

        //grouping
        IEnumerable<IGrouping<enum_s.Area, GuestRequest>> getGuestRequestByArea();
        IEnumerable<IGrouping<int, GuestRequest>> GetGuestRequestsByChildrensAndAdults();
        IEnumerable<IGrouping<int, Host>> GetHostsByHostingUnits();
        IEnumerable<IGrouping<enum_s.Area, HostingUnit>> GetHostingUnitsByArea();
    }
}
