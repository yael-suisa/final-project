using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BE GuestRequest
namespace Project01_7735_5114_dotNet5780
{
    public class GuestRequest
    {
   
        public int GuestRequestKey { get; set; }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public string MailAddress { get; set; }
        public enum_s.Status Status { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public enum_s.Area Area { get; set; }
        public enum_s.Type Type { get; set; }
        public int Adults { get; set; }
        public int children { get; set; }
        public enum_s.Answer pool { get; set; }
        public enum_s.Answer Jacuzzi { get; set; }
        public enum_s.Answer Garden { get; set; }
        public enum_s.Answer ChildrensAttractions { get; set; }
        public enum_s.Answer SmokingArea { get; set; }
        public bool accessible { get; set; }//Accessibility for the disabled
        public void ToString(int GuestRequestKey)
        {

        }
       


    }
}
