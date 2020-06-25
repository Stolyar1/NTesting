using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class MashinesCheckList
    {
        public int Id { get; set; }
        public int MashineId { get; set; }
        public string CheckType { get; set; }
        public DateTime? DataAdd { get; set; }
        public string UserName { get; set; }
        public string JsonData { get; set; }
        public string Comment { get; set; }
    }
}
