using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class UtParam
    {
        public int Код { get; set; }
        public int? ThinOt { get; set; }
        public int? ThinDo { get; set; }
        public string Pep { get; set; }
        public string Sop { get; set; }
        public string Ugol { get; set; }
        public string Chast { get; set; }
        public string Ploshad { get; set; }
    }
}
