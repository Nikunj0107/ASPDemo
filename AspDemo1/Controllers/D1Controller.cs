using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspDemo1.Models;
  

namespace AspDemo1.Controllers
{
    public class D1Controller : Controller
    {
        // GET: D1
        public ActionResult Index()
        {
            return View();
        }

        public string Action1()
        {
            return "String returned by action 1";
        } 

        public ActionResult Action2()
        {
            return View();
        }

        public ActionResult Action3()
        {
            ViewBag.Message = "Data passed to action 3 using viewbag";
            return View();
        } 
        public ActionResult Action4()
        {
            ViewData["M"] = "Data passed to action 4 using view data";
            return View();
        }
        public ActionResult Action5()
        {
            ViewBag.Message = "View fetch data itself, wrong approach";
            return View();
        }
        public ActionResult Action6()
        {
            ViewBag.Message = "View recieves data as model from action, right approach";
            Member m = new Member() { MembershipID = 101, FirstName = "Nikunj", LastName = "Agarwal", MembershipType = "Gold" };
            return View(m);
        }
        public ActionResult Action7()
        {
            ViewBag.Message = "View recieves data as list from action";

            //db simulation
            List<Member> members = new List<Member>();

            members.Add(new Member() {
                MembershipID = 102,
                FirstName = "Anshu",
                LastName ="Agarwal",
                MembershipType ="Silver"
            });
            members.Add(new Member() {
                MembershipID = 103,
                FirstName = "Nidhi",
                LastName = "Gupta",
                MembershipType = "Platinum"
            });
            members.Add(new Member() {
                MembershipID = 104,
                FirstName = "Priya",
                LastName = "Singh",
                MembershipType = "Gold"
            });


            return View(members);
        }

        public ActionResult Action8()
        {
            ViewBag.Message = "View recieving View Model";
            ReportEoDVM rvm = new ReportEoDVM();
            //db simulation - fetch top game of today
            Game g = new Game() { Title = "Mario", Price= 10 };
            rvm.TopGame = g;

            List<Member> members = new List<Member>();

            rvm.NewMembers.Add(new Member()
            {
                MembershipID = 201,
                MembershipType = "Platinum",
                FirstName = "Mazi",
                LastName= "Bhat"

            }) ;
            
            rvm.NewMembers.Add(new Member()
            {
                MembershipID = 202,
                MembershipType = "Gold",
                FirstName = "Manju",
                LastName = "Tiwari"
            });

            return View(rvm);
        }
    }
}