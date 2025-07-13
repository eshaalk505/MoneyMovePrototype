using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMovePrototype
{
    public class CurrencyAccount
    {
        private string _accountName;
        private string _currencyCode;
        private string _currencySymbol;
        private decimal _balance;

        public CurrencyAccount(string name, string code, string symbol, decimal balance)
        {
            this._accountName = name;
            this._currencyCode = code;
            this._currencySymbol = symbol;
            this._balance = balance;
        }

        public string name
        {
            get
            {
                return this._accountName;
            }
            set
            {
                this._accountName = value;
            }
        }

        public string code
        {
            get
            {
                return this._currencyCode;
            }
            set
            {
                this._currencyCode = value;
            }
        }

        public string symbol
        {
            get
            {
                return this._currencySymbol;
            }
            set
            {
                this._currencySymbol = value;
            }
        }

        public decimal balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }
    }
}
