using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XamarinFirst.Model
{
    public class clsHRM
    {
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? RelationId { get; set; }
        public string RelationName { get; set; }
        public int? ReligionId { get; set; }
        public string ReligionName { get; set; }
        public int? WorkNatureId { get; set; }
        public string WorkNatureName { get; set; }
        public int EmployeeId { get; set; }
        public string IdentificationNo { get; set; }
        public string FullName { get; set; }
        public string LastNameType { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Country { get; set; }
        public string CNIC { get; set; }
        public string Email { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string ContactNo1 { get; set; }
        public string ContactNo2 { get; set; }
        public string EmgContactNo { get; set; }
        public string EmgContactName { get; set; }
        public string AdditionalNote { get; set; }
        public int? CityId { get; set; }
        public string CityName { get; set; }
        public int? ImmediateBossId { get; set; }
        public string ImmediateBossName { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? DailyAllowance { get; set; }
        public string TimeRecord { get; set; }
        public string JobType { get; set; }
        public string BloodGroup { get; set; }
        public string NTN { get; set; }
        public decimal? SecurityFees { get; set; }
        public string Status { get; set; }
        public int QualificationId { get; set; }
        public string DegreeName { get; set; }
        public string Institute { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string JobTitle { get; set; }
        public int FromYear { get; set; }
        public int FromMonth { get; set; }
        public int ToYear { get; set; }
        public int ToMonth { get; set; }
        public string Organization { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedByString { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedByString { get; set; }
        public string ImagePath { get; set; }
        public int AttendanceId { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public string Attendance { get; set; }
        public TimeSpan? InTime { get; set; }
        public TimeSpan? OutTime { get; set; }
        public int? Minutes { get; set; }
        public DateTime? InTimeDateTime { get; set; }
        public DateTime? OutTimeDateTime { get; set; }
        public List<clsHRM> DateList = new List<clsHRM>();
        public List<clsHRM> EmployeeList = new List<clsHRM>();
        public string AttendanceDay { get; set; }
    }
}