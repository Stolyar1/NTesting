using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class ActTransfer
    {
        public int Код { get; set; }
        public string Таблица { get; set; }
        public string БазаДанных { get; set; }
        public DateTime? ДатаДобавления { get; set; }
        public int? НомерАкта { get; set; }
        public string СсылкаНаФайл { get; set; }
        public string Заказчик { get; set; }
        public string Лаборатория { get; set; }
        public string НомерДоговора { get; set; }
        public string Субподрядчик { get; set; }
        public int? КоличествоЭлементов { get; set; }
        public string СтоимостьПоДоговору { get; set; }
        public string ЛогинОператора { get; set; }
        public string ПредставительЛаборатории { get; set; }
        public string ПредставительЗаказчика { get; set; }
        public string Logger { get; set; }
    }
}
