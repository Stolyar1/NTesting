using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class PersonalTransport
    {
        public int Id { get; set; }
        public string Фио { get; set; }
        public string Почта { get; set; }
        public string Откуда { get; set; }
        public string Куда { get; set; }
        public DateTime? Дата { get; set; }
        public string Коментарий { get; set; }
        public int? ИдПерсонал { get; set; }
        public string Logger { get; set; }
    }
}
