using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class PmiTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Si { get; set; }
        public string Cr { get; set; }
        public string Ni { get; set; }
        public string Mn { get; set; }
        public string Nb { get; set; }
        public string Mo { get; set; }
        public string Logger { get; set; }
    }
}
