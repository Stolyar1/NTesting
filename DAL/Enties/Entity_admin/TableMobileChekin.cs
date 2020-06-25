using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class TableMobileChekin
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string DataBaseName { get; set; }
        public string UserName { get; set; }
        public DateTime? DataAdd { get; set; }
        public string Comment { get; set; }
        public string Action { get; set; }
        public string DeviceInfo { get; set; }
        public string JsonData { get; set; }
        public int TableId { get; set; }
        public string MobileGeolocation { get; set; }
        public string ActionId { get; set; }
    }
}
