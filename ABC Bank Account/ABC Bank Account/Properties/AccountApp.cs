using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bank_Account.Properties
{
    class AccountApp
    {
        private String name;

        protected internal string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int num1;

        protected internal int AccountNum
        {
            get { return num1; }
            set { num1 = value; }
        }

        private int num2;

        protected internal int AccountPin
        {
            get { return num2; }
            set { num2 = value; }
        }

        private int num3;

        protected internal int AccountBal
        {
            get { return num3; }
            set { num3 = value; }
        }

        public AccountApp(string AccName,int AccPin,int AccBal,int AccNum)
        {
            this.name = AccName;
            this.num1 = AccNum;
            this.num2 = AccPin;
            this.num3 = AccBal;
            
        }
    }
}
