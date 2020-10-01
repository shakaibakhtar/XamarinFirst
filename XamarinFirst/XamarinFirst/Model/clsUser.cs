using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XamarinFirst.Model
{
    public class clsUser
    {
        public int UserId { get; set; }
        public int? InfoId { get; set; }
        public int? UserTypeId { get; set; }
        public int? LabelId { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public string Status { get; set; }
        public int? AreaId { get; set; }
        public string AreaName { get; set; }
        public int? AreaId1 { get; set; }
        public string AreaName1 { get; set; }
        public int? AreaId2 { get; set; }
        public string AreaName2 { get; set; }
        public int? CityId { get; set; }
        public int IsChangePassword { get; set; }
        public string CityName { get; set; }
        public string UnionCouncil { get; set; }
        public string District { get; set; }
        public string Tehsil { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Block { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        public string UnionCouncil1 { get; set; }
        public string District1 { get; set; }
        public string Tehsil1 { get; set; }
        public string ZipCode1 { get; set; }
        public string Street1 { get; set; }
        public string Block1 { get; set; }
        public string Longitude1 { get; set; }
        public string Latitude1 { get; set; }

        public string UnionCouncil2 { get; set; }
        public string District2 { get; set; }
        public string Tehsil2 { get; set; }
        public string ZipCode2 { get; set; }
        public string Street2 { get; set; }
        public string Block2 { get; set; }
        public string Longitude2 { get; set; }
        public string Latitude2 { get; set; }

        public int? AddressId { get; set; }
        public int? AddressId1 { get; set; }
        public int? AddressId2 { get; set; }
        public string FullName { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string Email { get; set; }
        public string Cnic { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string TypeName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedByString { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedByString { get; set; }
        public string LabelName { get; set; }
        public string AddressName { get; set; }
        public string AddressName1 { get; set; }
        public string AddressName2 { get; set; }
        public int LoginId { get; set; }
        public DateTime? LoginDatetime { get; set; }
        public DateTime? LogoutDatetime { get; set; }
        public string ActivityName { get; set; }
        public string IPAddress { get; set; }
        public string MacAddress { get; set; }
        public decimal? ShareInPercent { get; set; }
    }
}