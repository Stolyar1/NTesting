using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class CertificatePeopleVst
    {
        public int Id { get; set; }
        public int IdPersonal { get; set; }
        public string НомерСертификата { get; set; }
        public DateTime ДатаВыдачи { get; set; }
        public DateTime ДатаОкончания { get; set; }
        public string АтестационныйЦентр { get; set; }
        public string Организация { get; set; }
        public string ОрганизацияИнн { get; set; }
        public string Сотрудник { get; set; }
        public string Должность { get; set; }
        public string ГруппаДопуска { get; set; }
        public string Logger { get; set; }
        public DateTime? DataAdd { get; set; }
    }
}
