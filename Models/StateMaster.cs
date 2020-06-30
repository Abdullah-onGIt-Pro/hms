using System;
using System.Collections.Generic;

namespace hms.Models
{
    public partial class StateMaster
    {
        public int StateMasterAutoId { get; set; }
        public string StateName { get; set; }
        public int CountryMasterAutoId { get; set; }
    }
}
