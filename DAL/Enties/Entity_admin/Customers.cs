using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Customers
    {
        public int Id { get; set; }
        public string NameRu { get; set; }
        public string NameEn { get; set; }
        public int? Inn { get; set; }
        public string MapOffice { get; set; }
    }
}
