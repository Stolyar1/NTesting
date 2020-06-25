using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class StObraz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nomer { get; set; }
        public string SertNomer { get; set; }
        public DateTime? SertData { get; set; }
        public DateTime? SertValidData { get; set; }
        public string MetodNk { get; set; }
    }
}
