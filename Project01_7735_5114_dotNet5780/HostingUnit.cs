using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BE HostingUnit
namespace Project01_7735_5114_dotNet5780
{
    public class HostingUnit
    {
         
        public int HostingUnitKey { get; set; }
        public Host Owner { get; set; }
       public string HostingUnitName { get; set; }
        public enum_s.Area Area { get; set; }
        public enum_s.Type Type { get; set; }
        public int Adults { get; set; }
        public int children { get; set; }
        public bool pool { get; set; }
        public bool Jacuzzi { get; set; }
        public bool Garden { get; set; }
        public bool ChildrensAttractions { get; set; }
        public bool SmokingArea { get; set; }
        public bool accessible { get; set; }//Accessibility for the disabled
        bool[,] Diary = new bool[12, 31];


        
        public HostingUnit()
        {
            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 31; ++j)
                {
                    Diary[i, j] = false;
                }
            }
        }
        public bool isAvailable(DateTime date, int days)
        {
            while ((days -1) >= 0)
            {
                DateTime d = date.AddDays(days);
                if (Diary[d.Month - 1, d.Day - 1]) return false;
                days--;
            }
            return true;
        }
        public void ToString(int GuestRequestKey)
        {

        }
       
       

    }
}
