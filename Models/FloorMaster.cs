using System;
using System.Collections.Generic;

namespace hms.Models
{
    public partial class FloorMaster
    {
        public int FloorMasterAutoId { get; set; }
        public int? BranchMasterAutoId { get; set; }
        public int? FloorNumber { get; set; }
        public string FloorName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
        public bool? DeleteFlag { get; set; }
        public int HmsTenantAutoId { get; set; }
    }
}
