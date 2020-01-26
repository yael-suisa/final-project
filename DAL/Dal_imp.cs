using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project01_7735_5114_dotNet5780;

namespace DAL
{
    public class Dal_imp : Idal
    {
        public void AddGuestRequest(GuestRequest guest)
        {
            guest.GuestRequestKey = Configuration.getGeneralGrk();
            DS.DataSource.guestRequests.Add(guest);            
        }

        public void AddHostingUnit(HostingUnit hostingUnit)
        {
            hostingUnit.HostingUnitKey = Configuration.getGeneralHUK();
            DS.DataSource.hostingUnits.Add(hostingUnit);
        }

        public void AddOrder(Order order)
        {
            order.OrderKey = Configuration.getGeneralOK();
            DS.DataSource.orders.Add(order);
        }

        public void DeleteHostingUnit(int key)
        {
            
            foreach (HostingUnit item in DS.DataSource.hostingUnits)
            {
                if (item.HostingUnitKey == key)
                    DS.DataSource.hostingUnits.Remove(item);
            }
        }

        public List<GuestRequest> GetAllGuestRequests()
        {
            return DS.DataSource.guestRequests;
        }

        public List<HostingUnit> GetAllHostingUnits()
        {
            return DS.DataSource.hostingUnits;
        }

        public List<Order> GetAllOrders()
        {
            return DS.DataSource.orders;
        }

        public List<BankBranch> GetBankBranches()
        {
            List<BankBranch> ret = new List<BankBranch>();

            BankBranch b = new BankBranch();
            b.BankName = "Discont";
            b.BankNumber = 11;
            b.BranchAddress = "Jaffa 220";
            b.BranchCity = "Jerusalem";
            b.BranchNumber = 41;
            ret.Add(b);

            return ret;
        }

        public void UpdateGuestRequest(GuestRequest guest)
        {
            foreach (GuestRequest item in DS.DataSource.guestRequests)
            {
                if (item.GuestRequestKey == guest.GuestRequestKey)
                {
                    DS.DataSource.guestRequests.Remove(item);
                    DS.DataSource.guestRequests.Add(guest);                   
                }
            }
        }

        public void UpdateHostingUnit(HostingUnit hostingUnit)
        {
            foreach (HostingUnit item in DS.DataSource.hostingUnits)
            {
                if (item.HostingUnitKey == hostingUnit.HostingUnitKey)
                {
                    DS.DataSource.hostingUnits.Remove(item);
                    DS.DataSource.hostingUnits.Add(hostingUnit);
                }
            }
        }

        public void UpdateOrder(Order order)
        {
            foreach (Order item in DS.DataSource.orders)
            {
                if (item.OrderKey == order.OrderKey)
                {
                    DS.DataSource.orders.Remove(item);
                    DS.DataSource.orders.Add(order);
                }
            }
        }
    }
}
