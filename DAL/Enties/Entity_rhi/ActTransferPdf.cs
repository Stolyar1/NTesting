using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class ActTransferPdf
    {
        public int? Id { get; set; }
        public string TableName { get; set; }
        public string PathName { get; set; }
        public DateTime? DataTimeAdd { get; set; }
        public int? Nomer { get; set; }
        public string Username { get; set; }
        public string Comment { get; set; }
        public string FullActName { get; set; }
        public string Logger { get; set; }
    }
}
