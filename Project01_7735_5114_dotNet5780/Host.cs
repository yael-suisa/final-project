using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BE Host
namespace Project01_7735_5114_dotNet5780
{
    public class Host
    {
        int HostKey;//id
        string PrivateName { get; set; }
        string FamilyName { get; set; }
        string FhoneNumber { get; set; }
        string MailAddress { get; set; }
        BankBranch BankBranchDetails;
        int BankAccountNumber { get; set; }
        bool CollectionCearance { get; set; }
        public void ToString(int GuestRequestKey)
        {

        }

    }
}
