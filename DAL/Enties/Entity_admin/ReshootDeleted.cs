using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class ReshootDeleted
    {
        public int Id { get; set; }
        public int? Код { get; set; }
        public int? ИдТаблицы { get; set; }
        public string ФактДиаметр { get; set; }
        public string ФактТолщина { get; set; }
        public string Коментарий { get; set; }
        public string Заявки { get; set; }
        public DateTime? ДатаДобавленияЗаявки { get; set; }
        public DateTime? ДатаПроведенияКонтроля { get; set; }
        public DateTime? ДатаДобавленияВБд { get; set; }
        public string Линия { get; set; }
        public string Чертёж { get; set; }
        public string СвСоединения { get; set; }
        public string Заключения { get; set; }
        public string Результат { get; set; }
        public string ЛогинОператора { get; set; }
        public string КлеймаДефОв { get; set; }
        public int? АктаПередачи { get; set; }
        public DateTime? ДатаАктаПередачи { get; set; }
        public string КоробкиХранения { get; set; }
        public double? ФактическаяДлинаКонтроля { get; set; }
        public string Локация { get; set; }
        public string НомерДоговора { get; set; }
        public string Заказчик { get; set; }
        public string Таблица { get; set; }
        public string Причина { get; set; }
        public string WeldSumm { get; set; }
        public string AllSumm { get; set; }
        public string FilmType { get; set; }
        public string FilmSize { get; set; }
        public int? FilmCount { get; set; }
        public DateTime? TimeLastChange { get; set; }
        public string FileName { get; set; }
        public string Logger { get; set; }
        public string ПричинаУдаления { get; set; }
    }
}
