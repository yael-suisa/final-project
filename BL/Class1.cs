using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Project01_7735_5114_dotNet5780;
//yael suisa and ruth bar dagan
namespace BL
{
    public class BL_Impl : IBL
    {
        DAL.Dal_imp dal;

        public BL_Impl()
        {
            this.dal = new Dal_imp();
        }
        //add guest request 
        public void AddGuestRequest(GuestRequest guest)
        {
            if (guest.EntryDate >= guest.ReleaseDate) return;

            dal.AddGuestRequest(guest);
        }
        //add guest request
        public void AddHostingUnit(HostingUnit hostingUnit)
        {
            dal.AddHostingUnit(hostingUnit);
        }
        //add order
        public void AddOrder(Order order)
        {
            dal.AddOrder(order);
        }
        //count days between two dates
        public int countDaysBetween(DateTime fromDate, Nullable<DateTime> endDate = null)
        {
            if (endDate == null) endDate = DateTime.Today;
            return (endDate.Value.Date - fromDate.Date).Days;
        }
        //count the the days from today
        //public int countDaysBetween(DateTime Date)
        //{
        //    DateTime currentTime = DateTime.Now;

        //    return (Date.Date - currentTime.Date).Days;
        //}
        public List<Order> countOrders(int days)
        {
            Predicate<Order> predicate = delegate(Order order) { return ((((order.OrderDate - DateTime.Today).Days >= days) || ((order.CreateDate - DateTime.Today).Days >= days))); };
            return dal.GetAllOrders().FindAll(predicate);
        }

        public void DeleteHostingUnit(int key)
        {
            dal.DeleteHostingUnit(key);
        }

        public List<GuestRequest> GetAllGuestRequests()
        {
            return dal.GetAllGuestRequests();
        }

        public List<HostingUnit> GetAllHostingUnits()
        {
            return dal.GetAllHostingUnits();
        }

        public List<Order> GetAllOrders()
        {
            return dal.GetAllOrders();
        }

        public List<BankBranch> GetBankBranches()
        {
            return dal.GetBankBranches();
        }

        public IEnumerable<IGrouping<enum_s.Area, GuestRequest>> getGuestRequestByArea()
        {
            return from guestRequest in dal.GetAllGuestRequests() group guestRequest by guestRequest.Area;
        }

        public List<GuestRequest> GetGuestRequests(Predicate<GuestRequest> predicate)
        {
            return dal.GetAllGuestRequests().FindAll(predicate);
        }

        public IEnumerable<IGrouping<int, GuestRequest>> GetGuestRequestsByChildrensAndAdults()
        {
            return from guestRequest in dal.GetAllGuestRequests() group guestRequest by (guestRequest.Adults + guestRequest.children);
        }

        public IEnumerable<IGrouping<enum_s.Area, HostingUnit>> GetHostingUnitsByArea()
        {
            return from hostingUnit in dal.GetAllHostingUnits() group hostingUnit by hostingUnit.Area;
        }

        public List<HostingUnit> GetHostingUnitsByDates(DateTime EntryDate, int Days)
        {
            List<HostingUnit> ret = new List<HostingUnit>();
            foreach (var item in dal.GetAllHostingUnits())
            {
                if(item.isAvailable(EntryDate, Days))
                    ret.Add(item);
            }
            return ret;
        }

        public IEnumerable<IGrouping<int, Host>> GetHostsByHostingUnits()
        {
            return from var in 
                       (from hostingUnit in dal.GetAllHostingUnits() group hostingUnit by hostingUnit.Owner)
                       group var.Key by var.ToList().Count;
        }

        public int getOrdersByGuestRequest(GuestRequest request)
        {
            return (from order in dal.GetAllOrders() where order.GuestRequestKey.GuestRequestKey == request.GuestRequestKey select order).ToList().Count;
        }

        public int getOrdersByHostingUnit(HostingUnit hostingUnit)
        {
            return (from order in dal.GetAllOrders() where order.HostingUnitKey == hostingUnit.HostingUnitKey && (order.Status == enum_s.Status.sentMail || order.Status == enum_s.Status.closedForCustomerResponse) select order).ToList().Count;
        }

        public void UpdateGuestRequest(GuestRequest guest)
        {
            dal.UpdateGuestRequest(guest);
        }

        public void UpdateHostingUnit(HostingUnit hostingUnit)
        {
            dal.UpdateHostingUnit(hostingUnit);
        }

        public void UpdateOrder(Order order)
        {
            dal.UpdateOrder(order);
        }
    }
}
