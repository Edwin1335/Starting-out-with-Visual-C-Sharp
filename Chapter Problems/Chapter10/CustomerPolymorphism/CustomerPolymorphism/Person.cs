using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerPolymorphism
{
    abstract class Person
    {
        private string _Name;
        private string _eMail;
        private string _phoneNumber;
        private string _address;

        public Person()
        {
            _Name = "";
            _eMail = "";
            _phoneNumber = "";
            _address = "";
        }

        public Person(string name, string email, string number, string address, bool mailing)
        {
            this._Name = name;
            this._eMail = email;
            this._phoneNumber = number;
            this._address = address;
        }

        public string Name
        {
            get { return this._Name; }
            set { _Name = value; }
        }

        public string eMial
        {
            get { return this._eMail; }
            set { _eMail = value; }
        }

        public string phoneNumber
        {
            get { return this._phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Address
        {
            get { return this._address; }
            set { _address = value; }
        }
    }
}
