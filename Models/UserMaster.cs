using System;
using System.Collections.Generic;

namespace hms.Models
{
    public partial class UserMaster
    {
        public int UserMasterAutoId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
        public bool? DeleteFlag { get; set; }
        public int HmsTenantAutoId { get; set; }
    }
}
