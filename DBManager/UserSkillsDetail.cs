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
    
    public partial class UserSkillsDetail
    {
        public long ID { get; set; }
        public long UserID { get; set; }
        public string Skills { get; set; }
        public string Version { get; set; }
        public Nullable<int> LastUsedYear { get; set; }
        public Nullable<int> Experience { get; set; }
        public bool Active { get; set; }
        public System.DateTime createdDate { get; set; }
    
        public virtual UserMaster UserMaster { get; set; }
    }
}
