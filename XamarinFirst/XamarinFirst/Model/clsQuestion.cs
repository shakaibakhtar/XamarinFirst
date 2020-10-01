using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XamarinFirst.Model
{
    public class clsQuestion
    {
        public int? QuestionId { get; set; }
        public string QuestionType { get; set; }
        public string Question { get; set; }
        public string Status { get; set; }
        public string Hint { get; set; }
        public bool? HasAttachment { get; set; }
        public string HasAttachmentString { get; set; }
        public int OptionId { get; set; }
        public string OptionValue { get; set; }
        public int AnswerId { get; set; }
        public string Answer { get; set; }
        public int? UserId { get; set; }
        public string Username { get; set; }
        public string OptionsCount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedByString { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedByString { get; set; }
    }
}