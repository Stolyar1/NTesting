using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
