using System;
using System.Collections.Generic;
using System.Text;

namespace Fax.EmailDAL
{
    public class Mail_To_Fax_CreditInf
    {
        public Mail_To_Fax_CreditInf()
        { }

        private string _creditType = string.Empty;
        private string _iAppCode = string.Empty;
        private string _passWd = string.Empty;
        private string _param1 = string.Empty;
        private string _param2 = string.Empty;
        private string _param3 = string.Empty;
        private string _validateType = string.Empty;
        private string _param4  =string.Empty;

        public string CreditType
        {
            get { return this._creditType; }
            set { this._creditType = value; }
        }

        public string IAppCode
        {
            get { return this._iAppCode; }
            set { this._iAppCode = value; }
        }

        public string PassWD
        {
            get { return this._passWd; }
            set { this._passWd = value; }
        }

        public string Param1
        {
            get { return this._param1; }
            set { this._param1 = value; }
        }

        public string Param2
        {
            get { return this._param2; }
            set { this._param2 = value; }
        }

        public string Param3
        {
            get { return this._param3; }
            set { this._param3 = value; }
        }

        public string ValidateType
        {
            get { return this._validateType; }
            set { this._validateType = value; }
        }

        public string Param4
        {
            get { return this._param4; }
            set { this._param4 = value; }
        }

    }
}
