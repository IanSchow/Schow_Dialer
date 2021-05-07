using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Dialer
{
    class CellPhone : Phone
    {
        // Constructing CellPhone and passing it's values on to Phone
        public CellPhone(string phoneNumber, string companyName, string phoneType) : base(phoneNumber, companyName, phoneType)
        {
        }

        // Overriding Dial() and adding the "1+" prepend
        public override string Dial(string prepend)
        {
            prepend = "1+";
            return base.Dial(prepend);
        }
    }
}
