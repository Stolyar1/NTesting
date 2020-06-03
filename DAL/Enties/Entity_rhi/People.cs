using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class People
    {
        public int Код { get; set; }
        public string LongName { get; set; }
        public string IdentyId { get; set; }
        public DateTime? DateDo { get; set; }
        public string MetodControl { get; set; }
        public string ObjectControl { get; set; }
        public string Position { get; set; }
    }
}
