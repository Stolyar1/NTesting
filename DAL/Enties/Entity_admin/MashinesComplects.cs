using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class MashinesComplects
    {
        public int Id { get; set; }
        public string Наименование { get; set; }
        public string ЗаводскойНомер { get; set; }
        public string ИнвНомер { get; set; }
        public string Коментарий { get; set; }
        public string Статус { get; set; }
        public int? ИдКомплекта { get; set; }
        public int? Количество { get; set; }
        public string Logger { get; set; }
    }
}
