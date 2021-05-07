using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Dialer
{
    class Phone
    {
        // Creating local variables
        string _phoneNumber;
        string _companyName;
        string _phoneType;

        // Constructing Phone and setting local variables equal to those that were inputted
        public Phone(string phoneNumber, string companyName, string phoneType)
        {
            _phoneNumber = phoneNumber;
            _companyName = companyName;
            _phoneType = phoneType;
        }

        public virtual string Dial(string prepend)
        {
            // Creating variables and parsing the phone number
            string dialMessage;
            double trueNum = double.Parse(_phoneNumber);

            // setting dialMessage equal to the message tailored for each phone number
            dialMessage = String.Format(_companyName + " is being dialed using " + prepend + "{0:(###) ###-####}...", trueNum);
            // returning the message
            return dialMessage;
        }
    }
}
