﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XamarinFirst.Model
{
    public class clsModule
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public int ActionId { get; set; }
        public string ActionName { get; set; }
        public string AllActions { get; set; }
        public int AssignId { get; set; }
        public int UserId { get; set; }
        public int UserRoleId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedByString { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedByString { get; set; }
        public List<clsModule> ModuleList = new List<clsModule>();
        public List<clsModule> ActionList = new List<clsModule>();
    }
}