using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class UsersCallBack
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime? DataAdd { get; set; }
        public string Message { get; set; }
        public string FromUserName { get; set; }
        public string Status { get; set; }
        public string Theme { get; set; }
    }
}
