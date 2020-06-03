using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class ObjectsTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AllTableId { get; set; }
        public string Location { get; set; }
        public string Logger { get; set; }
    }
}
