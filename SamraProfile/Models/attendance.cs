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
    
    public partial class attendance
    {
        public int AttendanceID { get; set; }
        public Nullable<System.DateTime> AttendanceDate { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> ClassID { get; set; }
        public Nullable<sbyte> Status_AM { get; set; }
        public Nullable<int> ReasonID_AM { get; set; }
        public Nullable<sbyte> Status_PM { get; set; }
        public Nullable<int> ReasonID_PM { get; set; }
    }
}