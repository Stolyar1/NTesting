using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class EmploymentСontract
    {
        public int IdДоговор { get; set; }
        public int? IdПерсонал { get; set; }
        public string ТипДоговора { get; set; }
        public string Номер { get; set; }
        public string Организация { get; set; }
        public DateTime? ДатаЗаключения { get; set; }
        public DateTime? ДатаОкончания { get; set; }
        public string Должность { get; set; }
        public string Статус { get; set; }
    }
}
