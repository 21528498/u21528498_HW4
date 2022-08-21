using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21528498_HW4.Models
{
    public abstract class Provinces
    {
        private string mProvince;

        public Provinces(string province)
        {
            mProvince = province;
        }
        public string Province
        {
            get { return mProvince; }
            set { mProvince = value; }
        }
        public abstract string ThankYou();

        public virtual string Thankful()
        {
            return "We appreciate the help";
        }
    }
}