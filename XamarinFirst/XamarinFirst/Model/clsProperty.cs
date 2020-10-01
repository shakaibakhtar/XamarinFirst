using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XamarinFirst.Model
{
    public class clsProperty
    {
        public int? UnitId { get; set; }
        public string UnitName { get; set; }
        public int? PropertyTypeId { get; set; }
        public int? PropertyTypeDetailId { get; set; }
        public string TypeName { get; set; }
        public string TypeDetailName { get; set; }
        public int? AreaId { get; set; }
        public string AreaName { get; set; }
        public int? AddressId { get; set; }
        public string AddressName { get; set; }
        public int? CityId { get; set; }
        public string CityName { get; set; }
        public int? UnionCouncilId { get; set; }
        public string UnionCouncilName { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int? TehsilId { get; set; }
        public string TehsilName { get; set; }
        public string UnionCouncil { get; set; }
        public string District { get; set; }
        public string Tehsil { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Block { get; set; }
        public int? StreetId { get; set; }
        public int? BlockId { get; set; }
        public string StreetName { get; set; }
        public string BlockName { get; set; }
        public string Longitude { get; set; }
        public string AllInOne { get; set; }
        public string Latitude { get; set; }
        public int? PropertyId { get; set; }
        public int? Property2Id { get; set; }
        public int? CurrencyId { get; set; }
        public int? PropertyNearbyId { get; set; }
        public int? AreaNearbyId { get; set; }
        public string CurrencyName { get; set; }
        public string PropertyName { get; set; }
        public string Description { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? DemandPrice { get; set; }
        public decimal? MinSalePrice { get; set; }
        public decimal? SalePrice { get; set; }
        public string PurchasePriceString { get; set; }
        public string DemandPriceString { get; set; }
        public string MinSalePriceString { get; set; }
        public string SalePriceString { get; set; }
        public decimal? Distance { get; set; }
        public string TravelTimeByWalk { get; set; }
        public string TravelTimeByDrive { get; set; }
        public int? HasBed { get; set; }
        public int? Bed { get; set; }
        public int? OwnerId { get; set; }
        public string OwnerName { get; set; }
        public int? AssignedTo { get; set; }
        public int? AssignedBy { get; set; }
        public string AssignedToUsername { get; set; }
        public string AssignedByUsername { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public string Note { get; set; }
        public string Dimension { get; set; }
        public decimal? Size { get; set; }
        public int? PropertyCharacteristicId { get; set; }
        public string Value { get; set; }
        public string CharacteristicName { get; set; }
        public string CharacteristicType { get; set; }
        public int PropertyCharacteristicValueId { get; set; }
        public int? PropertyStatusId { get; set; }
        public string PropertyStatusName { get; set; }
        public string IsSold { get; set; }
        public string IsSoldString { get; set; }
        public bool? IsPosted { get; set; }
        public string IsPostedString { get; set; }
        public int? PropertyOwnerId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedByString { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedByString { get; set; }
        public string AreaName1 { get; set; }
        public string AreaName2 { get; set; }
        public string AddressName1 { get; set; }
        public string AddressName2 { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string Email { get; set; }
        public int? SoldTo { get; set; }
        public string SoldToUsername { get; set; }
        public int? SoldBy { get; set; }
        public string SoldByUsername { get; set; }
        public List<clsModule> ActionList = new List<clsModule>();
        public List<clsProperty> NearbyPropertiesList = new List<clsProperty>();
        public List<clsProperty> NearbyAreasList = new List<clsProperty>();
        public List<clsProperty> SpecificationsList = new List<clsProperty>();
        public List<clsProperty> OwnersList = new List<clsProperty>();
        public List<clsProperty> AssignedToList = new List<clsProperty>();
        public clsUser UserObject = new clsUser();
        public decimal? ShareInPercent { get; set; }
        public decimal? ShareAmount { get; set; }
        public decimal? CompanyShareAmount { get; set; }
        public int? PropertyAssignId { get; set; }
        public int? UserId { get; set; }
        public int? LoggedInUserId { get; set; }
        public int EngagementId { get; set; }
        public DateTime? EngagementDateTime { get; set; }
        public string Response { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectPartnerId { get; set; }
        public int? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string ShareType { get; set; }
        public decimal? ShareRate { get; set; }
        public decimal? ShareValue { get; set; }
        public int? SerialNo { get; set; }
        public decimal? DealerRate { get; set; }
        public decimal? InvestorRate { get; set; }
        public string ProjectType { get; set; }
        public string DealerIdString { get; set; }
        public string ShareString { get; set; }
        public string OwnerIdString { get; set; }
        public string FromDateString { get; set; }
        public string ToDateString { get; set; }
        // 
    }
    public class clsList
    {
        public int id { get; set; }
        public string text { get; set; }
    }
    public class clsListString
    {
        public string id { get; set; }
        public string text { get; set; }
    }
    public class Select2PagedResult
    {
        public int Total { get; set; }

        public List<clsList> Results { get; set; }
    }
    public class Select2PagedResultString
    {
        public int Total { get; set; }

        public List<clsListString> Results { get; set; }
    }
}