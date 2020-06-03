using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class NtdTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GropTk { get; set; }
        public string Logger { get; set; }
        public string Location { get; set; }
    }
}
