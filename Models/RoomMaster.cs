using System;
using System.Collections.Generic;

namespace hms.Models
{
    public partial class RoomMaster
    {
        public int RoomMasterAutoId { get; set; }
        public int FloorMasterAutoId { get; set; }
        public string RoomNumber { get; set; }
        public string BedType { get; set; }
        public bool? IsAc { get; set; }
        public bool? IsBathRoomAttached { get; set; }
        public string BathRoomType { get; set; }
        public int? MaxPersonsAllowed { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
