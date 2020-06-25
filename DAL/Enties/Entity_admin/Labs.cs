using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Labs
    {
        public int Id { get; set; }
        public string NameShort { get; set; }
        public string NameRu { get; set; }
        public string NameEn { get; set; }
        public string IdentCard { get; set; }
        public DateTime? IdentDateOt { get; set; }
        public DateTime? IdentDateDo { get; set; }
        public string Logger { get; set; }
        public string ИдОдинС { get; set; }
    }
}
