using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class MessageWeb
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
        public string Login { get; set; }
        public DateTime? Time { get; set; }
        public int? Type { get; set; }
        public string GroupAccess { get; set; }
        public string Visible { get; set; }
    }
}
