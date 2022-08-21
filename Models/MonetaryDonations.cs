using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21528498_HW4.Models
{
    public class MonetaryDonations
    {
        private string mCompany;
        private int mAmount;
        private string mDescription;

        public MonetaryDonations(string company, int amount, string description)
        {
            mCompany = company;
            mAmount = amount;
            mDescription = description;
        }
        public string Company
        {
            get { return mCompany; }
            set { mCompany = value; }
        }
        public int Amount
        {
            get { return mAmount; }
            set { mAmount = value; }
        }
        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }
    }
}