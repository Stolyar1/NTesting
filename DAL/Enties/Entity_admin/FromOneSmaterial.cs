using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class FromOneSmaterial
    {
        public int Id { get; set; }
        public string Ид1с { get; set; }
        public string РабочееНаименование { get; set; }
        public string НаименованиеДляПечати { get; set; }
        public string ИнвНомер { get; set; }
        public string ЗаводскойНомер { get; set; }
        public string Количество { get; set; }
        public string ЕдИзм { get; set; }
        public string АртикулПроизводителя { get; set; }
        public string Склад { get; set; }
        public double? ФактНаСкладе { get; set; }
        public DateTime? ДатаСинхронизации { get; set; }
        public string ТекущийСтатус { get; set; }
        public string JsonData { get; set; }
        public string ScladId { get; set; }
    }
}
