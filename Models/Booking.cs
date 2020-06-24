using System;
using System.Collections.Generic;

namespace hms.Models
{
    public partial class Booking
    {
        public int BookingAutoId { get; set; }
        public int RoomMasterAutoId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string AadharNumber { get; set; }
        public int NumberOfPersons { get; set; }
        public bool IsAcRequired { get; set; }
        public DateTime BookingDateTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
        public bool DeleteFlag { get; set; }
        public int HmsTenantAutoId { get; set; }
    }
}
