using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerPolymorphism
{
    class Customer : Person
    {
        private int _customerNumber;
        private bool _mailingList;

        public Customer()
        {
            _customerNumber = -1;
            _mailingList = false;
        }

        public int _cutomerNumber
        {
            get { return this._cutomerNumber; }
            set { this._customerNumber = value; }
        }

        public bool mailingList
        {
            get { return this._mailingList; }
            set { this._mailingList = value; }
        }
    }
}
