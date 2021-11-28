using System;
using System.Collections.Generic;

#nullable disable

namespace JsuPlus.Infrastructure
{
    public partial class Tbladdress
    {
        public int Id { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
