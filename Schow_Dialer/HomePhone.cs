using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Dialer
{
    class HomePhone : Phone
    {
        // Constructing HomePhone and passing it's values on to Phone
        public HomePhone(string phoneNumber, string companyName, string phoneType) : base(phoneNumber, companyName, phoneType)
        {
        }

        // Overriding Dial() and passing an empty prepend
        public override string Dial(string prepend)
        {
            return base.Dial(prepend);
        }
    }
}
