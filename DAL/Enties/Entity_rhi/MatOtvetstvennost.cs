using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class MatOtvetstvennost
    {
        public int IdМатОтветственность { get; set; }
        public int? IdПерсонал { get; set; }
        public string Организация { get; set; }
        public string Номер { get; set; }
        public DateTime? Дата { get; set; }
    }
}
