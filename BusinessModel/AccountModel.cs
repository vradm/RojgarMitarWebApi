using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class AccountModel
    {
        public AccountModel()
        {
            Files = new List<HttpPostedFileBase>();
          
            PreEmployeementDetails = new UserPreEmployeementDetails();
            EmployementDetails = new UserEmployementDetails();
            UserEducationDetails = new UserEducationDetails();
        }
        public UserPreEmployeementDetails PreEmployeementDetails { get; set; }
        public UserEmployementDetails EmployementDetails { get; set; }
       public UserEducationDetails UserEducationDetails { get; set; }
        public long UserID { get; set; }
        public string FullName { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string StdCode { get; set; }
        public string MobileNumber { get; set; }
        public Nullable<int> TotalExYear { get; set; }
        public Nullable<int> ToalExMonth { get; set; }
        public string Resume { get; set; }
        public string CurrentLocation { get; set; }
        public string LandLineNumber1 { get; set; }
        public string LandLineNumer2 { get; set; }
        public string MobileNumber2 { get; set; }
        public string Role { get; set; }
        public string AuthTocken { get; set; }
        public Nullable<int> Prefereedocation { get; set; }
        public string PermanentAddress { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string HomeTown { get; set; }
        public Nullable<int> PinCode { get; set; }
        public Nullable<int> MartialStatus { get; set; }
        public string KeySkills { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool Active { get; set; }
        public bool Rememberme { get; set; } = false;
        public List<HttpPostedFileBase> Files { get; set; }

    }
    public class UserEmployementDetails
    {
        public long ID { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<int> CurrentDesignation { get; set; }
        public Nullable<int> CurrentCompany { get; set; }
        public string AnualSalaryType { get; set; }
        public string AnnualSalaryInlakhs { get; set; }
        public Nullable<int> AnnualSalaryInThousand { get; set; }
        public Nullable<int> WorkingSinceYear { get; set; }
        public string WotkingSinceMonth { get; set; }
        public string WorkingTo { get; set; }
        public Nullable<int> CurrentLocationID { get; set; }
        public string CityName { get; set; }
        public Nullable<bool> OutSideIndia { get; set; }
        public Nullable<int> OutSideIndiaCountryID { get; set; }
        public string OutSideIndiaCity { get; set; }
        public Nullable<int> NoticePeriod { get; set; }
        public Nullable<bool> ServeNoticePeriod { get; set; }
        public Nullable<int> LastWorkingDay_Year { get; set; }
        public Nullable<int> Last_Working_Month { get; set; }
        public Nullable<int> Last_WorkingDate { get; set; }
        public string NewOfferedSalaryIn { get; set; }
        public Nullable<int> NewOfferedSalaryInLakh { get; set; }
        public Nullable<int> NewOfferedSalaryInThousand { get; set; }
        public Nullable<int> OfferedDesignation { get; set; }
        public Nullable<int> NewCompany { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int PassingYear { get; set; }


    }
    public class UserPreEmployeementDetails
    {
        public long PreEmpID { get; set; }
        public long UserID { get; set; }
        public Nullable<int> Desigation { get; set; }
        public Nullable<int> Company { get; set; }
        public Nullable<int> Duration_FromYear { get; set; }
        public Nullable<int> Duration_FromMonth { get; set; }
        public Nullable<int> Duration_ToYear { get; set; }
        public string Duration_ToMonth { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
    public class UserEducationDetails
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
        public System.DateTime CreatedDate { get; set; }
        public long UserId { get; set; }
    }
}
