using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class NotificationTelegram
    {
        public int Id { get; set; }
        public string ChatId { get; set; }
        public string UserName { get; set; }
        public int? Notify { get; set; }
        public DateTime? TimeAdd { get; set; }
        public int? UserDialogs { get; set; }
        public int? Acess { get; set; }
        public int? Aup { get; set; }
        public int? Admin { get; set; }
        public string OtherGroup { get; set; }
    }
}
