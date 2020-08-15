using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerPolymorphism
{
    class PrefferedCustomer : Customer
    {
        private decimal _amountPurchase;
        private int _discountLevel;

        private PrefferedCustomer()
        {
            _amountPurchase = 0m;
            _discountLevel = -1;
        }

        public decimal amountPurchase
        {
            get { return this._amountPurchase; }
            set { this._amountPurchase = value; }
        }
        public int discountLevel
        {
            get { return this._discountLevel; }
            set { this._discountLevel = value; }
        }
    }
}
