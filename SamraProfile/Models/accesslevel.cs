//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SamraProfile.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class accesslevel
    {
        public int FunctionID { get; set; }
        public string FunctionCode { get; set; }
        public string Description { get; set; }
        public Nullable<int> AccessLevelRequired { get; set; }
        public Nullable<int> RowOrder { get; set; }
        public Nullable<bool> Header { get; set; }
    }
}
