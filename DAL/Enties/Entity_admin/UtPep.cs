using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class UtPep
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Freq { get; set; }
        public string Ugol { get; set; }
        public string Type { get; set; }
        public string Sert { get; set; }
        public DateTime? SertValidDate { get; set; }
        public string Logger { get; set; }
        public int? IdMash { get; set; }
    }
}
