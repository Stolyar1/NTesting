using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class TableSms
    {
        public int Id { get; set; }
        public string ToSendUsername { get; set; }
        public string Phone { get; set; }
        public string Responsetext { get; set; }
        public string ResponseId { get; set; }
        public string SenderUsername { get; set; }
        public string SendMessage { get; set; }
        public string Status { get; set; }
        public DateTime? DataAdd { get; set; }
        public string СтатусДоставки { get; set; }
    }
}
