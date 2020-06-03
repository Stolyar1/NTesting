using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class CertificateDestructiveControl
    {
        public int IdУдостоверение { get; set; }
        public int? IdПерсонал { get; set; }
        public string Тип { get; set; }
        public string ВнутренееНаименование { get; set; }
        public string Организация { get; set; }
        public string НомерУдостоверения { get; set; }
        public DateTime? Выдача { get; set; }
        public DateTime? Окончание { get; set; }
    }
}
