using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_7735_5114_dotNet5780
{
    public static class Configuration
    {
        static int GeneralGrk = 10000001;//general counter for guest request
        static int GeneralHUK = 10000001;//general counter for HostingUnit
        static int GeneralOK = 10000001;//general counter for OrderKey

        public static int getGeneralGrk()
        {
            return GeneralGrk++;
        }

        public static int getGeneralHUK()
        {
            return GeneralHUK++;
        }

        public static int getGeneralOK()
        {
            return GeneralOK++;
        }
    }
}
