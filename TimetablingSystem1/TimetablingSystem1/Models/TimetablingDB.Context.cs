﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TimetablingEntities : DbContext
    {
        public TimetablingEntities()
            : base("name=TimetablingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AllocatedRoom> AllocatedRooms { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<PreferenceRoom> PreferenceRooms { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestWeek> RequestWeeks { get; set; }
        public virtual DbSet<RequiredFacility> RequiredFacilities { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomFacility> RoomFacilities { get; set; }
        public virtual DbSet<Round> Rounds { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
    }
}
