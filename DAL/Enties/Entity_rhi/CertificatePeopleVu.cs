using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class CertificatePeopleVu
    {
        public int Id { get; set; }
        public int IdPersonal { get; set; }
        public string НомерСертификата { get; set; }
        public DateTime ДатаВыдачи { get; set; }
        public DateTime ДатаОкончания { get; set; }
        public string Категории { get; set; }
        public string Json { get; set; }
        public string Logger { get; set; }
        public string Comment { get; set; }
        public DateTime DataAdd { get; set; }
    }
}
