using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class MedicalExamination
    {
        public int IdМО { get; set; }
        public int? IdПерсонал { get; set; }
        public DateTime? ДатаПрохождения { get; set; }
        public DateTime? ДатаСледующегоПрохождения { get; set; }
        public string Организация { get; set; }
        public string Город { get; set; }
        public string ВредныеФакторы { get; set; }
        public string Коментарий { get; set; }
    }
}
