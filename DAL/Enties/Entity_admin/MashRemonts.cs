using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class MashRemonts
    {
        public int Id { get; set; }
        public int ИдОборудования { get; set; }
        public string ФиоОтправителя { get; set; }
        public string УчастокМвз { get; set; }
        public string ПричинаРемонта { get; set; }
        public DateTime? ДатаРемонта { get; set; }
        public DateTime? ДатаЗавершения { get; set; }
        public string Организация { get; set; }
        public double? Стоимость { get; set; }
        public string СчетаНаОплату { get; set; }
        public DateTime? ДатаВыставленногоСчета { get; set; }
        public string АктаВыполненныхРабот { get; set; }
        public DateTime? ДатаАктаВыполненныхРабот { get; set; }
        public DateTime? ДатаДобавления { get; set; }
        public string Коментарий { get; set; }
        public string Logger { get; set; }
    }
}
