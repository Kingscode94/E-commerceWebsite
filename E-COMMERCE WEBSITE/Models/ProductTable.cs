//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_COMMERCE_WEBSITE.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    public partial class ProductTable
    {
        public int ProductId { get; set; }
        public string Categories { get; set; }
        public string Brand { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> ProductAmt { get; set; }
        public Nullable<int> ProductQty { get; set; }
        public string ProductCondition { get; set; }
        public string ProductDescription { get; set; }
        public string ReturnPolicy { get; set; }
        public string ProductReviews { get; set; }
        public string ImagePaths { get; set; }
        public string ExtraimgPaths { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public string Model { get; set; }
        // this user id will temporaily hold the details of the user
        public Nullable<int> UserId { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
    }
}
