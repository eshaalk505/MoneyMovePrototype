using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMovePrototype
{
    public class SuspiciousCase
    {
        private int _caseID;
        private string _customerForename;
        private string _customerSurname;
        private string _caseStatus;
        private string _reason;
        private bool _evidenceProvided;
        private string _refundStatus;
        private string _userAccountStatus;
        private string _additionalInfo;

        public SuspiciousCase(int caseID, string custForename, string custSurname, string caseStatus, string reason, bool evidenceProvided, string refundStatus, string userAccountStatus, string additionalInfo)
        {
            this._caseID = caseID;
            this._customerForename = custForename;
            this._customerSurname=custSurname;
            this._caseStatus = caseStatus;
            this._reason = reason;
            this._evidenceProvided = evidenceProvided;
            this._refundStatus = refundStatus;
            this._userAccountStatus = userAccountStatus;
            this._additionalInfo = additionalInfo;
        }

        public int caseID
        {
            get
            {
                return this._caseID;
            }
            set
            {
                this._caseID = value;
            }
        }

        public string customerForename
        {
            get
            {
                return this._customerForename;
            }
            set
            {
                this._customerForename = value;
            }
        }

        public string customerSurname
        {
            get
            {
                return this._customerSurname;
            }
            set
            {
                this._customerSurname = value;
            }
        }

        public string caseStatus
        {
            get
            {
                return this._caseStatus;
            }
            set
            {
                this._caseStatus = value;
            }
        }

        public string reason
        {
            get
            {
                return this._reason;
            }
            set
            {
                this._reason = value;
            }
        }

        public bool evidenceProvided
        {
            get
            {
                return this._evidenceProvided;
            }
            set
            {
                this._evidenceProvided = value;
            }
        }

        public string refundStatus
        {
            get
            {
                return this._refundStatus;
            }
            set
            {
                this._refundStatus = value;
            }
        }

        public string userAccountStatus
        {
            get
            {
                return this._userAccountStatus;
            }
            set
            {
                this._userAccountStatus = value;
            }
        }

        public string additionalInfo
        {
            get
            {
                return this._additionalInfo;
            }
            set
            {
                this._additionalInfo = value;
            }
        }
    }
}
