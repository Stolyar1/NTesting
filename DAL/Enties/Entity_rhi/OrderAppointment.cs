using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class OrderAppointment
    {
        public int IdПриказ { get; set; }
        public int? IdПерсонал { get; set; }
        public string НомерДоговора { get; set; }
        public string Номер { get; set; }
        public DateTime? Дата { get; set; }
        public string Организация { get; set; }
        public string Должность { get; set; }
        public string Тип { get; set; }
    }
}
