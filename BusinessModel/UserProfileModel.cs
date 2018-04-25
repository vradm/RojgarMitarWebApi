using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class UserProfileModel
    {
        public UserProfileModel()
        {
            userSkillsDetails = new List<UserSkillsDetails>();
            userWorkHistories = new List<UserWorkHistory>();
        }
        public List<UserSkillsDetails> userSkillsDetails { get; set; }
        public List<UserWorkHistory> userWorkHistories { get; set; }
        public long UserId { get; set; }
        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
        public long? DesignationID { get; set; }
        public string ResumeName { get; set; }
        public string Extension { get; set; }
        public string ResumeTitle { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ExperienceID { get; set; }
        public long? CurrentLocationID { get; set; }
        public long? FunctionalArea { get; set; }
        public string RoleID { get; set; }
        public long? IndustryId { get; set; }
        public long? JobTypeId { get; set; }
        public string WorkingSinceMonth { get; set; }
        public string WorkingTo { get; set; }
        public Nullable<int> PassingYear { get; set; }
        public string WorkingSinceYear { get; set; }
        public string HighestQualification { get; set; }
        public string Course { get; set; }
        public string Specialization { get; set; }
        public string University_College { get; set; }
        public string CourseType { get; set; }
        public Nullable<long> CityID { get; set; }
        public string CityName { get; set; }
        //-----other Details----
        public string Dobyear { get; set; }
        public string DobMonth { get; set; }
        public string DobDay { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string MailingAddress { get; set; }
        public int? Pincode { get; set; }
        public string DifferAbled { get; set; }

    }
    public class UserSkillsDetails
    {

        public long ID { get; set; }
        public Nullable<long> UserID { get; set; }
        public string Skills { get; set; }
        public decimal Version { get; set; }
        public Nullable<int> LastUsedYear { get; set; }
        public Nullable<int> Experience { get; set; }
        public string ExperienceName { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

    }
    public class UserWorkHistory
    {
        public long ID { get; set; }
        public long UserId { get; set; }
        public string DesignationName { get; set; }
        public string CompanyName { get; set; }
        public string WokingSinceYear { get; set; }
        public string workingSinceMonth { get; set; }
        public string  WorkingSinceTo { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}