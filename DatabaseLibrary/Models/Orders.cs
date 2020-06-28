﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;

namespace DatabaseLibrary.Models
{
    public partial class Orders
    {
        public int OrderID { get; set; }
        public int? CustomerIdentifier { get; set; }
        /// <summary>
        /// Uses a computed formula in the table definition
        /// </summary>
        /// <remarks>
        /// ('A'+CONVERT([varchar](30),[OrderId]))
        /// </remarks>
        public string OrderNumber { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        public override string ToString() => $"{OrderNumber}, {OrderID}";
    }
}