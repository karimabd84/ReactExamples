﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactDemo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactDemo.Controllers
{
    public class TableController : Controller
    {
        private static readonly IList<TableContent> _tableContent;

        static TableController()
        {
            _tableContent = new List<TableContent>
            {
                new TableContent
                {
                    FirstName = "Name 1",
                    LastName = "Last 1",
                    City = "City A",
                    Country ="AAAA",
                    EmailID = "aaa@aa.de",
                    EmployeeId = 1
                },
                new TableContent
                {
                    FirstName = "Name 2",
                    LastName = "Last 2",
                    City = "City B",
                    Country ="BBBBB",
                    EmailID = "BBbb@bb.de",
                    EmployeeId = 2
                },
                new TableContent
                {
                    FirstName = "Name 3",
                    LastName = "Last 3",
                    City = "City C",
                    Country ="CCCC",
                    EmailID = "cccc@cc.de",
                    EmployeeId = 3
                },
                new TableContent
                {
                    FirstName = "Name 4",
                    LastName = "Last 4",
                    City = "City RR",
                    Country ="RRRR",
                    EmailID = "rrR@RRe.de",
                    EmployeeId = 4
                },
                new TableContent
                {
                    FirstName = "Name 5",
                    LastName = "Last 5",
                    City = "City wwww",
                    Country ="WWWWW",
                    EmailID = "www@WWWW.de",
                    EmployeeId = 5
                },
                new TableContent
                {
                    FirstName = "Name 6",
                    LastName = "Last 6",
                    City = "City llll",
                    Country ="llllll",
                    EmailID = "lööö@kkkkk.de",
                    EmployeeId = 6
                },
            };
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult GetTableData()
        {
            var data = _tableContent.OrderBy(a => a.FirstName).ToList();
            return Json(data);
        }
    }
}
