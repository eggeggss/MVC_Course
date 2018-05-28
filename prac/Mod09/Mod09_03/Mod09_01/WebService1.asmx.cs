﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Mod09_01
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public string CustomerId { set; get; }
        public string Name { set; get; }

        [WebMethod]
        public Customer HelloWorld(string id)
        {
            List<Customer> data = new List<Customer> {
               new Customer{CustomerId="123", Name="Mary"},
               new Customer{CustomerId="223", Name="Candy"},
               new Customer{CustomerId="323", Name="Lili"}
           };
            Customer customer = data.Find(c => c.CustomerId == id);

            return customer;
        }
    }

    public class Customer
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
    }
}