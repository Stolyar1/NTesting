using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class OrderDismissal
    {
        public int IdПриказ { get; set; }
        public int? IdПерсонал { get; set; }
        public int? IdДоговор { get; set; }
        public string НомерДоговора { get; set; }
        public string НомерПриказа { get; set; }
        public DateTime? ДатаУвольнения { get; set; }
        public string Организация { get; set; }
        public string Должность { get; set; }
        public string Статус { get; set; }
    }
}
