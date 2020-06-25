using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class TableActionList
    {
        public int Id { get; set; }
        public string ИмяСписка { get; set; }
        public string Таблица { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public DateTime? DataAdd { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
        public int? Count { get; set; }
        public string Partition { get; set; }
    }
}
