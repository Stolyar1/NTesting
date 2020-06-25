using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class UtSop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nomer { get; set; }
        public string Form { get; set; }
        public string Size { get; set; }
        public string Srej { get; set; }
        public string Sert { get; set; }
        public DateTime? SertValidDate { get; set; }
        public string Logger { get; set; }
        public int? IdMash { get; set; }
    }
}
