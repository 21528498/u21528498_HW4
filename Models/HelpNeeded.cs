using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21528498_HW4.Models
{
    public class HelpNeeded : Provinces
    {
        private string mAssistance;
        private string mName;

        public HelpNeeded(string assistance, string name, string province) : base(province)
        {
            mAssistance = assistance;
            mName = name;
        }
        public string Assistance
        {
            get { return mAssistance; }
            set { mAssistance = value; }
        }
        public string Name
        {
            get { return mName; }
            set{ mName = value; }
            
        }

        public override string ThankYou()
        {
            return "We appreciate the time you took to view ways in which you can help";
        }
    }
}