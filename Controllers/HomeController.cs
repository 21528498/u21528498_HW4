using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21528498_HW4.Models;

namespace u21528498_HW4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Narratives()
        {

            return View();
        }
        public ActionResult Donate()
        {

            return View();
        }
        public ActionResult CompanyDonations()
        {
            List<MonetaryDonations> donation = BigCompany();
            return View(donation);
        }
        private List<MonetaryDonations> BigCompany()
        {
            List<MonetaryDonations> donation = new List<MonetaryDonations>();
            MonetaryDonations donate1 = new MonetaryDonations("Samsung Electronics South Africa", 282750, "Domestic Electronic Equipment (includes washing machines, refrigerators, and sound systems) - distributed to various facilities");
            MonetaryDonations donate2 = new MonetaryDonations("Samsung Electronics Souht Africa", 389000, "Ophthalmological equipment donated to Vredendal Hospital Eye Clinic");
            MonetaryDonations donate3 = new MonetaryDonations("Embassy of Japan", 685000, "Ophthalmological equipment donated to Vredendal Hospital Eye Clinic");
            MonetaryDonations donate4 = new MonetaryDonations("Smith and Nephew", 0, "Hip and knee replacements as well as Specialist's time donated to Mitchells Plain and Victoria hospitals to implement on 18 patients");
            MonetaryDonations donate5 = new MonetaryDonations("Vodacom", 80000, "Gift of Vision + re-painting of the Life Orientation classroom");
            donation.Add(donate1);
            donation.Add(donate2);
            donation.Add(donate3);
            donation.Add(donate4);
            donation.Add(donate5);
            return donation;
        }
        public ActionResult HelpNeeded()
        {
            List<HelpNeeded> help = Labour();
            return View(help);
        }
        private List<HelpNeeded> Labour()
        {
            List<HelpNeeded> help = new List<HelpNeeded>();
            HelpNeeded help1 = new HelpNeeded("Nurses for a weekend", "Victoria Hospital", "North West");
            HelpNeeded help2 = new HelpNeeded("Midwives", "Njani Public Hospital", "Kwa Zulu Natal");
            HelpNeeded help3 = new HelpNeeded("Midwives", "Manamela Hospital", "Limpopo");
            HelpNeeded help4 = new HelpNeeded("Pediatrician", "Giyane Public Hospital", "Limpopo");
            HelpNeeded help5 = new HelpNeeded("Optometrist", "Kakari Hospital", "Eastern Cape");
            HelpNeeded help6 = new HelpNeeded("Nurses", "Khethiwe Clinic", "Mpumalanga");
            help.Add(help1);
            help.Add(help2);
            help.Add(help3);
            help.Add(help4);
            help.Add(help5);
            help.Add(help6);
            return help;
        }
        public ActionResult Donations()
        {
            List<Donations> donate = Giving();
            return View(donate);
        }
        private List<Donations> Giving()
        {
            List<Donations> donate = new List<Donations>();
            Donations donate1 = new Donations(400, "Sanitary pads", "Eastern Cape");
            Donations donate10 = new Donations(300, "Canned food", "Eastern Cape");
            Donations donate2 = new Donations(290, "Sanitary pads", "Free State");
            Donations donate11 = new Donations(320, "Canned food", "Free State");
            Donations donate3 = new Donations(580, "Sanitary pads", "Gauteng");
            Donations donate12 = new Donations(600, "Canned food", "Gauteng");
            Donations donate4 = new Donations(300, "Sanitary pads", "KwaZulu Natal");
            Donations donate13 = new Donations(420, "Canned food", "KwaZulu Natal");
            Donations donate5 = new Donations(430, "Sanitary pads", "Limpopo");
            Donations donate14 = new Donations(500, "Canned food", "Limpopo");
            Donations donate6 = new Donations(228, "Sanitary pads", "Mpumalanga");
            Donations donate15 = new Donations(320, "Canned food", "Mpumalanga");
            Donations donate7 = new Donations(346, "Sanitary pads", "Northern Cape");
            Donations donate16 = new Donations(400, "Canned food", "Northern Cape");
            Donations donate8 = new Donations(211, "Sanitary pads", "North West");
            Donations donate17 = new Donations(300, "Canned food", "North West");
            Donations donate9 = new Donations(546, "Sanitary pads", "Western Cape");
            Donations donate18 = new Donations(600, "Canned food", "Western Cape");
            donate.Add(donate1);
            donate.Add(donate2);
            donate.Add(donate3);
            donate.Add(donate4);
            donate.Add(donate5);
            donate.Add(donate6);
            donate.Add(donate7);
            donate.Add(donate8);
            donate.Add(donate9);
            donate.Add(donate10);
            donate.Add(donate11);
            donate.Add(donate12);
            donate.Add(donate13);
            donate.Add(donate14);
            donate.Add(donate15); 
            donate.Add(donate16); 
            donate.Add(donate17); 
            donate.Add(donate18);
            return donate;
        }

        public ActionResult Drives()
        {
            List<Drives> drive = Awareness();
            return View(drive);
        }
        private List<Drives> Awareness()
        {
            List<Drives> drive = new List<Drives>();
            Drives drive1 = new Drives("Young Girls' Safety Awareness","2022-08-23", "Limpopo");
            Drives drive2 = new Drives("Young Girls' Safety Awareness", "2022-08-25","Eastern Cape");
            Drives drive3 = new Drives("Young Girls' Safety Awareness", "2022-08-27", "Mpumalanga");
            Drives drive4 = new Drives("Young Girls' Safety Awareness", "2022-08-30", "North West");
            Drives drive5 = new Drives("Young Girls' Safety Awareness", "2022-08-23", "Gauteng");
            Drives drive6 = new Drives("Albinism Awareness", "2022-09-08", "Free State");
            Drives drive7 = new Drives("Albinism Awareness", "2022-09-13", "Northern Cape");
            Drives drive8 = new Drives("Albinism Awareness", "2022-09-08", "Free State");
            Drives drive9 = new Drives("Albinism Awareness", "2022-09-18", "Western Cape");
            Drives drive10 = new Drives("Crime Prevention Awareness", "2022-10-08", "Free State");
            Drives drive11 = new Drives("Crime Prevention Awareness", "2022-10-14", "Gauteng");
            Drives drive12 = new Drives("Crime Prevention Awareness", "2022-10-18", "KwaZulu Natal");
            Drives drive13 = new Drives("Crime Prevention Awareness", "2022-10-20", "Limpopo");
            Drives drive14 = new Drives("Crime Prevention Awareness", "2022-10-25", "North West");
            Drives drive15 = new Drives("16 Days of Activism", "2022-11-25", "Limpopo");
            Drives drive16 = new Drives("16 Days of Activism", "2022-11-25", "Western Cape");
            Drives drive17 = new Drives("16 Days of Activism", "2022-11-30", "Northern Cape");
            Drives drive18 = new Drives("16 Days of Activism", "2022-11-30", "Eastern Cape");
            drive.Add(drive1);
            drive.Add(drive2);
            drive.Add(drive3);
            drive.Add(drive4);
            drive.Add(drive5); 
            drive.Add(drive6); 
            drive.Add(drive7); 
            drive.Add(drive8); 
            drive.Add(drive9); 
            drive.Add(drive10); 
            drive.Add(drive11); 
            drive.Add(drive12); 
            drive.Add(drive13); 
            drive.Add(drive14); 
            drive.Add(drive15); 
            drive.Add(drive16); 
            drive.Add(drive17); 
            drive.Add(drive18);
            return drive;
        }
        
        public ActionResult Application()
        {

            return View();
        }
    }
}