//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RojgarMitraWebApi.DBManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserEducationDetail
    {
        public long ID { get; set; }
        public string ProfileImage { get; set; }
        public string ProfessionalExperience { get; set; }
        public Nullable<int> HighestQualification { get; set; }
        public Nullable<int> Course { get; set; }
        public Nullable<int> Specialization { get; set; }
        public Nullable<long> University_College { get; set; }
        public string CourseType { get; set; }
        public Nullable<int> PassingYear { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime createdDate { get; set; }
        public long UserId { get; set; }
        public string Extension { get; set; }
    
        public virtual UserMaster UserMaster { get; set; }
    }
}