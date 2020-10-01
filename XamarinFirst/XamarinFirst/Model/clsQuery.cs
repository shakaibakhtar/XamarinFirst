using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XamarinFirst.Model
{
    public class clsQuery
    {
        public int? QueryStatusId { get; set; }
        public int? QueryAssignId { get; set; }
        public string QueryStatusName { get; set; }
        public int? QueryTypeId { get; set; }
        public string QueryTypeName { get; set; }

        public int? QueryId { get; set; }
        public string QueryName { get; set; }
        public DateTime? QueryDate { get; set; }
        public string Message { get; set; }
        public string ContactInfo { get; set; }
        public int? QueryBy { get; set; }
        public string QueryByUsername { get; set; }
        public int? QueryAddedBy { get; set; }
        public string QueryAddedByUsername { get; set; }
        public int? AssignedTo { get; set; }
        public string AssignedToUsername { get; set; }
        public int? AssignedBy { get; set; }
        public string AssignedByUsername { get; set; }
        public string Note { get; set; }
        public string PropertyNote { get; set; }
        public int? InterestedPropertyId { get; set; }
        public string InterestedPropertyName { get; set; }
        public int? ReferredPropertyId { get; set; }
        public string ReferredPropertyName { get; set; }
        public int? AddressId { get; set; }
        public string AddressName { get; set; }
        public int? LabelId { get; set; }
        public string LabelName { get; set; }
        public int? ResponseBy { get; set; }
        public string ResponseByUsername { get; set; }

        public int QueryPropertyId { get; set; }
        public int? InterestedAreaId { get; set; }
        public string AreaName { get; set; }
        public int? CityId { get; set; }
        public string CityName { get; set; }
        public string Block { get; set; }
        public string Street { get; set; }
        public int? BlockId { get; set; }
        public string BlockName { get; set; }
        public int? StreetId { get; set; }
        public string StreetName { get; set; }
        public int? PropertyTypeId { get; set; }
        public string PropertyTypeName { get; set; }
        public int? PropertyTypeDetailId { get; set; }
        public string PropertyTypeDetailName { get; set; }
        public string PropertyName { get; set; }
        public string Description { get; set; }
        public int? CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public decimal? FromPrice { get; set; }
        public decimal? ToPrice { get; set; }
        public int? UnitId { get; set; }
        public string UnitName { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Size { get; set; }
        public int? PropertyCharacteristicId { get; set; }
        public string Value { get; set; }
        public string CharacteristicName { get; set; }
        public string CharacteristicType { get; set; }
        public int PropertyCharacteristicValueId { get; set; }
        public int QueryResponseId { get; set; }
        public DateTime? ResponseDateTime { get; set; }
        public string Response { get; set; }
        public string Status { get; set; }
        public string AllInOne { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedByString { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedByString { get; set; }
        public List<clsQuery> QueriesList = new List<clsQuery>();
    }
}