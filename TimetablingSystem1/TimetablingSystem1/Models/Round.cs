//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimetablingSystem1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Round
    {
        public Round()
        {
            this.Requests = new HashSet<Request>();
        }
    
        public int RoundID { get; set; }
        public int SemesterID { get; set; }
        public string RoundCode { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
    
        public virtual ICollection<Request> Requests { get; set; }
        public virtual Semester Semester { get; set; }
    }
}