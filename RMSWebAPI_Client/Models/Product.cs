using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RMSWebAPI_Client.Models
{
    public class Product
    {
        [Display(Name = "OId")]
        public long Oid { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "ProductTypeOid")]
        public long ProductTypeOid { get; set; }
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Display(Name = "Unit Price")]
        public double UnitPrice { get; set; }
        [Display(Name = "Total Price")]
        public double TotalPrice { get; set; }
        [Display(Name = "SupplierOid")]
        public long SupplierOid { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
    }
}