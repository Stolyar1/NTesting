using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class RequestTable
    {
        public int Id { get; set; }
        public string DataBaseName { get; set; }
        public string TableName { get; set; }
        public string Operator { get; set; }
        public DateTime? TimeStartServer { get; set; }
        public DateTime? TimeEndServer { get; set; }
        public string Status { get; set; }
        public string Guid { get; set; }
        public string HashFile { get; set; }
        public string ReqestName { get; set; }
        public int? CountItems { get; set; }
        public int? НовыеЗаписи { get; set; }
        public int? ОбновлённыеЗаписи { get; set; }
        public string Комментарий { get; set; }
        public string Процедура { get; set; }
    }
}
