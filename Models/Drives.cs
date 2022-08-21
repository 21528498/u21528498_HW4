using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21528498_HW4.Models
{
    public class Drives : Provinces
    {
        private string mAim;
        private string mDate;

        public Drives(string aim, string date, string province) : base(province)
        {
            mAim = aim;
            mDate = date;
        }
        public string Aim
        {
            get { return mAim; }
            set { mAim = value; }
        }
        public string Date
        {
            get { return mDate; }
            set { mDate = value; }
        }
        public override string ThankYou()
        {
            return "We hope to see you there";
        }
    }
}