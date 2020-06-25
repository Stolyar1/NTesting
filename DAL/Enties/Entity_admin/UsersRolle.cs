using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class UsersRolle
    {
        public int Id { get; set; }
        public string ИмяРоли { get; set; }
        public string Ответственность { get; set; }
        public string Группа { get; set; }
        public int? МинУровень { get; set; }
        public string HashId { get; set; }
        public string Logger { get; set; }
    }
}
