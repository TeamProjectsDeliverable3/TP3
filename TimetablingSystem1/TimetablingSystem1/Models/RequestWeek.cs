//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimetablingSystem1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RequestWeek
    {
        public int RequestWeekID { get; set; }
        public int RequestID { get; set; }
        public byte Week { get; set; }
    
        public virtual Request Request { get; set; }
    }
}
