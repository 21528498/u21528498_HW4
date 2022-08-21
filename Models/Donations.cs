using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21528498_HW4.Models
{
    public class Donations : Provinces
    {
        private int mAmount;
        private string mProduct;

        public Donations(int amount, string product, string province) : base(province)
        {
            mAmount = amount;
            mProduct = product;
        }
        public int Amount
        {
            get { return mAmount; }
            set { mAmount = value; }
        }
        public string Product
        {
            get { return mProduct; }
            set { mProduct = value; }
        }

        public override string ThankYou()
        {
            return "We would like to thank all the individuals that donated the products. We hope you find it in you to help us too";
        }
        public override string Thankful()
        {
            return base.Thankful();
        }
    }
}