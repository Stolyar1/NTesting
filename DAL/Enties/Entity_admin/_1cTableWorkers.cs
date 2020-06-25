using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class _1cTableWorkers
    {
        public int Id { get; set; }
        public string Код { get; set; }
        public string Фио { get; set; }
        public DateTime? ДатаРождения { get; set; }
        public string МестоРождения { get; set; }
        public string ВидПаспорта { get; set; }
        public string СерияПаспорта { get; set; }
        public string НомерПаспорта { get; set; }
        public DateTime? ДатаВыдачи { get; set; }
        public string КемВыдан { get; set; }
        public string КодПодразделения { get; set; }
        public string АдресПрописка { get; set; }
        public string АдресПроживания { get; set; }
        public string ВоинскаяОбязанность { get; set; }
        public string ВоинскийУчет { get; set; }
        public string ВоинскоеЗвание { get; set; }
        public string ВоинскийСостав { get; set; }
        public string Вус { get; set; }
        public string ВоинскаяГодность { get; set; }
        public string Образование { get; set; }
        public string Организация { get; set; }
        public string ВидТрудовогоДоговора { get; set; }
        public string Должность { get; set; }
        public string НомерТрудовогоДоговора { get; set; }
        public DateTime? ДатаТрудовогоДоговора { get; set; }
        public DateTime? ДатаОкончанияТрудовогоДоговора { get; set; }
        public DateTime? ДатаПоследнегоОбновления { get; set; }
    }
}
