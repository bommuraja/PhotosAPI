//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotosAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Photo
    {
        public long PhotoID { get; set; }
        public string PhotoName { get; set; }
        public Nullable<int> PrimaryIdentification { get; set; }
        public Nullable<int> SecondaryIdentification { get; set; }
        public Nullable<int> Category { get; set; }
        public Nullable<int> SubCategory { get; set; }
        public string PhotoPath { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
