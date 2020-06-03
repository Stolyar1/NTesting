using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Certificate
    {
        public int IdУдостоверение { get; set; }
        public int? IdПерсонал { get; set; }
        public string Тип { get; set; }
        public DateTime? Выдача { get; set; }
        public DateTime? Окончание { get; set; }
        public string Организация { get; set; }
        public string НомерУдостоверения { get; set; }
        public int? Уровень { get; set; }
        public string Группа { get; set; }
        public string Коментарий { get; set; }
        public DateTime? ДатаИмпорта { get; set; }
        public string Logger { get; set; }
        public string Folder { get; set; }
        public int? CertificatOneSid { get; set; }
    }
}
