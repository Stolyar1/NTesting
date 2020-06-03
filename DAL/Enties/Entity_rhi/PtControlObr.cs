using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class PtControlObr
    {
        public int Id { get; set; }
        public string MetodNk { get; set; }
        public string Name { get; set; }
        public string SertName { get; set; }
        public string DopuskDate { get; set; }
        public string ValidDate { get; set; }
        public string Logger { get; set; }
    }
}
