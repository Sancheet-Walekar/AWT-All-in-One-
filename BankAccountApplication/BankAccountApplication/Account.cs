   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApplication
{
    class Account
    {
        // Instance variables - Data members
        int acNo;
        double acBalance;
        string acName;   

        public int AcNo  //read and write property 
        {
            get
            {
                return acNo;
            }
            set
            {
                acNo = value;
            }
        }
        public double AcBalance
        {
            get
            {
                return acBalance;
            }
            set
            {
                acBalance = value;
            }
        }

        public string AcName
        {
            get
            {
                return acName;
            }
            set
            {
                acName = value;
            }
        }

        //utility method
        public void Deposite(double amt)
        {
            this.acBalance += amt;
        }

        public bool Withdraw(double amt)
        {
            if(this.acBalance-amt >= 0)
            {
                this.acBalance -= amt;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
