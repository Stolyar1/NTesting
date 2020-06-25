using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class ReportsMailFromCustomer
    {
        public int Id { get; set; }
        public string Operator { get; set; }
        public string AttachPath { get; set; }
        public string Customer { get; set; }
        public string MailHtmlData { get; set; }
        public string SenderHost { get; set; }
        public string Uid { get; set; }
        public DateTime? TimeAdd { get; set; }
        public string DataBaseName { get; set; }
        public string TableName { get; set; }
        public string ClientPc { get; set; }
        public string MailToJson { get; set; }
        public string Theme { get; set; }
        public string JsonData { get; set; }
        public string Status { get; set; }
    }
}
