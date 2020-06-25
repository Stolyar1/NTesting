using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class YandexEmailRefresh
    {
        public int Id { get; set; }
        public string UsernameToSend { get; set; }
        public DateTime? DataAdd { get; set; }
        public string Message { get; set; }
        public string UsernameSender { get; set; }
        public string ResponseText { get; set; }
    }
}
