using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_7735_5114_dotNet5780
{
    public static class enum_s
    {
        public enum Area
        {
            All, North, South, Center, Jerusalem
        }

        public enum Type
        {
            Zimmer, Hotel, Camping, Apartment
        }

        public enum Answer//Pool, Jacuzzi, Garden, ChildrenAttracations
        {
            Necessary, possible, uninterested
        }

        public enum Status//Order Status
        {
            NotHandled,
            sentMail,
            closedForCustomerUnresponsiveness,
            closedForCustomerResponse
        }

    }
}
