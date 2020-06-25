using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class LocationMvz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LocationId { get; set; }
        public string Email { get; set; }
        public string Person { get; set; }
        public int? Actual { get; set; }
        public string Logger { get; set; }
        public string Hach { get; set; }
        public string SmalName { get; set; }
    }
}
