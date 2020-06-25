using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class MashCertficate
    {
        public int Id { get; set; }
        public string Номер { get; set; }
        public DateTime? Выдано { get; set; }
        public DateTime? Действительно { get; set; }
        public string Организация { get; set; }
        public string Коментарий { get; set; }
        public double? Стоимость { get; set; }
        public DateTime? ДатаДобавления { get; set; }
        public string УчастокМвз { get; set; }
        public int? ИдОборудования { get; set; }
    }
}
