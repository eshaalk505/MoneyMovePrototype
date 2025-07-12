using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMovePrototype
{
    public class Person
    {
        private int _uniqueID;
        private string _forename;
        private string _surname;
        private string _username;
        private string _password;
        private bool _isSystemAdmin;

        public Person (int uniqueID, string forename, string surname, string username, string password, bool isSystemAdmin)
        {
            this._uniqueID = uniqueID;
            this._forename = forename;
            this._surname = surname;
            this._username = username;
            this._password = password;
            this._isSystemAdmin = isSystemAdmin;
        }

        public int uniqueID
        {
            get
            {
                return this._uniqueID;
            }
            set
            {
                this._uniqueID = value;
            }
        }
        public string forename
        {
            get
            {
                return this._forename;
            }
            set
            {
                this._forename = value;
            }
        }
        public string surname
        {
            get
            {
                return this._surname;
            }
            set
            {
                this._surname = value;
            }
        }

        public string username
        {
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
            }
        }
        public string password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }

        public bool isSystemAdmin
        {
            get
            {
                return this._isSystemAdmin;
            }
            set
            {
                this._isSystemAdmin = value;
            }
        }
    }
}
