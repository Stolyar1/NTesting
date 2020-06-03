using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class MilitaryDocuments
    {
        public int Id { get; set; }
        public int? IdПерсонал { get; set; }
        public string ТипДокумента { get; set; }
        public string Номер { get; set; }
        public DateTime? Дата { get; set; }
    }
}
